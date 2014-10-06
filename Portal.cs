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
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
             
                
            }
            catch (Exception ex)
            {
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                webControl1.Refresh();
            }
            catch (Exception ex)
            {
            }
        }

        private void radButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                webControl1.Refresh();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
