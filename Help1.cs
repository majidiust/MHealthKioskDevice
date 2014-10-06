using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace MHealthKiosk
{
    public partial class Help1 : Telerik.WinControls.UI.RadForm
    {
        public Help1()
        {
            InitializeComponent();
            int panelWidth = radPanel1.Size.Width;
            int panelHeight = radPanel1.Size.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int labelHeight = 80;
            int panelStartX = (width - panelWidth) / 2;
            int panelStartY = (height - panelHeight) / 2 + labelHeight;
            radPanel1.Location = new System.Drawing.Point(panelStartX, panelStartY);
            radButton1.Location = new System.Drawing.Point(20, height - 80);
            radLabel1.Location = new System.Drawing.Point((width - radLabel1.Size.Width)/2, 20);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
