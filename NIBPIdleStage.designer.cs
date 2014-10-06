namespace MHealthKiosk
{
    partial class NIBPIdleStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NIBPIdleStage));
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.btnNIBPStart = new Telerik.WinControls.UI.RadButton();
            this.picNIBP = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnNIBPStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNIBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNIBPStart
            // 
            this.btnNIBPStart.BackColor = System.Drawing.Color.Transparent;
            this.btnNIBPStart.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnNIBPStart.Image = ((System.Drawing.Image)(resources.GetObject("btnNIBPStart.Image")));
            this.btnNIBPStart.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNIBPStart.ImageScalingSize = new System.Drawing.Size(1, 1);
            this.btnNIBPStart.Location = new System.Drawing.Point(884, 230);
            this.btnNIBPStart.Name = "btnNIBPStart";
            this.btnNIBPStart.Size = new System.Drawing.Size(160, 160);
            this.btnNIBPStart.TabIndex = 19;
            this.btnNIBPStart.Text = "بازگشت";
            this.btnNIBPStart.ThemeName = "Desert";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPStart.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPStart.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPStart.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPStart.GetChildAt(0))).Text = "بازگشت";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnNIBPStart.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // picNIBP
            // 
            this.picNIBP.Image = ((System.Drawing.Image)(resources.GetObject("picNIBP.Image")));
            this.picNIBP.Location = new System.Drawing.Point(14, 45);
            this.picNIBP.Name = "picNIBP";
            this.picNIBP.Size = new System.Drawing.Size(652, 377);
            this.picNIBP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNIBP.TabIndex = 11;
            this.picNIBP.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(595, 68);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(623, 120);
            this.label2.TabIndex = 12;
            this.label2.Text = "کاف را مطابق تصویر مقابل بسته و سپس\r\nدکمه شروع را فشار دهید";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.btnNIBPStart);
            this.radGroupBox1.Controls.Add(this.picNIBP);
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
            this.radGroupBox1.TabIndex = 18;
            this.radGroupBox1.Text = "فشار خون";
            this.radGroupBox1.ThemeName = "ControlDefault";
            // 
            // NIBPIdleStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "NIBPIdleStage";
            this.Size = new System.Drawing.Size(1226, 438);
            ((System.ComponentModel.ISupportInitialize)(this.btnNIBPStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNIBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.EllipseShape ellipseShape1;
        private System.Windows.Forms.PictureBox picNIBP;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        public Telerik.WinControls.UI.RadButton btnNIBPStart;

    }
}
