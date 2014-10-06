namespace MHealthKiosk
{
    partial class MainMenu
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
            this.customCircleButton5 = new MHealthKiosk.CustomCircleButton();
            this.customCircleButton4 = new MHealthKiosk.CustomCircleButton();
            this.customCircleButton3 = new MHealthKiosk.CustomCircleButton();
            this.customCircleButton2 = new MHealthKiosk.CustomCircleButton();
            this.customCircleButton1 = new MHealthKiosk.CustomCircleButton();
            this.SuspendLayout();
            // 
            // customCircleButton5
            // 
            this.customCircleButton5.BackColor = System.Drawing.Color.DarkSalmon;
            this.customCircleButton5.Font = new System.Drawing.Font("B Homa", 16F);
            this.customCircleButton5.Location = new System.Drawing.Point(845, 544);
            this.customCircleButton5.Name = "customCircleButton5";
            this.customCircleButton5.Size = new System.Drawing.Size(194, 182);
            this.customCircleButton5.TabIndex = 4;
            this.customCircleButton5.Text = "پرتال سامانه";
            this.customCircleButton5.UseVisualStyleBackColor = false;
            // 
            // customCircleButton4
            // 
            this.customCircleButton4.BackColor = System.Drawing.Color.YellowGreen;
            this.customCircleButton4.Font = new System.Drawing.Font("B Homa", 16F);
            this.customCircleButton4.Location = new System.Drawing.Point(745, 194);
            this.customCircleButton4.Name = "customCircleButton4";
            this.customCircleButton4.Size = new System.Drawing.Size(194, 182);
            this.customCircleButton4.TabIndex = 3;
            this.customCircleButton4.Text = "درباره ما";
            this.customCircleButton4.UseVisualStyleBackColor = false;
            // 
            // customCircleButton3
            // 
            this.customCircleButton3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.customCircleButton3.Font = new System.Drawing.Font("B Homa", 16F);
            this.customCircleButton3.Location = new System.Drawing.Point(511, 364);
            this.customCircleButton3.Name = "customCircleButton3";
            this.customCircleButton3.Size = new System.Drawing.Size(194, 182);
            this.customCircleButton3.TabIndex = 2;
            this.customCircleButton3.Text = " سلامت همراه اول";
            this.customCircleButton3.UseVisualStyleBackColor = false;
            // 
            // customCircleButton2
            // 
            this.customCircleButton2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.customCircleButton2.Font = new System.Drawing.Font("B Homa", 16F);
            this.customCircleButton2.Location = new System.Drawing.Point(267, 523);
            this.customCircleButton2.Name = "customCircleButton2";
            this.customCircleButton2.Size = new System.Drawing.Size(194, 182);
            this.customCircleButton2.TabIndex = 1;
            this.customCircleButton2.Text = "مشاهده پرونده پزشکی";
            this.customCircleButton2.UseVisualStyleBackColor = false;
            // 
            // customCircleButton1
            // 
            this.customCircleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.customCircleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.customCircleButton1.Font = new System.Drawing.Font("B Homa", 16F);
            this.customCircleButton1.Location = new System.Drawing.Point(237, 151);
            this.customCircleButton1.Name = "customCircleButton1";
            this.customCircleButton1.Size = new System.Drawing.Size(194, 182);
            this.customCircleButton1.TabIndex = 0;
            this.customCircleButton1.Text = "اندازه گیری علائم حیاتی";
            this.customCircleButton1.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MHealthKiosk.Properties.Resources.splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 750);
            this.Controls.Add(this.customCircleButton5);
            this.Controls.Add(this.customCircleButton4);
            this.Controls.Add(this.customCircleButton3);
            this.Controls.Add(this.customCircleButton2);
            this.Controls.Add(this.customCircleButton1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منوی اصلی";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CustomCircleButton customCircleButton1;
        private CustomCircleButton customCircleButton2;
        private CustomCircleButton customCircleButton3;
        private CustomCircleButton customCircleButton4;
        private CustomCircleButton customCircleButton5;
    }
}

