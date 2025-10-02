using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmShowLetters : Form
    {
        SqlHelperClass sqlHelper = new SqlHelperClass();
        DataTable dt = new DataTable();
        public frmShowLetters()
        {
            InitializeComponent();
        }

        private void frmShowLetters_Load(object sender, EventArgs e)
        {
           
            dt = sqlHelper.GetDataTable("SELECT c.regNumber AS [Registration Number], c.bikeName           AS [Bike Name], c.horsePower AS [Horse Power], c.engineNumber       AS [Engine Number],c.chassisNumer  AS [Chassis Number], c.customerName   AS [Customer Name],s.ShowroomName AS [Showroom Name], c.contactNumber      AS [Contact Number], c.totalPayment       AS [Total Payment], c.advance            AS [Advance Payment],  c.balance            AS [Balance Payable] FROM    dbo.tbl_letterCustomerDetail c LEFT JOIN  dbo.tbl_Showroom s ON c.showroomName = s.ShowroomID ORDER BY     c.Id DESC;  ", CommandType.Text);
            dataGridView1.DataSource = dt;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            dt = sqlHelper.GetDataTable("SELECT c.regNumber AS [Registration Number], c.bikeName           AS [Bike Name], c.horsePower AS [Horse Power], c.engineNumber       AS [Engine Number],c.chassisNumer  AS [Chassis Number], c.customerName   AS [Customer Name],s.ShowroomName AS [Showroom Name], c.contactNumber      AS [Contact Number], c.totalPayment       AS [Total Payment], c.advance            AS [Advance Payment],  c.balance            AS [Balance Payable] FROM    dbo.tbl_letterCustomerDetail c LEFT JOIN  dbo.tbl_Showroom s ON c.showroomName = s.ShowroomID ORDER BY     c.Id DESC;  ", CommandType.Text);
            dataGridView1.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = "";

            if (rdoRegistrationNumber.Checked)
            {
                filter = $"[Registration Number] LIKE '%{txtSearch.Text}%'";
            }
            else if (rdoChasisNumber.Checked)
            {
                filter = $"[Chassis Number] LIKE '%{txtSearch.Text}%'";
            }
            else if (rdoEngineNumber.Checked)
            {
                filter = $"[Engine Number] LIKE '%{txtSearch.Text}%'";
            }

            DataView dv = dt.DefaultView;
            dv.RowFilter = filter;
            dataGridView1.DataSource = dv;
        }

    }
}
