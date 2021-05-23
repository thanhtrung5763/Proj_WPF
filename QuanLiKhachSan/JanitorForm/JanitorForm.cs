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
    public partial class JanitorForm : Form
    {
        public JanitorForm()
        {
            InitializeComponent();
        }
        Employee emp = new Employee();
        private void JanitorForm_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select firstname, photo From Employees Where emp_id=@id");
            com.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserId;
            DataTable dt = emp.getEmployees(com);
            welcome_LB.Text = "Welcome Back " + dt.Rows[0][0].ToString();
            byte[] pic;
            pic = (byte[])dt.Rows[0][1];
            MemoryStream picture = new MemoryStream(pic);
            avatar_PB.Image = Image.FromStream(picture);

            Check_in_outForm frm = new Check_in_outForm();

            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            this.Width = 830;
            this.Height = 560;
        }

        private void logOut_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

            Application.Restart();
        }

        private void edit_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editInfoForm frm = new editInfoForm();
            frm.Show();
        }
    }
}
