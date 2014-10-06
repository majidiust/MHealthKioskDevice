using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MHealthKiosk
{
    public partial class MeasurementForm : Form
    {
        private Pen mGraphPen;

        #region Data

        private const int SPO2_GAP = 20;
        private const int SPO2_STEP = 2;
        private int mSPO2Zero;
        private int mGraphHeight;
        private int[] mSPO2Data;
        private int mSPO2Pointer = 0;

        private NIBPStage mCurrentNIBPStage = NIBPStage.Idle;
        private MultiModule.NIBPTools mNIBP;
        private bool mNIBPEndDetected = false;

        private MultiModule.SPO2Tools mSPO2;

        private int measuredSpo2Percentage;
        private int measuredSpo2PulseRate;
        private int meausredNIBPSystolic;
        private int meausredNIBPDiastolic;

        #endregion

        public MeasurementForm()
        {
            InitializeComponent();

            DoubleBuffered = true;

            AssignNIBPHandlers();
            ChangeNIBPStage(NIBPStage.Idle);

            #region Setup SPO2

            mGraphPen = new Pen(Brushes.Cyan);
            mGraphPen.Width = 2f;

            mSPO2Data = new int[graphSPO2.Width / SPO2_STEP];
            mGraphHeight = graphSPO2.Height;
            mSPO2Zero = mGraphHeight / 2;
            for (int i = 0; i < mSPO2Data.Length; i++)
                mSPO2Data[i] = mSPO2Zero;

            #endregion

            mNIBP = new MultiModule.NIBPTools();
            mNIBP.RTCPEvent += new MultiModule.RTCP(mNIBP_RTCPEvent);
            mNIBP.StatusReportEvent += new MultiModule.StatusReport(mNIBP_StatusReportEvent);
            mNIBP.NIBPEndNoticeEvent += new MultiModule.EndNIBPNotice(mNIBP_NIBPEndNoticeEvent);
            mNIBP.StartNIBP();

            mSPO2 = new MultiModule.SPO2Tools();
            mSPO2.mSignalDataEvent += new MultiModule.SignalData(mSPO2_mSignalDataEvent);
            mSPO2.mSignalInfoEvent += new MultiModule.SignalInfo(mSPO2_mSignalInfoEvent);
            mSPO2.StartSPO2();

            measuredSpo2PulseRate = UserProfile.SPO2PulseRate = -1;
            measuredSpo2Percentage = UserProfile.SPO2Percentage = -1;
            meausredNIBPSystolic = UserProfile.Systolic = -1;
            meausredNIBPDiastolic = UserProfile.Diastolic = -1;

        }


        void mSPO2_mSignalInfoEvent(int hr, int spo, bool snsd, bool snsa)
        {
            if (!snsd && !snsa)
            {
                this.BeginInvoke((Action)(() =>
                {
                    lblPercentage.Text = spo.ToString() + "%";
                    lblPulseRate.Text = hr.ToString();
                }));
            }
            else
            {
                this.BeginInvoke((Action)(() =>
                {
                    lblPercentage.Text = "---";
                    lblPulseRate.Text = "---";
                }));
            }
        }

        void mSPO2_mSignalDataEvent(int data, bool snsd, bool snsa)
        {
            if (!snsd && !snsa)
            {
                SubmitNewData(data);
            }
            else
            {
                SubmitNewData(0);
            }

        }

        void mNIBP_NIBPEndNoticeEvent()
        {
            mNIBPEndDetected = true;
        }

        void mNIBP_StatusReportEvent(int moduleState, int currentPatientMode, int cycleMode, int errorState, int systol, int diastol, int mean, int pulseRate)
        {
            if (mNIBPEndDetected && mCurrentNIBPStage == NIBPStage.Measurement)
            {
                this.BeginInvoke((Action)(() =>
                {
                    if (errorState != 0 && errorState != 3)
                    {
                        ChangeNIBPStage(NIBPStage.Error);
                        mNIBPEndDetected = false;
                    }
                    else
                    {
                        meausredNIBPSystolic = systol;
                        meausredNIBPDiastolic = diastol;
                        nibpResultStage1.lblSystolic.Text = systol.ToString();
                        nibpResultStage1.lblDiastolic.Text = diastol.ToString();
                        ChangeNIBPStage(NIBPStage.Results);
                        mNIBPEndDetected = false;
                    }
                }));
            }
        }

        void mNIBP_RTCPEvent(int pressure, int errorCode, int stateCode)
        {
            if (mCurrentNIBPStage == NIBPStage.Measurement && (errorCode == 0 || errorCode == 3))
            {
                this.BeginInvoke((Action)(() =>
                {
                    nibpMeasurementStage1.lblValue.Text = pressure.ToString();
                }));
            }
            return;
        }

        private void AssignNIBPHandlers()
        {
            nibpIdleStage1.btnNIBPStart.Click += new EventHandler(btnNIBPStart_Click);
            nibpMeasurementStage1.btnNIBPStop.Click += new EventHandler(btnNIBPStop_Click);
            nibpResultStage1.btnNIBPReturn.Click += new EventHandler(btnNIBPReturn_Click);
            nibpErrorStage1.btnNIBPReturn.Click += new EventHandler(btnNIBPReturn_Click);
        }

        void btnNIBPReturn_Click(object sender, EventArgs e)
        {
            ChangeNIBPStage(NIBPStage.Idle);
        }

        void btnNIBPStop_Click(object sender, EventArgs e)
        {
            MultiModule.NIBPTools.StopNIBPMeasurement("172.30.31.32");
            ChangeNIBPStage(NIBPStage.Idle);
        }

        void btnNIBPStart_Click(object sender, EventArgs e)
        {
            MultiModule.NIBPTools.StartNIBPMeasurement("172.30.31.32");
            ChangeNIBPStage(NIBPStage.Measurement);
        }

        private void ChangeNIBPStage(NIBPStage stage)
        {
            mCurrentNIBPStage = stage;

            switch (stage)
            {
                case NIBPStage.Idle:
                    nibpIdleStage1.Visible = true;
                    nibpMeasurementStage1.Visible = false;
                    nibpResultStage1.Visible = false;
                    nibpErrorStage1.Visible = false;
                    break;
                case NIBPStage.Measurement:
                    nibpIdleStage1.Visible = false;
                    nibpMeasurementStage1.Visible = true;
                    nibpResultStage1.Visible = false;
                    nibpErrorStage1.Visible = false;
                    break;
                case NIBPStage.Results:
                    nibpIdleStage1.Visible = false;
                    nibpMeasurementStage1.Visible = false;
                    nibpResultStage1.Visible = true;
                    nibpErrorStage1.Visible = false;
                    break;
                case NIBPStage.Error:
                    nibpIdleStage1.Visible = false;
                    nibpMeasurementStage1.Visible = false;
                    nibpResultStage1.Visible = false;
                    nibpErrorStage1.Visible = true;
                    break;
            }
        }

        private void SetNIBPError(int errorCode)
        {
            //nibpErrorStage1.lblError.Text = 
        }

        private void DummySPO2Data()
        {
            Random rand = new Random();

            try
            {
                while (true)
                {
                    int newData = rand.Next(graphSPO2.Height / 2 - 100, graphSPO2.Height / 2 + 100);
                    mSPO2Data[mSPO2Pointer] = newData;
                    mSPO2Pointer++;
                    if (mSPO2Pointer >= mSPO2Data.Length)
                        mSPO2Pointer = 0;
                    graphSPO2.Invalidate();

                    Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void graphSPO2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (mSPO2Data == null)
                    return;

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                for (int i = 1; i <= mSPO2Pointer; i++)
                {
                    e.Graphics.DrawLine(mGraphPen, new Point((i - 1) * SPO2_STEP, mSPO2Data[i - 1]), new Point(i * SPO2_STEP, mSPO2Data[i]));
                }

                for (int i = mSPO2Pointer + SPO2_GAP; i < mSPO2Data.Length; i++)
                {
                    e.Graphics.DrawLine(mGraphPen, new Point((i - 1) * SPO2_STEP, mSPO2Data[i - 1]), new Point(i * SPO2_STEP, mSPO2Data[i]));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SubmitNewData(int data)
        {
            int newData = mGraphHeight - (int)(((float)data / 256) * (mGraphHeight));
            mSPO2Data[mSPO2Pointer] = newData;
            mSPO2Pointer++;
            if (mSPO2Pointer >= mSPO2Data.Length)
                mSPO2Pointer = 0;
            graphSPO2.Invalidate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserProfile.Systolic = meausredNIBPSystolic;
            UserProfile.Diastolic = meausredNIBPDiastolic;
            if ((measuredSpo2Percentage == -1 && meausredNIBPSystolic == -1))
            {
                new CustomMessageDialog("خواهشمند است ابتدا اندازه گیری را انجام داده و سپس اقدام به ذخیره سازی نمایید.").ShowDialog();
            }
            else if ((new CustomMessageDialog("خواهشمند است جهت اهراز هویت، مطابق دستور العملی که به تلفن همراه شما ارسال میشود، عمل نمایید..")).ShowDialog() == DialogResult.OK)
            {
                try
                {
                    new Thread(new ThreadStart(() => {
                        try
                        {
                            MhealthKioskService.MHealthKioskServiceClient client = new MhealthKioskService.MHealthKioskServiceClient();
                            client.AddVisit("203", UserProfile.NationalID, UserProfile.MobileNumber, UserProfile.Systolic.ToString(), UserProfile.Diastolic.ToString(), UserProfile.SPO2Percentage.ToString(), UserProfile.SPO2PulseRate.ToString());
                        }
                        catch (Exception ex)
                        {
                        }
                    })).Start();
                    
                    this.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void MeasurementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mNIBP.StopNIBP();
            mSPO2.StopSPO2();
        }
    }

    public enum NIBPStage
    {
        Idle,
        Measurement,
        Results,
        Error
    }
}
