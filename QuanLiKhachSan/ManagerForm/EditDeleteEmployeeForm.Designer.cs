﻿
namespace QuanLiKhachSan
{
    partial class EditDeleteEmployeeForm
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
            this.del_BT = new System.Windows.Forms.Button();
            this.edit_BT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accID_TB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.password_TB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.username_TB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.empID_TB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.uploadphoto_BT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phone_TB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.address_TB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.genderCBO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.title_CBO = new System.Windows.Forms.ComboBox();
            this.email_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lname_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fname_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // del_BT
            // 
            this.del_BT.Location = new System.Drawing.Point(373, 678);
            this.del_BT.Name = "del_BT";
            this.del_BT.Size = new System.Drawing.Size(166, 42);
            this.del_BT.TabIndex = 38;
            this.del_BT.Text = "Delete";
            this.del_BT.UseVisualStyleBackColor = true;
            this.del_BT.Click += new System.EventHandler(this.del_BT_Click);
            // 
            // edit_BT
            // 
            this.edit_BT.Location = new System.Drawing.Point(118, 678);
            this.edit_BT.Name = "edit_BT";
            this.edit_BT.Size = new System.Drawing.Size(166, 42);
            this.edit_BT.TabIndex = 36;
            this.edit_BT.Text = "Edit";
            this.edit_BT.UseVisualStyleBackColor = true;
            this.edit_BT.Click += new System.EventHandler(this.edit_BT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.accID_TB);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.password_TB);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.username_TB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(697, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 354);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Infomation";
            // 
            // accID_TB
            // 
            this.accID_TB.Location = new System.Drawing.Point(11, 67);
            this.accID_TB.Name = "accID_TB";
            this.accID_TB.ReadOnly = true;
            this.accID_TB.Size = new System.Drawing.Size(228, 31);
            this.accID_TB.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 25);
            this.label14.TabIndex = 27;
            this.label14.Text = "AccountID";
            // 
            // password_TB
            // 
            this.password_TB.Location = new System.Drawing.Point(11, 220);
            this.password_TB.Name = "password_TB";
            this.password_TB.Size = new System.Drawing.Size(228, 31);
            this.password_TB.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Password";
            // 
            // username_TB
            // 
            this.username_TB.Location = new System.Drawing.Point(11, 142);
            this.username_TB.Name = "username_TB";
            this.username_TB.Size = new System.Drawing.Size(228, 31);
            this.username_TB.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Username";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empID_TB);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.uploadphoto_BT);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.phone_TB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.address_TB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.genderCBO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.title_CBO);
            this.groupBox1.Controls.Add(this.email_TB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lname_TB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fname_TB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(61, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 588);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Infomation";
            // 
            // empID_TB
            // 
            this.empID_TB.Location = new System.Drawing.Point(57, 67);
            this.empID_TB.Name = "empID_TB";
            this.empID_TB.ReadOnly = true;
            this.empID_TB.Size = new System.Drawing.Size(228, 31);
            this.empID_TB.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "EmployeeID";
            // 
            // uploadphoto_BT
            // 
            this.uploadphoto_BT.Location = new System.Drawing.Point(312, 401);
            this.uploadphoto_BT.Name = "uploadphoto_BT";
            this.uploadphoto_BT.Size = new System.Drawing.Size(166, 42);
            this.uploadphoto_BT.TabIndex = 22;
            this.uploadphoto_BT.Text = "Upload Photo";
            this.uploadphoto_BT.UseVisualStyleBackColor = true;
            this.uploadphoto_BT.Click += new System.EventHandler(this.uploadphoto_BT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(312, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Photo";
            // 
            // phone_TB
            // 
            this.phone_TB.Location = new System.Drawing.Point(312, 204);
            this.phone_TB.Name = "phone_TB";
            this.phone_TB.Size = new System.Drawing.Size(228, 31);
            this.phone_TB.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Phone";
            // 
            // address_TB
            // 
            this.address_TB.Location = new System.Drawing.Point(312, 142);
            this.address_TB.Name = "address_TB";
            this.address_TB.Size = new System.Drawing.Size(228, 31);
            this.address_TB.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Address";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(57, 526);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 31);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 462);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 31);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "HireDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "BirthDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // genderCBO
            // 
            this.genderCBO.FormattingEnabled = true;
            this.genderCBO.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderCBO.Location = new System.Drawing.Point(57, 398);
            this.genderCBO.Name = "genderCBO";
            this.genderCBO.Size = new System.Drawing.Size(227, 33);
            this.genderCBO.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Title";
            // 
            // title_CBO
            // 
            this.title_CBO.FormattingEnabled = true;
            this.title_CBO.Items.AddRange(new object[] {
            "Manager",
            "Janitor",
            "Receptionist"});
            this.title_CBO.Location = new System.Drawing.Point(57, 334);
            this.title_CBO.Name = "title_CBO";
            this.title_CBO.Size = new System.Drawing.Size(227, 33);
            this.title_CBO.TabIndex = 6;
            // 
            // email_TB
            // 
            this.email_TB.Location = new System.Drawing.Point(57, 266);
            this.email_TB.Name = "email_TB";
            this.email_TB.Size = new System.Drawing.Size(228, 31);
            this.email_TB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // lname_TB
            // 
            this.lname_TB.Location = new System.Drawing.Point(57, 204);
            this.lname_TB.Name = "lname_TB";
            this.lname_TB.Size = new System.Drawing.Size(228, 31);
            this.lname_TB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastName";
            // 
            // fname_TB
            // 
            this.fname_TB.Location = new System.Drawing.Point(57, 142);
            this.fname_TB.Name = "fname_TB";
            this.fname_TB.Size = new System.Drawing.Size(228, 31);
            this.fname_TB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // EditDeleteEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 832);
            this.Controls.Add(this.del_BT);
            this.Controls.Add(this.edit_BT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditDeleteEmployeeForm";
            this.Text = "EditDeleteEmployeeForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button del_BT;
        public System.Windows.Forms.Button edit_BT;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox password_TB;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox username_TB;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button uploadphoto_BT;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox phone_TB;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox address_TB;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox genderCBO;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox title_CBO;
        public System.Windows.Forms.TextBox email_TB;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox lname_TB;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox fname_TB;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox accID_TB;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox empID_TB;
        public System.Windows.Forms.Label label13;
    }
}