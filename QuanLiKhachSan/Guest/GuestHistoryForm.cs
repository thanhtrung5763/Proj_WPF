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
    public partial class GuestHistoryForm : Form
    {
        public GuestHistoryForm()
        {
            InitializeComponent();
        }
        Reservation res = new Reservation();
        private void GuestHistoryForm_Load(object sender, EventArgs e)
        {
            history_DGV.DataSource = res.getAllRes(Globals.GlobalUserId);
            history_DGV.ReadOnly = true;
            history_DGV.AllowUserToAddRows = false;


            history_DGV.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            history_DGV.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            history_DGV.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            history_DGV.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            history_DGV.Columns[0].HeaderText = "Reservation ID";
            history_DGV.Columns[1].HeaderText = "Room ID";
            history_DGV.Columns[2].HeaderText = "Date In Book";
            history_DGV.Columns[3].HeaderText = "Date Out Book";
            history_DGV.Columns[4].HeaderText = "Check In";
            history_DGV.Columns[5].HeaderText = "Check Out";
            history_DGV.Columns[6].HeaderText = "Payment";
        }
    }
}
