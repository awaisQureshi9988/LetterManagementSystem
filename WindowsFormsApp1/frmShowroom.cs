using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmShowroom : Form
    {
        SqlHelperClass db = new SqlHelperClass();
        public frmShowroom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Insert = db.ExecuteNonQuery("INSERT INTO tbl_Showroom VALUES (@name)", CommandType.Text,
                new SqlParameter("@name", textBox1.Text)
                );
            if (Insert > 0)
                MessageBox.Show("Record Inserted");
            else
                MessageBox.Show("Record Not Inserted");
        }
    }
}
