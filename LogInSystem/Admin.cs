using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lblMessage.Text = "";
            if (string.IsNullOrEmpty(tbNew.Text))
            {
                lbl1.Visible = true;
                lblMessage.Text = "Please input New Password.";
                return;
            }

            if (rbAdmin.Checked)
            {
                Data.setAdminPass(tbNew.Text);
                lblMessage.Text = "Password Changed Successfully.";
            }
            else if (rbUser.Checked)
            {
                Data.setGuestPass(tbNew.Text);
                lblMessage.Text = "Password Changed Successfully.";
            }
            else
            {
                lbl0.Visible = true;
                lblMessage.Text = "Please select Account.";
            }
        }
    }
}
