namespace MHealthKiosk
{
    partial class NIBPMeasurementStage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NIBPMeasurementStage));
            this.label2 = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnNIBPStop = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.lblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNIBPStop)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(712, 157);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(506, 146);
            this.label2.TabIndex = 13;
            this.label2.Text = "در حال اندازه گیری فشار خون\r\nلطفاً چند لحظه صبر نمائید...";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.radGroupBox1.Controls.Add(this.lblValue);
            this.radGroupBox1.Controls.Add(this.btnNIBPStop);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Font = new System.Drawing.Font("B Koodak", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "فشار خون";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(1223, 435);
            this.radGroupBox1.TabIndex = 20;
            this.radGroupBox1.Text = "فشار خون";
            this.radGroupBox1.ThemeName = "ControlDefault";
            // 
            // btnNIBPStop
            // 
            this.btnNIBPStop.BackColor = System.Drawing.Color.Transparent;
            this.btnNIBPStop.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnNIBPStop.Image = ((System.Drawing.Image)(resources.GetObject("btnNIBPStop.Image")));
            this.btnNIBPStop.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNIBPStop.ImageScalingSize = new System.Drawing.Size(1, 1);
            this.btnNIBPStop.Location = new System.Drawing.Point(110, 157);
            this.btnNIBPStop.Name = "btnNIBPStop";
            this.btnNIBPStop.Size = new System.Drawing.Size(160, 160);
            this.btnNIBPStop.TabIndex = 21;
            this.btnNIBPStop.Text = "بازگشت";
            this.btnNIBPStop.ThemeName = "Desert";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPStop.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPStop.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPStop.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPStop.GetChildAt(0))).Text = "بازگشت";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPStop.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("B Koodak", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblValue.ForeColor = System.Drawing.Color.Gold;
            this.lblValue.Location = new System.Drawing.Point(439, 180);
            this.lblValue.Name = "lblValue";
            this.lblValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblValue.Size = new System.Drawing.Size(82, 111);
            this.lblValue.TabIndex = 22;
            this.lblValue.Text = "0";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NIBPMeasurementStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "NIBPMeasurementStage";
            this.Size = new System.Drawing.Size(1226, 438);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNIBPStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        public Telerik.WinControls.UI.RadButton btnNIBPStop;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        public System.Windows.Forms.Label lblValue;



    }
}
