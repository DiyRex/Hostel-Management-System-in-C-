using Hostel_Management_System.Controllers;
using Hostel_Management_System.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername;
            txtUsername.Focus();
        }

        

        private void bunifuToggleSwitch21_CheckedChanged(object sender, EventArgs e)
        {
            if (bunifuToggleSwitch21.Checked)
            {
                grpbox1.Visible = false;
            }
            else
            {
                grpbox1.Visible = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Authentication auth = new Authentication();
            bool authenticate = auth.isAuthenticate(username, password);
            if (authenticate)
            {
                new MainWindow().Show();
                this.Hide();
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            string password = tbpassword.Text;
            string email = tbemail.Text;
            string authkey = tbauthkey.Text;

            bool empty = Validation.AreAnyStringsEmpty(username,password,email,authkey);
            if (!empty)
            {
                if (authkey == Authentication.getAuthKey())
                {
                    Authentication auth = new Authentication();
                    bool isSignUp = auth.SignUp(username, password, email);
                    if (isSignUp)
                    {
                        MessageBox.Show("Registerd");
                    }
                    else
                    {
                        MessageBox.Show("Already Registerd");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid AuthKey");
                }
            }
            else
            {
                MessageBox.Show("All Fields Are Required");
            }
            
        }
    }
}
