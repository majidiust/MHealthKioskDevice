using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MHealthKiosk
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            RePosition();
        }

      

        public void RePosition()
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int centerX = width / 2;
            int centerY = height / 2;
            int xMargine = 300;
            int yMargine = 100;
            int btnWidth = 300;
            int btnHeight = 300;
            int measureX = centerX + xMargine;
            int measureY = centerY - yMargine - btnHeight;
            int medicalX = centerX - xMargine - btnWidth;
            int medicalY = centerY - yMargine - btnHeight;
            int portalX = centerX + xMargine;
            int portalY = centerY + yMargine;
            int aboutX = centerX - xMargine - btnWidth;
            int aboutY = centerY + yMargine;

            btnMeasure.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnMedicalDocument.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnSalamatYar.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnAboutUs.Size = new System.Drawing.Size(btnWidth, btnHeight);
            btnMeasure.Location = new System.Drawing.Point(measureX, measureY);
            btnMedicalDocument.Location = new System.Drawing.Point(medicalX, medicalY);
            btnSalamatYar.Location = new System.Drawing.Point(portalX, portalY);
            btnAboutUs.Location = new System.Drawing.Point(aboutX, aboutY);
        }

        private void btnSalamatYar_Click(object sender, EventArgs e)
        {
            Portal internalPotalPage = new Portal();
            internalPotalPage.Show();
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            if (userInfo.ShowDialog() == DialogResult.OK)
            {
                (new MeasurementForm()).Show();
            }
        }

        private void btnMedicalDocument_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            (new Help1()).Show();
        }

    }
}
