namespace MHealthKiosk
{
    partial class Portal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBarRThumbShape1 = new Telerik.WinControls.UI.TrackBarRThumbShape();
            this.trackBarUThumbShape1 = new Telerik.WinControls.UI.TrackBarUThumbShape();
            this.webControl1 = new EO.WebBrowser.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(816, 375);
            this.webControl1.TabIndex = 4;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.webView1;
            // 
            // webView1
            // 
            this.webView1.Url = "http://www.salamat-yar.ir";
            // 
            // radButton3
            // 
            this.radButton3.BackColor = System.Drawing.Color.Transparent;
            this.radButton3.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.radButton3.Location = new System.Drawing.Point(50, 148);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(99, 50);
            this.radButton3.TabIndex = 7;
            this.radButton3.Text = "تازه سازی";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click_1);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).Text = "تازه سازی";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // radButton2
            // 
            this.radButton2.BackColor = System.Drawing.Color.Transparent;
            this.radButton2.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.radButton2.Location = new System.Drawing.Point(49, 204);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(99, 50);
            this.radButton2.TabIndex = 6;
            this.radButton2.Text = "صفحه قبل";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click_1);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton2.GetChildAt(0))).Text = "صفحه قبل";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton2.GetChildAt(0))).Font = new System.Drawing.Font("B Nazanin", 16F);
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.Transparent;
            this.radButton1.Location = new System.Drawing.Point(18, 260);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(130, 50);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "بازگشت ";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click_1);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "بازگشت ";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Font = new System.Drawing.Font("B Nazanin", 22F);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 375);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.webControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Portal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.TrackBarRThumbShape trackBarRThumbShape1;
        private Telerik.WinControls.UI.TrackBarUThumbShape trackBarUThumbShape1;
        private EO.WebBrowser.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}