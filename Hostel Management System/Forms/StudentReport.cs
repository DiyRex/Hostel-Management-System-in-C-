using Hostel_Management_System.Controllers;
using Hostel_Management_System.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Forms
{
    public partial class StudentReport : Form
    {
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument prntdoc = new PrintDocument();
        private string s_id = StudentsPanel.s_id;
        public StudentReport()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.reportpanel);
        }

        private void StudentReport_Load(object sender, EventArgs e)
        {

                ReadData readData = new ReadData();
                DataTable dt = readData.ReadDataWithID("Students", "Id", s_id);
                if (dt != null && dt.Rows.Count > 0)
                {
                    rplbl1.Text = dt.Rows[0]["Id"].ToString();
                    rplbl2.Text = dt.Rows[0]["FirstName"].ToString();
                    rplbl3.Text = dt.Rows[0]["LastName"].ToString();
                    rplbl4.Text = dt.Rows[0]["Address"].ToString().Replace("\r\n", " ");
                    rplbl5.Text = dt.Rows[0]["NIC"].ToString();
                    rplbl6.Text = dt.Rows[0]["Birthday"].ToString();
                    rplbl7.Text = dt.Rows[0]["Sex"].ToString();
                    rplbl8.Text = dt.Rows[0]["ContactNumber"].ToString();
                    rplbl9.Text = dt.Rows[0]["Email"].ToString();
                    rplbl10.Text = dt.Rows[0]["GrdFirstName"].ToString();
                    rplbl11.Text = dt.Rows[0]["GrdLastName"].ToString();
                    rplbl12.Text = dt.Rows[0]["GrdContactNumber"].ToString();
                    rplbl13.Text = dt.Rows[0]["GrdNIC"].ToString();
                    DateTime AddedDate = Convert.ToDateTime(dt.Rows[0]["AddedAt"].ToString());
                    rplbl14.Text = AddedDate.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("Unable to view");
                }
        }

        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            reportpanel = pnl;
            getprintarea(pnl);
            prntprvw.Document = prntdoc;
            prntdoc.PrintPage += new PrintPageEventHandler(prntdoc_printpage);
            prntprvw.ShowDialog();

        }

        public void prntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.reportpanel.Width / 2), this.reportpanel.Location.Y);
        }
        Bitmap memoryimg;
        public void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width * 4, pnl.Height));
        }
    }
}
