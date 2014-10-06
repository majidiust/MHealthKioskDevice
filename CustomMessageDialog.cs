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
    public partial class CustomMessageDialog : Form
    {
        public CustomMessageDialog(String message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
