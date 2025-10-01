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
    public partial class frmShowRoom : Form
    {
        SqlHelperClass sqlHelper = new SqlHelperClass();
        public frmShowRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                MessageBox.Show("Please enter a showroom name.");
                return;
            }
            else
            {
                int insert = sqlHelper.ExecuteNonQuery("insert into tbl_Showroom values (@name)", CommandType.Text,
               new System.Data.SqlClient.SqlParameter("@name", textBox1.Text));
                if (insert > 0)
                {
                    MessageBox.Show("Showroom added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add showroom.");
                }
            }

            this.Close();
        }
    }
}
