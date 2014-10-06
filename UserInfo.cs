using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace MHealthKiosk
{
    public partial class UserInfo : Form
    {
        private int mSelectedField = 0;
        private RadTextBox mSelectedRadTextBox;
        public UserInfo()
        {
            InitializeComponent();
            mSelectedRadTextBox = new RadTextBox();
            mSelectedRadTextBox = radTextBox1;
        }

        private void radButton12_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void radTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            mSelectedField = 0;
            mSelectedRadTextBox = radTextBox1;
        }

        private void radTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            mSelectedField = 1;
            mSelectedRadTextBox = radTextBox2;
        }

        private void radTextBox1_Click(object sender, EventArgs e)
        {
            mSelectedField = 0;
            mSelectedRadTextBox = radTextBox1;
        }

        private void radTextBox1_Enter(object sender, EventArgs e)
        {
            mSelectedField = 0;
            mSelectedRadTextBox = radTextBox1;
        }

        private void radTextBox2_Enter(object sender, EventArgs e)
        {
            mSelectedField = 1;
            mSelectedRadTextBox = radTextBox2;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            mSelectedRadTextBox.Text = mSelectedRadTextBox.Text + "1";
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            mSelectedRadTextBox.Text = mSelectedRadTextBox.Text + "2";
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            mSelectedRadTextBox.Text = mSelectedRadTextBox.Text + "3";
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            mSelectedRadTextBox.Text = mSelectedRadTextBox.Text + "4";
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            mSelectedRadTextBox.Text = mSelectedRadTextBox.Text + "5";
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            mSelectedRadTextBox.Text = mSelectedRadTextBox.Text + "6";
        }

        private void radButton9_Click(object sender, EventArgs e)
        {
            mSelectedRadTextBox.Text = mSelectedRadTextBox.Text + "7";
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            mSelectedRadTextBox.Text = mSelectedRadTextBox.Text + "8";
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            mSelectedRadTextBox.Text = mSelectedRadTextBox.Text + "9";
        }

        private void radButton14_Click(object sender, EventArgs e)
        {
            String txt = mSelectedRadTextBox.Text;
            if(txt.Length > 0)
            mSelectedRadTextBox.Text = txt.Substring(0, txt.Length - 1);

        }

        private void radButton10_Click(object sender, EventArgs e)
        {
            mSelectedRadTextBox.Text = mSelectedRadTextBox.Text + "0";
        }

        private void radButton11_Click(object sender, EventArgs e)
        {
            mSelectedRadTextBox.Text = mSelectedRadTextBox.Text + ".";
        }

        private void radButton13_Click(object sender, EventArgs e)
        {
            string id = radTextBox1.Text;
            string phone = radTextBox2.Text;

            if (id == null || id == "" || phone == null || phone == "")
            {
                lblMessage.Text = "لطفاً اطلاعات خواسته شده را تکمیل نمائید.";
                lblMessage.Visible = true;
                return;
            }
            else if(MultiModule.Tools.isValidNationalID(id) == false)
            {
                lblMessage.Text = "لطفا کد ملی را بصورت صحیح وارد نمایید.";
                lblMessage.Visible = true;
                return;
            }
            else if (MultiModule.Tools.isValidPhoneNumber(phone) == false)
            {
                lblMessage.Text = "شماره موبایل را بصورت صحیح وارد نمایید.";
                lblMessage.Visible = true;
                return;
            }

            lblMessage.Visible = true;

            UserProfile.NationalID = id;
            UserProfile.MobileNumber = phone;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
