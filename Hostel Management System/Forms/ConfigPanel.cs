using Hostel_Management_System.Controllers;
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
    public partial class ConfigPanel : Form
    {
        public ConfigPanel()
        {
            InitializeComponent();
        }

        private void ConfigPanel_Load(object sender, EventArgs e)
        {
            var cfg = Config.getConfigurations();

            tbkeymoney.Text = cfg[0];
            tbauth.Text = cfg[1];
            tbacroomrent.Text = cfg[2];
            tbnacroomrent.Text = cfg[3];
            tbnaccount.Text = cfg[4];
            tbaccount.Text = cfg[5];
            tbhostelmail.Text = cfg[6]; //
            tbsmtpmail.Text = cfg[7]; //
            tbsmtpauth.Text = cfg[8];
            tbsmtpport.Text = cfg[9]; //
            tbhostalname.Text = cfg[10];
            tbmaxstdcount.Text = cfg[11];
            tbmaxbdcount.Text = cfg[12];
        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string hostel_name = tbhostalname.Text;
            string keymoney = tbkeymoney.Text;
            string auth_key = tbauth.Text;
            string ac_rent = tbacroomrent.Text;
            string non_ac_rent = tbnacroomrent.Text;
            string ac_count = tbaccount.Text;
            string non_ac_count = tbnaccount.Text;
            string smtp_mail = tbsmtpmail.Text;
            string smtp_port = tbsmtpport.Text;
            string smtp_password = tbsmtpauth.Text;
            string hostel_mail = tbhostelmail.Text;
            string max_std_count = tbmaxstdcount.Text;
            string max_bed_count = tbmaxbdcount.Text;

            bool isUpdated = Config.updateConfigurations(hostel_name, keymoney, auth_key, ac_rent, non_ac_rent, ac_count, non_ac_count, smtp_mail, smtp_port, smtp_password, hostel_mail, max_std_count, max_bed_count);
            if (isUpdated)
            {
                MessageBox.Show("Configured Successfully !");
            }
            else
            {
                MessageBox.Show("Configuration failed !");
            }
        }
    }
}
