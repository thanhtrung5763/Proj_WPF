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
    public partial class ReceptionistForm : Form
    {
        public ReceptionistForm()
        {
            InitializeComponent();
        }
        Employee emp = new Employee();
        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select firstname, photo From Employees Where emp_id=@id");
            com.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserId;
            DataTable dt = emp.getEmployees(com);
            welcome_LB.Text = "Welcome Back " + dt.Rows[0][0].ToString();
            byte[] pic;
            pic = (byte[])dt.Rows[0][1];
            MemoryStream picture = new MemoryStream(pic);
            avatar_PB.Image = Image.FromStream(picture);
        }

        private void Check_in_out_BT_Click(object sender, EventArgs e)
        {
            Check_in_outForm frm = new Check_in_outForm();
            this.Width = 1340;
            this.Height = 700;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.Check_in_out_BT.FillColor == Color.Transparent && this.Check_in_out_BT.FillColor2 == Color.Transparent)
            {
                this.mngJani_BT.FillColor = Color.Transparent;
                this.mngJani_BT.FillColor2 = Color.Transparent;
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;

                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;

                this.Check_in_out_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.Check_in_out_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
            }
        }

        private void edit_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editInfoForm frm = new editInfoForm();
            frm.Show();
        }

        private void logOut_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

            Application.Restart();
        }

        private void mngJani_BT_Click(object sender, EventArgs e)
        {
            this.Width = 780;
            this.Height = 520;
            ManagerJanitorForm frm = new ManagerJanitorForm();
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            if (this.mngJani_BT.FillColor == Color.Transparent && this.mngJani_BT.FillColor2 == Color.Transparent)
            {
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;

                this.mngJani_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngJani_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.mngJani_BT.FillColor = Color.Transparent;
                this.mngJani_BT.FillColor2 = Color.Transparent;
            }
        }

        private void mngSchedules_BT_Click(object sender, EventArgs e)
        {
            ManagerScheduleJanitorForm frm = new ManagerScheduleJanitorForm();
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.mngSchedules_BT.FillColor == Color.Transparent && this.mngSchedules_BT.FillColor2 == Color.Transparent)
            {
                this.mngJani_BT.FillColor = Color.Transparent;
                this.mngJani_BT.FillColor2 = Color.Transparent;
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;

                this.mngSchedules_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngSchedules_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;
            }
        }

        private void mngRooms_BT_Click(object sender, EventArgs e)
        {
            ManageRoomByReceptForm frm = new ManageRoomByReceptForm();
            this.Width = 1080;
            this.Height = 470;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            if (this.mngRooms_BT.FillColor == Color.Transparent && this.mngRooms_BT.FillColor2 == Color.Transparent)
            {
                this.mngJani_BT.FillColor = Color.Transparent;
                this.mngJani_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;

                this.mngRooms_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngRooms_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;
            }
        }
    }
}
