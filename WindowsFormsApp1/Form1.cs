using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        SqlHelperClass sqlHelper = new SqlHelperClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void showLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLetters letter = new frmShowLetters();
            letter.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmCustomersDetail frmCustomerdetail = new frmCustomersDetail();
            frmCustomerdetail.ShowDialog();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = sqlHelper.GetDataTable("SELECT ShowroomID, ShowroomName FROM tbl_Showroom", CommandType.Text);

            cmbShowroom.DataSource = dt;
            cmbShowroom.DisplayMember = "ShowroomName";   
            cmbShowroom.ValueMember = "ShowroomID";       

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmShowLetters showLetter = new frmShowLetters();
            showLetter.ShowDialog();

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowRoom showRoom = new frmShowRoom();
            showRoom.ShowDialog();
            Form1_Load(null, null);
        }
    }
}
