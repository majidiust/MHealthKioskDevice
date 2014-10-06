namespace MHealthKiosk
{
    partial class NIBPErrorStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NIBPErrorStage));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnNIBPReturn = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNIBPReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.radGroupBox1.Controls.Add(this.btnNIBPReturn);
            this.radGroupBox1.Controls.Add(this.lblError);
            this.radGroupBox1.Font = new System.Drawing.Font("B Koodak", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "فشار خون";
            this.radGroupBox1.Location = new System.Drawing.Point(6, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(1215, 427);
            this.radGroupBox1.TabIndex = 24;
            this.radGroupBox1.Text = "فشار خون";
            this.radGroupBox1.ThemeName = "ControlDefault";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("B Koodak", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblError.ForeColor = System.Drawing.Color.Gold;
            this.lblError.Location = new System.Drawing.Point(469, 186);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(741, 70);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "اندازه گیری با خطا مواجه شد. لطفاً مجدداً تلاش نمائید.";
            // 
            // btnNIBPReturn
            // 
            this.btnNIBPReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnNIBPReturn.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnNIBPReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnNIBPReturn.Image")));
            this.btnNIBPReturn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNIBPReturn.ImageScalingSize = new System.Drawing.Size(1, 1);
            this.btnNIBPReturn.Location = new System.Drawing.Point(180, 144);
            this.btnNIBPReturn.Name = "btnNIBPReturn";
            this.btnNIBPReturn.Size = new System.Drawing.Size(160, 160);
            this.btnNIBPReturn.TabIndex = 26;
            this.btnNIBPReturn.Text = "بازگشت";
            this.btnNIBPReturn.ThemeName = "Desert";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPReturn.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPReturn.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPReturn.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPReturn.GetChildAt(0))).Text = "بازگشت";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPReturn.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // NIBPErrorStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "NIBPErrorStage";
            this.Size = new System.Drawing.Size(1226, 438);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNIBPReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        public Telerik.WinControls.UI.RadButton btnNIBPReturn;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        public System.Windows.Forms.Label lblError;
    }
}
