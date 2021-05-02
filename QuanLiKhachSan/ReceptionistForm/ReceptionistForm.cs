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
    public partial class ReceptionistForm : Form
    {
        string username;
        public ReceptionistForm(string user)
        {
            username = user;
            InitializeComponent();
        }


        private void employ_BT_Click_1(object sender, EventArgs e)
        {
            ManageRoomsForm frm = new ManageRoomsForm();
            this.Width = 1080;
            this.Height = 585;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            if (this.mngRoom_BT.FillColor == Color.Transparent && this.mngRoom_BT.FillColor2 == Color.Transparent)
            {
                this.mngRoom_BT.FillColor = Color.Transparent;
                this.mngRoom_BT.FillColor2 = Color.Transparent;
                this.viewSchedules_BT.FillColor = Color.Transparent;
                this.viewSchedules_BT.FillColor2 = Color.Transparent;

                this.mngRoom_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngRoom_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.mngRoom_BT.FillColor = Color.Transparent;
                this.mngRoom_BT.FillColor2 = Color.Transparent;
            }
        }

        private void Check_in_out_BT_Click(object sender, EventArgs e)
        {
            Check_in_outForm frm = new Check_in_outForm(username);
            this.Width = 1340;
            this.Height = 500;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.Check_in_out_BT.FillColor == Color.Transparent && this.viewSchedules_BT.FillColor2 == Color.Transparent)
            {
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.mngRoom_BT.FillColor = Color.Transparent;
                this.mngRoom_BT.FillColor2 = Color.Transparent;

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
