using Bunifu.UI.WinForms;
using Hostel_Management_System.Controllers;
using Hostel_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.User_Controls
{
    public partial class StudentsPanel : UserControl
    {
        public static int add_sts;
        public static string s_id;
        public static int up_sts;

        public StudentsPanel()
        {
            InitializeComponent();
        }

        private void addStd()
        {
            this.Grid.DataSource = null;
            this.Grid.Rows.Clear();

            ReadData readData = new ReadData();
            DataTable userData = readData.ReadTableData("Students");

            if (userData != null)
            {
                foreach (DataRow dr in userData.Rows)
                {
                    Grid.Rows.Add(dr["Id"], dr["FirstName"], dr["LastName"], dr["Address"], dr["NIC"], dr["Birthday"], dr["Sex"], dr["ContactNumber"], dr["Email"]);

                }
            }
        }

        private void StudentsPanel_Load(object sender, EventArgs e)
        {
            addStd();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Forms.AddStudent().ShowDialog();
            if (add_sts == 1)
            {
                addStd();
                add_sts = 0;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            s_id = $"{Grid.CurrentRow.Cells[0].Value.ToString()}";
            if (s_id == null)
            {
                s_id = "0";
            }

            if (s_id != null)
            {
                Forms.UpdateStudent upsts = new Forms.UpdateStudent();  
                upsts.ShowDialog();
                if (up_sts == 1)
                {
                    addStd();
                    up_sts = 0;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            s_id = $"{Grid.CurrentRow.Cells[0].Value.ToString()}";
            string tablename = "Students";
            string idname = "Id";
            if (s_id != null)
            {
                bool isDeleted = new DeleteData().DeleteRecord(tablename, idname, int.Parse(s_id));
                if (isDeleted)
                {
                    MessageBox.Show("Student Record Deleted");
                    addStd();
                }
                else
                {
                    MessageBox.Show("Unable To Delete");
                }
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            s_id = $"{Grid.CurrentRow.Cells[0].Value.ToString()}";
            if (s_id != null)
            {

                var report = new StudentReport();
                report.Show();
            }
        }
    }
}
