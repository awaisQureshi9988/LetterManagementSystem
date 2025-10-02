namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoursePower = new System.Windows.Forms.TextBox();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChassesNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEngineNumber = new System.Windows.Forms.TextBox();
            this.txtBikeName = new System.Windows.Forms.TextBox();
            this.lblBalancePayable = new System.Windows.Forms.Label();
            this.cmbShowroom = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdvancePayment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Chassis Number ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Hourse Power";
            // 
            // txtHoursePower
            // 
            this.txtHoursePower.Location = new System.Drawing.Point(192, 130);
            this.txtHoursePower.Name = "txtHoursePower";
            this.txtHoursePower.Size = new System.Drawing.Size(405, 20);
            this.txtHoursePower.TabIndex = 4;
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.Location = new System.Drawing.Point(192, 38);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(405, 20);
            this.txtRegistrationNumber.TabIndex = 2;
            this.txtRegistrationNumber.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Engine Number";
            // 
            // txtChassesNumber
            // 
            this.txtChassesNumber.Location = new System.Drawing.Point(192, 222);
            this.txtChassesNumber.Name = "txtChassesNumber";
            this.txtChassesNumber.Size = new System.Drawing.Size(405, 20);
            this.txtChassesNumber.TabIndex = 6;
            this.txtChassesNumber.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Registration Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Bike Name";
            // 
            // txtEngineNumber
            // 
            this.txtEngineNumber.Location = new System.Drawing.Point(192, 176);
            this.txtEngineNumber.Name = "txtEngineNumber";
            this.txtEngineNumber.Size = new System.Drawing.Size(405, 20);
            this.txtEngineNumber.TabIndex = 5;
            this.txtEngineNumber.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtBikeName
            // 
            this.txtBikeName.Location = new System.Drawing.Point(192, 84);
            this.txtBikeName.Name = "txtBikeName";
            this.txtBikeName.Size = new System.Drawing.Size(405, 20);
            this.txtBikeName.TabIndex = 3;
            // 
            // lblBalancePayable
            // 
            this.lblBalancePayable.AutoSize = true;
            this.lblBalancePayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalancePayable.Location = new System.Drawing.Point(189, 287);
            this.lblBalancePayable.Name = "lblBalancePayable";
            this.lblBalancePayable.Size = new System.Drawing.Size(35, 16);
            this.lblBalancePayable.TabIndex = 57;
            this.lblBalancePayable.Text = "0.00";
            // 
            // cmbShowroom
            // 
            this.cmbShowroom.FormattingEnabled = true;
            this.cmbShowroom.Location = new System.Drawing.Point(192, 86);
            this.cmbShowroom.Name = "cmbShowroom";
            this.cmbShowroom.Size = new System.Drawing.Size(405, 21);
            this.cmbShowroom.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 18);
            this.label10.TabIndex = 55;
            this.label10.Text = "Balance Payable";
            // 
            // txtAdvancePayment
            // 
            this.txtAdvancePayment.Location = new System.Drawing.Point(192, 237);
            this.txtAdvancePayment.Name = "txtAdvancePayment";
            this.txtAdvancePayment.Size = new System.Drawing.Size(405, 20);
            this.txtAdvancePayment.TabIndex = 54;
            this.txtAdvancePayment.TextChanged += new System.EventHandler(this.txtAdvancePayment_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 18);
            this.label11.TabIndex = 53;
            this.label11.Text = "Advance Payment";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(192, 187);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(405, 20);
            this.txtTotalPayment.TabIndex = 50;
            this.txtTotalPayment.TextChanged += new System.EventHandler(this.txtTotalPayment_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 18);
            this.label13.TabIndex = 49;
            this.label13.Text = "Total Payment";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(192, 137);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(405, 20);
            this.txtContactNumber.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 18);
            this.label14.TabIndex = 47;
            this.label14.Text = "Contact Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 18);
            this.label15.TabIndex = 46;
            this.label15.Text = "Showroom";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(192, 36);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(405, 20);
            this.txtCustomerName.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 18);
            this.label16.TabIndex = 44;
            this.label16.Text = "Customer Name";
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUpdate.Location = new System.Drawing.Point(590, 650);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(97, 33);
            this.btnAddUpdate.TabIndex = 35;
            this.btnAddUpdate.Text = "Save";
            this.btnAddUpdate.UseVisualStyleBackColor = false;
            this.btnAddUpdate.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.lblBalancePayable);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmbShowroom);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtAdvancePayment);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtContactNumber);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTotalPayment);
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 333);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Details";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(604, 91);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(26, 13);
            this.linkLabel1.TabIndex = 58;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.txtChassesNumber);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtHoursePower);
            this.groupBox2.Controls.Add(this.txtBikeName);
            this.groupBox2.Controls.Add(this.txtRegistrationNumber);
            this.groupBox2.Controls.Add(this.txtEngineNumber);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 264);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Letter Detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 40);
            this.label1.TabIndex = 61;
            this.label1.Text = "Letter Entery";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Letter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoursePower;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChassesNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEngineNumber;
        private System.Windows.Forms.TextBox txtBikeName;
        private System.Windows.Forms.Label lblBalancePayable;
        private System.Windows.Forms.ComboBox cmbShowroom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdvancePayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

