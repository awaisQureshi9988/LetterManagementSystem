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
        public frmShowLetters()
        {
            InitializeComponent();
        }

        private void frmShowLetters_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = sqlHelper.GetDataTable("select * from tbl_letterCustomerDetail ", CommandType.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
