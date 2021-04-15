using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class EditDeleteEmployeeForm : Form
    {
        public EditDeleteEmployeeForm()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }
        Employee emp = new Employee();
        private void uploadphoto_BT_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }
        private bool verif()
        {
            if ((fname_TB.Text.Trim() == "")
                || (lname_TB.Text.Trim() == "")
                || (email_TB.Text.Trim() == "")
                || (title_CBO.Text.Trim() == "")
                || (genderCBO.Text.Trim() == "")
                || (address_TB.Text.Trim() == "")
                || (phone_TB.Text.Trim() == "")
                || (pictureBox1.Image == null))
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
            string fname = fname_TB.Text;
            string lname = lname_TB.Text;
            string email = email_TB.Text;
            string title = title_CBO.Text;
            string gender = genderCBO.Text;
            DateTime bdate = dateTimePicker1.Value;
            DateTime hdate = dateTimePicker2.Value;
            string adrs = address_TB.Text;
            string phone = phone_TB.Text;

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if (this_year - born_year < 10 || this_year - born_year > 100)
            {
                MessageBox.Show("The Employee Age Must Be Between 10 and 100 year", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (emp.updateEmployee(id, fname, lname, email, title, gender, bdate, hdate, adrs, phone, pic))
                    {
                        MessageBox.Show("Employee Infomation Updated", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.DialogResult = DialogResult.OK;

                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void del_BT_Click(object sender, EventArgs e)
        {
            try
            {
                int empID = Convert.ToInt32(empID_TB.Text.Trim());
                if (MessageBox.Show("Are You Sure You Want To Delete This Employee", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (emp.delEmployee(empID))
                    {
                        MessageBox.Show("Employee Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        empID_TB.Text = "";
                        fname_TB.Text = "";
                        lname_TB.Text = "";
                        email_TB.Text = "";
                        title_CBO.SelectedItem = null;
                        genderCBO.SelectedItem = null;
                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker2.Value = DateTime.Now;
                        address_TB.Text = "";
                        phone_TB.Text = "";
                        pictureBox1.Image = null;
                        this.DialogResult = DialogResult.OK;
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
