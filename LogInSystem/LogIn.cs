using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string adminUser = Data.adminUser, adminPass = Data.adminPass, guestUser = Data.guestUser, guestPass = Data.guestPass;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lblMessage.Text = "";
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                lbl1.Visible = true;
                lblMessage.Text = "Please input Username.";
                return;
            }

            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                lbl2.Visible = true;
                lblMessage.Text = "Please input Password.";
                return;
            }

            if (tbUsername.Text == adminUser)
            {
                if (tbPassword.Text == adminPass)
                {
                    Admin db = new Admin();
                    lblSession.Text = tbUsername.Text;
                    db.Show();
                    this.Hide();

                }
                else
                {
                    lbl2.Visible = true;
                    lblMessage.Text = "Wrong Password.";
                }
            }
            else if (tbUsername.Text == guestUser)
            {
                if (tbPassword.Text == guestPass)
                {
                    User db = new User();
                    lblSession.Text = tbUsername.Text;
                    db.Show();
                    this.Hide();
                }
                else
                {
                    lbl2.Visible = true;
                    lblMessage.Text = "Wrong Password.";
                }
            }
            else
            {
                lblMessage.Text = "Account does not exist.";
            }
        }
    }
}
