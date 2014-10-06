namespace MHealthKiosk
{
    partial class MeasurementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasurementForm));
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.label1 = new System.Windows.Forms.Label();
            this.graphSPO2 = new System.Windows.Forms.PictureBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblPulseRate = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nibpErrorStage1 = new MHealthKiosk.NIBPErrorStage();
            this.nibpMeasurementStage1 = new MHealthKiosk.NIBPMeasurementStage();
            this.nibpIdleStage1 = new MHealthKiosk.NIBPIdleStage();
            this.nibpResultStage1 = new MHealthKiosk.NIBPResultStage();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphSPO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.ImageScalingSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Location = new System.Drawing.Point(26, 12);
            this.btnCancel.Name = "btnCancel";
            // 
            // 
            // 
            this.btnCancel.RootElement.Shape = this.ellipseShape1;
            this.btnCancel.Size = new System.Drawing.Size(128, 128);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.ThemeName = "Desert";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnCancel.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnCancel.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnCancel.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnCancel.GetChildAt(0))).Text = "بازگشت";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnCancel.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.ImageScalingSize = new System.Drawing.Size(1, 1);
            this.btnSave.Location = new System.Drawing.Point(194, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 128);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "بازگشت";
            this.btnSave.ThemeName = "Desert";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = "بازگشت";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Koodak", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(617, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 125);
            this.label1.TabIndex = 2;
            this.label1.Text = "اندازه گیری علائم حیاتی";
            // 
            // graphSPO2
            // 
            this.graphSPO2.BackColor = System.Drawing.Color.Black;
            this.graphSPO2.Location = new System.Drawing.Point(14, 42);
            this.graphSPO2.Name = "graphSPO2";
            this.graphSPO2.Size = new System.Drawing.Size(652, 327);
            this.graphSPO2.TabIndex = 10;
            this.graphSPO2.TabStop = false;
            this.graphSPO2.Paint += new System.Windows.Forms.PaintEventHandler(this.graphSPO2_Paint);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.radGroupBox2.Controls.Add(this.lblPulseRate);
            this.radGroupBox2.Controls.Add(this.lblPercentage);
            this.radGroupBox2.Controls.Add(this.label2);
            this.radGroupBox2.Controls.Add(this.label3);
            this.radGroupBox2.Controls.Add(this.graphSPO2);
            this.radGroupBox2.Font = new System.Drawing.Font("B Koodak", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "اکسیژن خون";
            this.radGroupBox2.Location = new System.Drawing.Point(26, 590);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(1226, 384);
            this.radGroupBox2.TabIndex = 14;
            this.radGroupBox2.Text = "اکسیژن خون";
            // 
            // lblPulseRate
            // 
            this.lblPulseRate.AutoSize = true;
            this.lblPulseRate.Font = new System.Drawing.Font("B Koodak", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPulseRate.ForeColor = System.Drawing.Color.Gold;
            this.lblPulseRate.Location = new System.Drawing.Point(776, 220);
            this.lblPulseRate.Name = "lblPulseRate";
            this.lblPulseRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPulseRate.Size = new System.Drawing.Size(134, 111);
            this.lblPulseRate.TabIndex = 14;
            this.lblPulseRate.Text = "---";
            this.lblPulseRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("B Koodak", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPercentage.ForeColor = System.Drawing.Color.Gold;
            this.lblPercentage.Location = new System.Drawing.Point(776, 94);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPercentage.Size = new System.Drawing.Size(134, 111);
            this.lblPercentage.TabIndex = 13;
            this.lblPercentage.Text = "---";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Koodak", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(945, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 83);
            this.label2.TabIndex = 12;
            this.label2.Text = "ضربان قلب:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Koodak", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(945, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 83);
            this.label3.TabIndex = 11;
            this.label3.Text = "درصد اکسیژن:";
            // 
            // nibpErrorStage1
            // 
            this.nibpErrorStage1.BackColor = System.Drawing.Color.Transparent;
            this.nibpErrorStage1.Location = new System.Drawing.Point(26, 143);
            this.nibpErrorStage1.Name = "nibpErrorStage1";
            this.nibpErrorStage1.Size = new System.Drawing.Size(1226, 438);
            this.nibpErrorStage1.TabIndex = 18;
            // 
            // nibpMeasurementStage1
            // 
            this.nibpMeasurementStage1.BackColor = System.Drawing.Color.Transparent;
            this.nibpMeasurementStage1.Location = new System.Drawing.Point(26, 143);
            this.nibpMeasurementStage1.Name = "nibpMeasurementStage1";
            this.nibpMeasurementStage1.Size = new System.Drawing.Size(1226, 438);
            this.nibpMeasurementStage1.TabIndex = 17;
            // 
            // nibpIdleStage1
            // 
            this.nibpIdleStage1.BackColor = System.Drawing.Color.Transparent;
            this.nibpIdleStage1.Location = new System.Drawing.Point(26, 143);
            this.nibpIdleStage1.Name = "nibpIdleStage1";
            this.nibpIdleStage1.Size = new System.Drawing.Size(1226, 438);
            this.nibpIdleStage1.TabIndex = 16;
            // 
            // nibpResultStage1
            // 
            this.nibpResultStage1.BackColor = System.Drawing.Color.Transparent;
            this.nibpResultStage1.Location = new System.Drawing.Point(26, 143);
            this.nibpResultStage1.Name = "nibpResultStage1";
            this.nibpResultStage1.Size = new System.Drawing.Size(1226, 438);
            this.nibpResultStage1.TabIndex = 15;
            // 
            // MeasurementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 986);
            this.Controls.Add(this.nibpErrorStage1);
            this.Controls.Add(this.nibpMeasurementStage1);
            this.Controls.Add(this.nibpIdleStage1);
            this.Controls.Add(this.nibpResultStage1);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeasurementForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MeasurementForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphSPO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox graphSPO2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private NIBPResultStage nibpResultStage1;
        private NIBPIdleStage nibpIdleStage1;
        private NIBPMeasurementStage nibpMeasurementStage1;
        private NIBPErrorStage nibpErrorStage1;
        public System.Windows.Forms.Label lblPulseRate;
        public System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

