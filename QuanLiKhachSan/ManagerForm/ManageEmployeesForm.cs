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
    
    public partial class ManageEmployeesForm : Form
    {
        Employee emp = new Employee();
        Account acc = new Account();
        SqlCommand com;
        SqlConnection con;
        public ManageEmployeesForm()
        {
            InitializeComponent();
            com = new SqlCommand();
            con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=projectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            bdate_DTP.Format = DateTimePickerFormat.Custom;
            bdate_DTP.CustomFormat = "dd/MM/yyyy";
            hdate_DTP.Format = DateTimePickerFormat.Custom;
            hdate_DTP.CustomFormat = "dd/MM/yyyy";
            employee_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
        }

        private void chophoto_BT_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                photo_PB.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void add_BT_Click(object sender, EventArgs e)
        {
            string fname = fname_TB.Text;
            string lname = lname_TB.Text;
            string email = email_TB.Text;
            string title = title_CBO.SelectedItem.ToString();
            string gender = gender_CBO.SelectedItem.ToString();
            DateTime bdate = bdate_DTP.Value;
            DateTime hdate = hdate_DTP.Value;
            string address = address_TB.Text;
            string phone = phone_TB.Text;
            MemoryStream pic = new MemoryStream();
            photo_PB.Image.Save(pic, photo_PB.Image.RawFormat);
            string id = emp.insertEmployee(fname, lname, email, title, gender, bdate, hdate, address, phone, pic);

            string username = username_TB.Text;
            string password = password_TB.Text;
            string password2 = password2_TB.Text;

            acc.createAccount(id, username, password);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
                this.ParentForm.Width = 1080;
                this.ParentForm.Height = 585;
                com.CommandText = "SELECT * FROM Employees";
                employee_DGV.ReadOnly = true;
                employee_DGV.DataSource = emp.getEmployees(com);
                employee_DGV.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                employee_DGV.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)employee_DGV.Columns[10];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                employee_DGV.AllowUserToAddRows = false;
                employee_DGV_CellClick(null, null);
            }
            else
            {
                this.ParentForm.Width = 780;
                this.ParentForm.Height = 480;
            }
        }

        private void filter_CBO_TextChanged(object sender, EventArgs e)
        {

        }
        public void searchData(string colName, string valueToFind)
        {
            com.CommandText = $"SELECT * FROM Employees WHERE  {colName} LIKE '%" + valueToFind + "%'";
            employee_DGV.DataSource = emp.getEmployees(com);
        }

        private void clear_BT_Click(object sender, EventArgs e)
        {
            fname_TB.Text = "";
            lname_TB.Text = "";
            email_TB.Text = "";
            title_CBO.Text = "";
            gender_CBO.Text = "";
            bdate_DTP.Value = DateTime.Now;
            hdate_DTP.Value = DateTime.Now;
            address_TB.Text = "";
            phone_TB.Text = "";
            photo_PB.Image = null;
            username_TB.Text = "";
            password_TB.Text = "";
            password2_TB.Text = "";
        }

        private void filter_CBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_TB_TextChanged(null, null);
        }

        private void employee_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int empID = int.Parse(employee_DGV.CurrentRow.Cells[0].Value.ToString());
            com.CommandText = $"SELECT * FROM Accounts WHERE acc_id=(SELECT acc_id FROM EmployeeAccounts WHERE emp_id={empID})";
            DataTable dt = acc.getAccounts(com);
            com.CommandText = $"SELECT * FROM Employees WHERE emp_id = {empID}";
            DataTable dt2 = emp.getEmployees(com);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.Tables.Add(dt2);
            if (dt.Rows.Count > 0)
            {
                accID_TB.Text = ds.Tables[0].Rows[0]["acc_id"].ToString();
                usernameT2_TB.Text = ds.Tables[0].Rows[0]["username"].ToString();
                passwordT2_TB.Text = ds.Tables[0].Rows[0]["password"].ToString();
                empID_TB.Text = employee_DGV.CurrentRow.Cells[0].Value.ToString();
                fnameT2_TB.Text = employee_DGV.CurrentRow.Cells[1].Value.ToString();
                lnameT2_TB.Text = employee_DGV.CurrentRow.Cells[2].Value.ToString();
                emailT2_TB.Text = employee_DGV.CurrentRow.Cells[3].Value.ToString();
                genderT2_CBO.SelectedItem = employee_DGV.CurrentRow.Cells[4].Value;
                bdateT2_DTP.Value = (DateTime)employee_DGV.CurrentRow.Cells[5].Value;
                hdateT2_DTP.Value = (DateTime)employee_DGV.CurrentRow.Cells[6].Value;
                titleT2_CBO.SelectedItem = employee_DGV.CurrentRow.Cells[7].Value;
                addressT2_TB.Text = employee_DGV.CurrentRow.Cells[9].Value.ToString();
                phoneT2_TB.Text = employee_DGV.CurrentRow.Cells[11].Value.ToString();
                byte[] pic;
                pic = (byte[])employee_DGV.CurrentRow.Cells[10].Value;
                MemoryStream picture = new MemoryStream(pic);
                photoT2_PB.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("not found", "Find Infomation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void search_TB_TextChanged(object sender, EventArgs e)
        {
           string colName = filter_CBO.SelectedItem.ToString();
            if (colName == "EmployeeID")
                colName = "emp_id";
            else if (colName == "BirthDate")
                colName = "bdate";
            else if (colName == "HireDate")
                colName = "hdate";
            searchData(colName, search_TB.Text);
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
                    if (emp.updateEmployee(id, fname, lname, email, title, gender, bdate, hdate, adrs, phone, pic))
                    {
                        MessageBox.Show("Employee Infomation Updated", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabControl1_SelectedIndexChanged(null, null);
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

        private void delete_BT_Click(object sender, EventArgs e)
        {
            try
            {
                int empID = Convert.ToInt32(empID_TB.Text.Trim());
                int accID = Convert.ToInt32(accID_TB.Text.Trim());
                if (MessageBox.Show("Are You Sure You Want To Delete This Employee", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (emp.delEmployee(empID) && acc.delAccount(accID))
                    {
                        MessageBox.Show("Employee Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        empID_TB.Text = "";
                        fnameT2_TB.Text = "";
                        lnameT2_TB.Text = "";
                        emailT2_TB.Text = "";
                        titleT2_CBO.SelectedItem = null;
                        genderT2_CBO.SelectedItem = null;
                        bdateT2_DTP.Value = DateTime.Now;
                        hdateT2_DTP.Value = DateTime.Now;
                        addressT2_TB.Text = "";
                        phoneT2_TB.Text = "";
                        photoT2_PB.Image = null;
                        tabControl1_SelectedIndexChanged(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
