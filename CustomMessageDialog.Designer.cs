namespace MHealthKiosk
{
    partial class CustomMessageDialog
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
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.lblMessage = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radGroupBox2);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(710, 390);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "Desert";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radButton1);
            this.radGroupBox2.Controls.Add(this.radPanel2);
            this.radGroupBox2.Controls.Add(this.lblMessage);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.Font = new System.Drawing.Font("B Koodak", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "توجه";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(710, 390);
            this.radGroupBox2.TabIndex = 12;
            this.radGroupBox2.Text = "توجه";
            this.radGroupBox2.ThemeName = "Desert";
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("B Koodak", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radButton1.Location = new System.Drawing.Point(251, 293);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(190, 78);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "متوجه شدم";
            this.radButton1.ThemeName = "Desert";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.Location = new System.Drawing.Point(21, 266);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(663, 10);
            this.radPanel2.TabIndex = 1;
            this.radPanel2.ThemeName = "Desert";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel2.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel2.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(82)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(71)))), ((int)(((byte)(0)))));
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.Brown;
            this.lblMessage.Location = new System.Drawing.Point(37, 107);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(2, 2);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // CustomMessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 390);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageDialog";
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        public Telerik.WinControls.UI.RadLabel lblMessage;
    }
}