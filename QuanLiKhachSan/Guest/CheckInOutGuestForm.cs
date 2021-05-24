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
    public partial class CheckInOutGuestForm : Form
    {
        public CheckInOutGuestForm()
        {
            InitializeComponent();
        }
        Reservation res = new Reservation();
        Room room = new Room();
        private void CheckInOutGuestForm_Load(object sender, EventArgs e)
        {
         
            checkInOut_DGV.DataSource = res.getRes(Globals.GlobalUserId);
            checkInOut_DGV.ReadOnly = true;
            checkInOut_DGV.AllowUserToAddRows = false;

            checkInOut_DGV.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            checkInOut_DGV.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            checkInOut_DGV.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            checkInOut_DGV.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            checkInOut_DGV.Columns[0].HeaderText = "Reservation ID";
            checkInOut_DGV.Columns[1].HeaderText = "Room ID";
            checkInOut_DGV.Columns[2].HeaderText = "Date In Book";
            checkInOut_DGV.Columns[3].HeaderText = "Date Out Book";
            checkInOut_DGV.Columns[4].HeaderText = "Check In";
            checkInOut_DGV.Columns[5].HeaderText = "Check Out";
        }

        private void checkIn_BT_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("MM/dd/yyyy");
            int res_id = int.Parse(checkInOut_DGV.Rows[0].Cells[0].Value.ToString());
            if (now == DateTime.Parse(checkInOut_DGV.Rows[0].Cells[2].Value.ToString()).ToString("MM/dd/yyyy"))
            {
                res.insertCheckInData(res_id, DateTime.Parse(now));
                MessageBox.Show("Checked In!", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkInOut_DGV.DataSource = res.getRes(Globals.GlobalUserId);

            }
            else
            {
                MessageBox.Show("Cannot Check In!", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkOut_BT_Click(object sender, EventArgs e)
        {
            if(checkInOut_DGV.Rows[0].Cells[4].Value.ToString() == "")
            {
                MessageBox.Show("You Need To Check In First!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                
                int res_id = int.Parse(checkInOut_DGV.Rows[0].Cells[0].Value.ToString());
                string now = DateTime.Now.ToString("MM/dd/yyyy");
                if (now.CompareTo(DateTime.Parse(checkInOut_DGV.Rows[0].Cells[3].Value.ToString()).ToString("MM/dd/yyyy")) <= 0)
                {
                    res.insertCheckOutData(res_id, DateTime.Parse(now));
                    room.updateStatus(Convert.ToInt32(checkInOut_DGV.CurrentRow.Cells[1].Value), false);
                    checkInOut_DGV.DataSource = res.getRes(Globals.GlobalUserId);
                    MessageBox.Show("Checked Out!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cannot Check Out!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
