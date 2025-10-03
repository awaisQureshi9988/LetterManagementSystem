using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public int ID { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
            txtRegistrationNumber.Focus();
        }

      
        private void showLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLetters letter = new frmShowLetters();
            letter.ShowDialog();
        }

     

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                if (ID == 0)
                {
                    InsertDate();
                }
                else
                {
                    UpdateData();
                }
               
            }
        }

        private void InsertDate()
        {
            try
            {
                string query = @"INSERT INTO tbl_letterCustomerDetail
                (regNumber, bikeName, horsePower, engineNumber, chassisNumer, 
                 customerName, showroomName, contactNumber, totalPayment, advance, balance)
                VALUES
                (@regNumber, @bikeName, @horsePower, @engineNumber, @chassisNumer, 
                 @customerName, @showroomName, @contactNumber, @totalPayment, @advance, @balance)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@regNumber", txtRegistrationNumber.Text),
                new SqlParameter("@bikeName", txtBikeName.Text),
                new SqlParameter("@horsePower", cmbHorsePower.SelectedValue),
                new SqlParameter("@engineNumber", txtEngineNumber.Text),
                new SqlParameter("@chassisNumer", txtChassesNumber.Text),
                new SqlParameter("@customerName", txtCustomerName.Text),
                new SqlParameter("@showroomName", cmbShowroom.SelectedValue ?? (object)DBNull.Value),
                new SqlParameter("@contactNumber", txtContactNumber.Text),
                new SqlParameter("@totalPayment", string.IsNullOrEmpty(txtTotalPayment.Text) ? (object)DBNull.Value : Convert.ToDecimal(txtTotalPayment.Text)),
                new SqlParameter("@advance", string.IsNullOrEmpty(txtAdvancePayment.Text) ? (object)DBNull.Value : Convert.ToDecimal(txtAdvancePayment.Text)),
                new SqlParameter("@balance", string.IsNullOrEmpty(lblBalancePayable.Text) ? (object)DBNull.Value : Convert.ToDecimal(lblBalancePayable.Text))
                };

                int rows = sqlHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

                if (rows > 0)
                {
                    MessageBox.Show("Record inserted successfully!");



                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insert failed.");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Duplicate entry detected. Please check Registration Number, Engine Number, or Chassis Number.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private void UpdateData()
        {
            try
            {
                string query = @"UPDATE tbl_letterCustomerDetail
                         SET regNumber = @regNumber,
                             bikeName = @bikeName,
                             horsePower = @horsePower,
                             engineNumber = @engineNumber,
                             chassisNumer = @chassisNumer,
                             customerName = @customerName,
                             showroomName = @showroomName,
                             contactNumber = @contactNumber,
                             totalPayment = @totalPayment,
                             advance = @advance,
                             balance = @balance,
                             ModifyDate = GETDATE()
                         WHERE Id = @Id";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Id", ID),
            new SqlParameter("@regNumber", txtRegistrationNumber.Text),
            new SqlParameter("@bikeName", txtBikeName.Text),
            new SqlParameter("@horsePower", cmbHorsePower.SelectedValue),
            new SqlParameter("@engineNumber", txtEngineNumber.Text),
            new SqlParameter("@chassisNumer", txtChassesNumber.Text),
            new SqlParameter("@customerName", txtCustomerName.Text),
            new SqlParameter("@showroomName", cmbShowroom.SelectedValue ?? (object)DBNull.Value),
            new SqlParameter("@contactNumber", txtContactNumber.Text),
            new SqlParameter("@totalPayment", string.IsNullOrEmpty(txtTotalPayment.Text) ? (object)DBNull.Value : Convert.ToDecimal(txtTotalPayment.Text)),
            new SqlParameter("@advance", string.IsNullOrEmpty(txtAdvancePayment.Text) ? (object)DBNull.Value : Convert.ToDecimal(txtAdvancePayment.Text)),
            new SqlParameter("@balance", string.IsNullOrEmpty(lblBalancePayable.Text) ? (object)DBNull.Value : Convert.ToDecimal(lblBalancePayable.Text))
                };

                int rows = sqlHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

                if (rows > 0)
                {
                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update failed. Record may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint violation
                {
                    MessageBox.Show("Duplicate entry detected. Please check Registration Number, Engine Number, or Chassis Number.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }



        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                txtRegistrationNumber.Focus();
            });

          
            DataTable dt = sqlHelper.GetDataTable("SELECT ShowroomID, ShowroomName FROM tbl_Showroom", CommandType.Text);

            DataRow drShowroom = dt.NewRow();
            drShowroom["ShowroomID"] = 0;
            drShowroom["ShowroomName"] = "-- Select Showroom --";
            dt.Rows.InsertAt(drShowroom, 0);

            cmbShowroom.DataSource = dt;
            cmbShowroom.DisplayMember = "ShowroomName";
            cmbShowroom.ValueMember = "ShowroomID";
            cmbShowroom.SelectedIndex = 0;

         
            DataTable dtHorsePower = sqlHelper.GetDataTable("SELECT HID, HorsePower FROM tbl_HorsePower", CommandType.Text);

            DataRow drHorse = dtHorsePower.NewRow();
            drHorse["HID"] = 0;
            drHorse["HorsePower"] = "-- Select Horse Power --";
            dtHorsePower.Rows.InsertAt(drHorse, 0);

            cmbHorsePower.DataSource = dtHorsePower;
            cmbHorsePower.DisplayMember = "HorsePower";  
            cmbHorsePower.ValueMember = "HID";
            cmbHorsePower.SelectedIndex = 0;
            if (ID != 0)
            {
                btnAddUpdate.Text = "Update";
                LoadRecord(ID);
            }
        }
        private void LoadRecord(int id)
        {
            try
            {
                string query = @"SELECT regNumber, bikeName, horsePower, engineNumber, chassisNumer, 
                                customerName, showroomName, contactNumber, totalPayment, 
                                advance, balance 
                         FROM tbl_letterCustomerDetail 
                         WHERE Id = @Id";

                SqlParameter[] param = {
            new SqlParameter("@Id", id)
        };

                DataTable dtRecord = sqlHelper.GetDataTable(query, CommandType.Text, param);

                if (dtRecord.Rows.Count > 0)
                {
                    DataRow row = dtRecord.Rows[0];

                    txtRegistrationNumber.Text = row["regNumber"].ToString();
                    txtBikeName.Text = row["bikeName"].ToString();

                    // If horsePower stores HID (int), set SelectedValue
                    if (row["horsePower"] != DBNull.Value)
                        cmbHorsePower.SelectedValue = Convert.ToInt32(row["horsePower"]);

                    txtEngineNumber.Text = row["engineNumber"].ToString();
                    txtChassesNumber.Text = row["chassisNumer"].ToString();
                    txtCustomerName.Text = row["customerName"].ToString();

                    if (row["showroomName"] != DBNull.Value)
                        cmbShowroom.SelectedValue = Convert.ToInt32(row["showroomName"]);

                    txtContactNumber.Text = row["contactNumber"].ToString();
                    txtTotalPayment.Text = row["totalPayment"] == DBNull.Value ? "" : Convert.ToDecimal(row["totalPayment"]).ToString("0");
                    txtAdvancePayment.Text = row["advance"] == DBNull.Value ? "" : Convert.ToDecimal(row["advance"]).ToString("0");
                    lblBalancePayable.Text = row["balance"] == DBNull.Value ? "" : Convert.ToDecimal(row["balance"]).ToString("0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmShowLetters showLetter = new frmShowLetters();
            showLetter.ShowDialog();

        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowRoom showRoom = new frmShowRoom();
            showRoom.ShowDialog();
            Form1_Load(null, null);
        }

        private bool IsValidate()
        {

            if (string.IsNullOrEmpty(txtRegistrationNumber.Text))
            {
                MessageBox.Show("Please enter registration number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegistrationNumber.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cmbHorsePower.Text))
            {
                MessageBox.Show("Please enter Hourse Power", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHorsePower.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEngineNumber.Text))
            {
                MessageBox.Show("Please enter engine number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEngineNumber.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtChassesNumber.Text))
            {
                MessageBox.Show("Please enter chases number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChassesNumber.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter customer name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtContactNumber.Text))
            {
                MessageBox.Show("Please enter contact number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactNumber.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTotalPayment.Text))
            {
                MessageBox.Show("Please enter total payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalPayment.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAdvancePayment.Text))
            {
                MessageBox.Show("Please enter advance payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdvancePayment.Focus();
                return false;
            }
            return true;
        }

        private void txtTotalPayment_TextChanged(object sender, EventArgs e)
        {
            CalculateBalance();
        }

        private void txtAdvancePayment_TextChanged(object sender, EventArgs e)
        {
            CalculateBalance();
        }

        private void CalculateBalance()
        {
            decimal total = 0, advance = 0;

            // TryParse ensures no crash if text is empty or invalid
            decimal.TryParse(txtTotalPayment.Text, out total);
            decimal.TryParse(txtAdvancePayment.Text, out advance);

            decimal balance = total - advance;

            // Show balance in label
            lblBalancePayable.Text = balance.ToString();
        }

        private void txtRegistrationNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

        }

        private void txtChassesNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtCustomerName.Focus();
            }
        }

        private void txtAdvancePayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAddUpdate.Focus();
            }
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHorsePower hp = new frmHorsePower();
            hp.ShowDialog();

            DataTable dtHorsePower = sqlHelper.GetDataTable("SELECT HID, HorsePower FROM tbl_HorsePower", CommandType.Text);

            DataRow drHorse = dtHorsePower.NewRow();
            drHorse["HID"] = 0;
            drHorse["HorsePower"] = "-- Select Horse Power --";
            dtHorsePower.Rows.InsertAt(drHorse, 0);

            cmbHorsePower.DataSource = dtHorsePower;
            cmbHorsePower.DisplayMember = "HorsePower";
            cmbHorsePower.ValueMember = "HID";
            cmbHorsePower.SelectedIndex = 0;
        }
    }
}
