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

            LoadLetters();
            lblBalanceReceivable.Text = GetTotalReceivable().ToString();
            lblReceived.Text = GetTotalReceived().ToString();
            lblTotalLetters.Text =  GetTotalLetterCount().ToString();
            lblCompletedLetters.Text =  GetTotalCompletedLetters().ToString();

        }
        private void LoadLetters()
        {
            string query = @"
    SELECT 
        c.Id AS [ID],
        c.regNumber AS [Registration Number], 
        c.bikeName AS [Bike Name], 
        hp.HorsePower AS [Horse Power],   
        c.engineNumber AS [Engine Number],
        c.chassisNumer AS [Chassis Number], 
        c.customerName AS [Customer Name],
        s.ShowroomName AS [Showroom Name], 
        c.contactNumber AS [Contact Number], 
        CAST(c.totalPayment AS INT) AS [Total Payment], 
        CAST(c.advance AS INT) AS [Advance Payment],  
        CAST(c.balance AS INT) AS [Balance Receivable],
        FORMAT(ISNULL(c.ModifyDate, c.CreatedDate), 'dd-MM-yyyy') AS [Date],
        FORMAT(ISNULL(c.ModifyDate, c.CreatedDate), 'hh:mm tt') AS [Time]
    FROM dbo.tbl_letterCustomerDetail c 
    LEFT JOIN dbo.tbl_Showroom s ON c.showroomName = s.ShowroomID
    LEFT JOIN dbo.tbl_HorsePower hp ON c.horsePower = hp.HID  
    ORDER BY c.Id DESC;
";

            try
            {
                dt = sqlHelper.GetDataTable(query, CommandType.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading letters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            LoadLetters();
            lblBalanceReceivable.Text = GetTotalReceivable().ToString();
            lblReceived.Text = GetTotalReceived().ToString();
            lblTotalLetters.Text = GetTotalLetterCount().ToString();
            lblCompletedLetters.Text = GetTotalCompletedLetters().ToString();

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
       

        private int GetTotalReceived()
        {
            try
            {
                string query = "SELECT ISNULL(SUM(CAST(advance AS INT)), 0) FROM tbl_letterCustomerDetail";
                object result = sqlHelper.ExecuteScalar(query, CommandType.Text);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating Total Received: " + ex.Message);
                return 0;
            }
        }

        private int GetTotalReceivable()
        {
            try
            {
                string query = "SELECT ISNULL(SUM(CAST(balance AS INT)), 0) FROM tbl_letterCustomerDetail";
                object result = sqlHelper.ExecuteScalar(query, CommandType.Text);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating Total Receivable: " + ex.Message);
                return 0;
            }
        }

        private int GetTotalLetterCount()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM tbl_letterCustomerDetail";
                object result = sqlHelper.ExecuteScalar(query, CommandType.Text);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting total letters: " + ex.Message);
                return 0;
            }
        }

        private int GetTotalCompletedLetters()
        {
            try
            {

                string query = @"SELECT COUNT(*) 
                 FROM tbl_letterCustomerDetail 
                 WHERE ISNULL(balance,0) <= 0";

                object result = sqlHelper.ExecuteScalar(query, CommandType.Text);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting completed letters: " + ex.Message);
                return 0;
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure it's not the header row
            {
                
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

               
                Form1 frm = new Form1();
                frm.ID = id;
                frm.ShowDialog();
                LoadLetters();
                lblBalanceReceivable.Text = GetTotalReceivable().ToString();
                lblReceived.Text = GetTotalReceived().ToString();
                lblTotalLetters.Text = GetTotalLetterCount().ToString();
                lblCompletedLetters.Text = GetTotalCompletedLetters().ToString();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }
    }
}
