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
    public partial class ManagerForm : Form
    {
        Employee emp = new Employee();

        public ManagerForm()
        {
            InitializeComponent();
        }
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select firstname, photo From Employees Where emp_id=@id");
            com.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserId;
            DataTable dt = emp.getEmployees(com);
            welcome_LB.Text = "Welcome Back " + dt.Rows[0][0].ToString();
            byte[] pic;
            pic = (byte[])dt.Rows[0][1];
            MemoryStream picture = new MemoryStream(pic);
            avatar_PB.Image = Image.FromStream(picture);
            employ_BT_Click_1(null, null);
        }
        private void employ_BT_Click_1(object sender, EventArgs e)
        {
            this.Width = 780;
            this.Height = 520;
            ManageEmployeesForm frm = new ManageEmployeesForm();
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
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
                this.mngPayment2_BT.FillColor = Color.Transparent;
                this.mngPayment2_BT.FillColor2 = Color.Transparent;

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
            this.Height = 510;
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
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
                this.mngPayment2_BT.FillColor = Color.Transparent;
                this.mngPayment2_BT.FillColor2 = Color.Transparent;

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
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
                this.mngPayment2_BT.FillColor = Color.Transparent;
                this.mngPayment2_BT.FillColor2 = Color.Transparent;

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
                this.employ_BT.FillColor = Color.Transparent;
                this.employ_BT.FillColor2 = Color.Transparent;
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
                this.mngPayment2_BT.FillColor = Color.Transparent;
                this.mngPayment2_BT.FillColor2 = Color.Transparent;

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

        private void mngPayment_BT_Click(object sender, EventArgs e)
        {
            ManagerPaymentForm frm = new ManagerPaymentForm();
            this.Width = 1050;
            this.Height = 455;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.mngPayment_BT.FillColor == Color.Transparent && this.mngPayment_BT.FillColor2 == Color.Transparent)
            {
                this.employ_BT.FillColor = Color.Transparent;
                this.employ_BT.FillColor2 = Color.Transparent;
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.mngPayment2_BT.FillColor = Color.Transparent;
                this.mngPayment2_BT.FillColor2 = Color.Transparent;

                this.mngPayment_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngPayment_BT.FillColor2 = Color.Teal;
                frm.Show();

            }
            else
            {
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
            }
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

        private void mngPayment2_BT_Click(object sender, EventArgs e)
        {
            mngPaymentInFormForManager frm = new mngPaymentInFormForManager();
            this.Width = 1050;
            this.Height = 455;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.mngPayment2_BT.FillColor == Color.Transparent && this.mngPayment_BT.FillColor2 == Color.Transparent)
            {
                this.employ_BT.FillColor = Color.Transparent;
                this.employ_BT.FillColor2 = Color.Transparent;
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;

                this.mngPayment2_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngPayment2_BT.FillColor2 = Color.Teal;
                frm.Show();
                if(frm.payment_DGV.Rows.Count > 0)
                {
                    int sum_pay = 0;
                    for (int i = 0; i < frm.payment_DGV.Rows.Count - 1; i++)
                    {
                        sum_pay += int.Parse(frm.payment_DGV.Rows[i].Cells[6].Value.ToString());
                    }
                    frm.payment_DGV.Rows[frm.payment_DGV.Rows.Count - 1].Cells[6].Value = sum_pay;
                }
            }
            else
            {
                this.mngPayment2_BT.FillColor = Color.Transparent;
                this.mngPayment2_BT.FillColor2 = Color.Transparent;
            }
        }
    }
}
