using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        Room room = new Room();
        Employee emp = new Employee();
        Reservation res = new Reservation();
        PaymentGuest pguest = new PaymentGuest();
        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Globals.SetGlobalDataTableOver(res.getResOverDue(now.ToString("yyyy/MM/dd")));
            if(Globals.GlobalDataTableOver.Rows.Count > 0)
            {
                foreach(DataRow row in Globals.GlobalDataTableOver.Rows)
                {
                    if(!pguest.isExist(int.Parse(row[0].ToString()))) {
                        DateTime dt1 = DateTime.ParseExact(DateTime.Parse(row[3].ToString()).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        DateTime dt2 = DateTime.ParseExact(now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        TimeSpan t = dt2.Subtract(dt1);

                        int dif_day = t.Days;
                        pguest.insertOverdueData(int.Parse(row[0].ToString()), int.Parse(row[6].ToString()), dif_day);
                        res.insertCheckOutData(int.Parse(row[0].ToString()), now);
                        room.updateStatus(int.Parse(row[1].ToString()), false);
                    }
                }
            }
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
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
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
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
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
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
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
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;

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

        private void mngPayment_BT_Click(object sender, EventArgs e)
        {
            mngPaymentInForm frm = new mngPaymentInForm();
            this.Width = 850;
            this.Height = 370;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            if (this.mngPayment_BT.FillColor == Color.Transparent && this.mngRooms_BT.FillColor2 == Color.Transparent)
            {
                this.mngJani_BT.FillColor = Color.Transparent;
                this.mngJani_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;

                this.mngPayment_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngPayment_BT.FillColor2 = Color.Teal;
                
                frm.Show();
                int sum_pay = 0;
                for (int i = 0; i < frm.history_DGV.Rows.Count - 1; i++)
                {
                    sum_pay += int.Parse(frm.history_DGV.Rows[i].Cells[6].Value.ToString());
                }
                frm.history_DGV.Rows[frm.history_DGV.Rows.Count - 1].Cells[6].Value = sum_pay;
            }
            else
            {
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
            }
        }
    }
}
