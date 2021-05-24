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
    public partial class mngPaymentInForm : Form
    {
        public mngPaymentInForm()
        {
            InitializeComponent();
        }
        Reservation res = new Reservation();
        PaymentGuest pguest = new PaymentGuest();
        private void mngPaymentInForm_Load(object sender, EventArgs e)
        {
            history_DGV.DataSource = res.getAllRes();
            history_DGV.ReadOnly = true;


            this.history_DGV.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[0].HeaderText = "Reservation ID";
            this.history_DGV.Columns[1].HeaderText = "Room ID";
            this.history_DGV.Columns[2].HeaderText = "Date In Book";
            this.history_DGV.Columns[3].HeaderText = "Date Out Book";
            this.history_DGV.Columns[4].HeaderText = "Check In";
            this.history_DGV.Columns[5].HeaderText = "Check Out";
            this.history_DGV.Columns[6].HeaderText = "Payment";
            int sum_pay = 0;
            for(int i = 0; i < this.history_DGV.Rows.Count - 1; i++)
            {
                sum_pay += int.Parse(this.history_DGV.Rows[i].Cells[6].Value.ToString());
            }
            this.history_DGV.Rows[this.history_DGV.Rows.Count - 1].Cells[6].Value = sum_pay;
        }

        private void tday_BT_Click(object sender, EventArgs e)
        {
            mngPaymentInForm_Load(null, null);
        }

        private void overdue_BT_Click(object sender, EventArgs e)
        {
            history_DGV.DataSource = pguest.getResOverDueInfo(DateTime.Parse(DateTime.Now.ToString()).ToString("yyyy/MM/dd"));
            this.history_DGV.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.history_DGV.Columns[0].HeaderText = "Reservation ID";
            this.history_DGV.Columns[1].HeaderText = "Room ID";
            this.history_DGV.Columns[2].HeaderText = "Date In Book";
            this.history_DGV.Columns[3].HeaderText = "Date Out Book";
            this.history_DGV.Columns[4].HeaderText = "Check In";
            this.history_DGV.Columns[5].HeaderText = "Check Out";
            this.history_DGV.Columns[6].HeaderText = "Overdue Money";

        }
    }
}
