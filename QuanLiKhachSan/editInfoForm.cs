using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class editInfoForm : Form
    {
        public editInfoForm()
        {
            InitializeComponent();
        }
        Employee emp = new Employee();
        Account acc = new Account();
        SqlCommand com = new SqlCommand();
        private void editInfoForm_Load(object sender, EventArgs e)
        {
            this.Width = 355;
            this.Height = 590;
            bdateT2_DTP.Format = DateTimePickerFormat.Custom;
            bdateT2_DTP.CustomFormat = "dd/MM/yyyy";
            hdateT2_DTP.Format = DateTimePickerFormat.Custom;
            hdateT2_DTP.CustomFormat = "dd/MM/yyyy";
            com.CommandText = $"SELECT * FROM Accounts WHERE acc_id=(SELECT acc_id FROM EmployeeAccounts WHERE emp_id={Globals.GlobalUserId})";
            DataTable dt = acc.getAccounts(com);
            com.CommandText = $"SELECT * FROM Employees WHERE emp_id = {Globals.GlobalUserId}";
            DataTable dt2 = emp.getEmployees(com);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.Tables.Add(dt2);

            accID_TB.Text = ds.Tables[0].Rows[0]["acc_id"].ToString();
            usernameT2_TB.Text = ds.Tables[0].Rows[0]["username"].ToString();
            passwordT2_TB.Text = ds.Tables[0].Rows[0]["password"].ToString();
            empID_TB.Text = ds.Tables[1].Rows[0]["emp_id"].ToString();
            fnameT2_TB.Text = ds.Tables[1].Rows[0]["firstname"].ToString();
            lnameT2_TB.Text = ds.Tables[1].Rows[0]["lastname"].ToString();
            emailT2_TB.Text = ds.Tables[1].Rows[0]["email"].ToString();
            genderT2_CBO.SelectedItem = ds.Tables[1].Rows[0]["gender"].ToString();
            bdateT2_DTP.Value = (DateTime)ds.Tables[1].Rows[0]["bdate"];
            hdateT2_DTP.Value = (DateTime)ds.Tables[1].Rows[0]["hdate"];
            titleT2_CBO.SelectedItem = ds.Tables[1].Rows[0]["title"].ToString();
            addressT2_TB.Text = ds.Tables[1].Rows[0]["address"].ToString();
            phoneT2_TB.Text = ds.Tables[1].Rows[0]["phone"].ToString();
            byte[] pic;
            pic = (byte[])ds.Tables[1].Rows[0]["photo"];
            MemoryStream picture = new MemoryStream(pic);
            photoT2_PB.Image = Image.FromStream(picture);
        }
        private bool verif()
        {
            if ((fnameT2_TB.Text.Trim() == "")
                || (lnameT2_TB.Text.Trim() == "")
                || (emailT2_TB.Text.Trim() == "")
                || (titleT2_CBO.Text.Trim() == "")
                || (genderT2_CBO.Text.Trim() == "")
                || (addressT2_TB.Text.Trim() == "")
                || (phoneT2_TB.Text.Trim() == "")
                || (photoT2_PB.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void edit_BT_Click(object sender, EventArgs e)
        {
            int acc_id = int.Parse(accID_TB.Text);
            string user = usernameT2_TB.Text;
            string pass = passwordT2_TB.Text;

            int id = int.Parse(empID_TB.Text);
            string fname = fnameT2_TB.Text;
            string lname = lnameT2_TB.Text;
            string email = emailT2_TB.Text;
            string title = titleT2_CBO.Text;
            string gender = genderT2_CBO.Text;
            DateTime bdate = bdateT2_DTP.Value;
            DateTime hdate = hdateT2_DTP.Value;
            string adrs = addressT2_TB.Text;
            string phone = phoneT2_TB.Text;

            MemoryStream pic = new MemoryStream();
            int born_year = bdateT2_DTP.Value.Year;
            int this_year = DateTime.Now.Year;
            if (this_year - born_year < 18 || this_year - born_year > 100)
            {
                MessageBox.Show("The Employee Age Must Be Between 10 and 100 year", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    photoT2_PB.Image.Save(pic, photoT2_PB.Image.RawFormat);
                    if (emp.updateEmployee(id, fname, lname, email, title, gender, bdate, hdate, adrs, phone, pic) && acc.updateAccount(id, user, pass))
                    {
                        MessageBox.Show("Employee Infomation Updated", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
