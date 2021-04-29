using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../icon/icons8-business_building.png");
            pictureBox1.BackColor = Color.Transparent;

        }

        public void menu_role()
        {
            if(radioManager.Checked)
            {
                Application.Run(new ManagerForm(username_TB.Text.ToString()));
            }
            else if(radioEmp.Checked)
            {
                Application.Run(new ReceptionistForm());
            }
        }
    

        private void login_BT_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            Check_in_out ck = new Check_in_out();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("SELECT * FROM Accounts, Employees, EmployeeAccounts WHERE username=@user AND password=@pass AND Accounts.acc_id = EmployeeAccounts.acc_id AND Employees.emp_id = EmployeeAccounts.emp_id", db.getConnection);
            if (radioManager.Checked)
            {
                com.CommandText += " AND (title='Manager' OR title = 'Admin')";
            }
            else if (radioEmp.Checked)
            {
                com.CommandText += " AND (title='Receptionist' OR title='Janitor')";
            }
            com.Parameters.Add("@user", SqlDbType.VarChar).Value = username_TB.Text;
            com.Parameters.Add("@pass", SqlDbType.VarChar).Value = password_TB.Text;

            da.SelectCommand = com;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                this.DialogResult = DialogResult.OK; 
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }
    }
}
