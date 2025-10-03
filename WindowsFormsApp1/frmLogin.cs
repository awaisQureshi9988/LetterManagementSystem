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
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
          
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Example login check
           
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                this.Hide();

                // Open main form
                frmShowLetters frm = new frmShowLetters();
                frm.ShowDialog();

                
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
