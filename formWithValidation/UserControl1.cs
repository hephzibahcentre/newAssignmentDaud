using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formWithValidation
{
    public partial class UserControl1: UserControl
    {
        string userName = string.Empty;
        string userPassword = string.Empty;
        string userPwConfirm = string.Empty;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            confirmBox.Text = String.Empty;

            if (txtUsername.Text.Length < 3) {
                confirmBox.AppendText("Username needs to be at least 3 character!");
                confirmBox.AppendText(Environment.NewLine);
            } else
            {
                userName = txtUsername.Text;
            }

            if (txtPassword.Text.Length < 6)
            {
                confirmBox.AppendText("Password needs to be at least 6 characters!");
                confirmBox.AppendText(Environment.NewLine);
            }
            else
            {
                userPassword = txtPassword.Text;
                if (txtConfirm.Text != txtPassword.Text)
                {
                    confirmBox.AppendText("Passwords do not match!");
                }
                else
                {
                    userPwConfirm = txtConfirm.Text;
                }
            }

            if (userName.Length > 1 && userPwConfirm.Length > 1)
            {
                confirmBox.AppendText("Registered!");
                this.BackColor = System.Drawing.Color.Purple;
            }

        }
    }
}
