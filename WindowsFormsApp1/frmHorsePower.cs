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
    public partial class frmHorsePower: Form
    {
        SqlHelperClass sqlHelper = new SqlHelperClass();
        public frmHorsePower()
        {
            InitializeComponent();
        }

        private void frmHorsePower_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                MessageBox.Show("Please enter a Horse Power.");
                return;
            }
            else
            {
                int insert = sqlHelper.ExecuteNonQuery("insert into tbl_HorsePower values (@name)", CommandType.Text,
               new System.Data.SqlClient.SqlParameter("@name", textBox1.Text));
                if (insert > 0)
                {
                    MessageBox.Show("Horse Power added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add Horse Power.");
                }
            }

            this.Close();
        }
    }
}
