using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class ManagerForm : Form
    {

        string username;
        public ManagerForm(string user)
        {
            username = user;
            InitializeComponent();
            employ_BT_Click_1(null, null);
        }
        private void employ_BT_Click_1(object sender, EventArgs e)
        {
            this.Width = 780;
            this.Height = 500;
            ManageEmployeesForm frm = new ManageEmployeesForm();
           //ManageEmployeesFrom frm = new ManageEmployeesFrom();
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            
            if (this.employ_BT.FillColor == Color.Transparent && this.employ_BT.FillColor2 == Color.Transparent)
            {
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;

                this.employ_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.employ_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.employ_BT.FillColor = Color.Transparent;
                this.employ_BT.FillColor2 = Color.Transparent;
            }
        }

        private void mngRooms_BT_Click(object sender, EventArgs e)
        {
            ManageRoomsForm frm = new ManageRoomsForm();
            this.Width = 1080;
            this.Height = 585;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            if (this.mngRooms_BT.FillColor == Color.Transparent && this.mngRooms_BT.FillColor2 == Color.Transparent)
            {
                this.employ_BT.FillColor = Color.Transparent;
                this.employ_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;

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

        private void mngSchedules_BT_Click(object sender, EventArgs e)
        {
            ManageSchedulesForm frm = new ManageSchedulesForm();
            this.Width = 1080;
            this.Height = 420;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.mngSchedules_BT.FillColor == Color.Transparent && this.mngSchedules_BT.FillColor2 == Color.Transparent)
            {
                this.employ_BT.FillColor = Color.Transparent;
                this.employ_BT.FillColor2 = Color.Transparent;
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;

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

        private void Check_in_out_BT_Click(object sender, EventArgs e)
        {
            Check_in_outForm frm = new Check_in_outForm(username);
            this.Width = 1340;
            this.Height = 550;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.Check_in_out_BT.FillColor == Color.Transparent && this.mngSchedules_BT.FillColor2 == Color.Transparent)
            {
                this.employ_BT.FillColor = Color.Transparent;
                this.employ_BT.FillColor2 = Color.Transparent;
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;

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
    }
}
