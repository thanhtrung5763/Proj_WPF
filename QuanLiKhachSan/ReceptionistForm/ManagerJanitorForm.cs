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
    public partial class ManagerJanitorForm : Form
    {
        Employee emp = new Employee();
        Account acc = new Account();
        SqlCommand com;
        SqlConnection con;
        public ManagerJanitorForm()
        {
            InitializeComponent();
            com = new SqlCommand();
            con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=projectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        
        private void ManagerJanitorForm_Load(object sender, EventArgs e)
        {
            this.ParentForm.Width = 1080;
            this.ParentForm.Height = 560;
            bdateT2_DTP.Format = DateTimePickerFormat.Custom;
            bdateT2_DTP.CustomFormat = "dd/MM/yyyy";
            hdateT2_DTP.Format = DateTimePickerFormat.Custom;
            hdateT2_DTP.CustomFormat = "dd/MM/yyyy";
            com.CommandText = "SELECT * FROM Employees Where title='Janitor'";
            employee_DGV.ReadOnly = true;
            employee_DGV.DataSource = emp.getEmployees(com);
            employee_DGV.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            employee_DGV.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            employee_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            employee_DGV.Columns[0].HeaderText = "Employee ID";
            employee_DGV.Columns[1].HeaderText = "First Name";
            employee_DGV.Columns[2].HeaderText = "Last Name";

            employee_DGV.Columns[3].HeaderText = "Email";
            employee_DGV.Columns[4].HeaderText = "Gender";
            employee_DGV.Columns[5].HeaderText = "Birth Date";
            employee_DGV.Columns[6].HeaderText = "Hire Date";
            employee_DGV.Columns[7].HeaderText = "Title";
            employee_DGV.Columns[8].HeaderText = "Reports To";
            employee_DGV.Columns[9].HeaderText = "Address";
            employee_DGV.Columns[10].HeaderText = "Photo";
            employee_DGV.Columns[11].HeaderText = "Phone";
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)employee_DGV.Columns[10];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            employee_DGV.AllowUserToAddRows = false;
        }

        private void filter_CBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_TB_TextChanged(null, null);
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
        public void searchData(string colName, string valueToFind)
        {
            com.CommandText = $"SELECT * FROM Employees WHERE  title = 'Janitor' And {colName} LIKE '%" + valueToFind + "%'";
            employee_DGV.DataSource = emp.getEmployees(com);
        }

        private void employee_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int empID = int.Parse(employee_DGV.CurrentRow.Cells[0].Value.ToString());
            com.CommandText = $"SELECT * FROM Employees WHERE emp_id = {empID}";
            DataTable dt2 = emp.getEmployees(com);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt2);

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
    }
}
