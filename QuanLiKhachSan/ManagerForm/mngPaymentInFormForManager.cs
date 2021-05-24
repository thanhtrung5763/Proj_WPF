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
    public partial class mngPaymentInFormForManager : Form
    {
        public mngPaymentInFormForManager()
        {
            InitializeComponent();
        }
        PaymentGuest pguest = new PaymentGuest();
        private void mngPaymentInFormForManager_Load(object sender, EventArgs e)
        {
            dateSelected_DTP.Format = DateTimePickerFormat.Custom;
            dateSelected_DTP.CustomFormat = "dd/MM/yyyy";
        }
        Reservation res = new Reservation();
        private void showPay_BT_Click(object sender, EventArgs e)
        {

            DataTable dt = res.getAllRes(DateTime.Parse(dateSelected_DTP.Value.ToString()).ToString("yyyy/MM/dd"));
            payment_DGV.DataSource = dt;
            payment_DGV.ReadOnly = true;

            this.payment_DGV.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.payment_DGV.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.payment_DGV.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.payment_DGV.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.payment_DGV.Columns[0].HeaderText = "Reservation ID";
            this.payment_DGV.Columns[1].HeaderText = "Room ID";
            this.payment_DGV.Columns[2].HeaderText = "Date In Book";
            this.payment_DGV.Columns[3].HeaderText = "Date Out Book";
            this.payment_DGV.Columns[4].HeaderText = "Check In";
            this.payment_DGV.Columns[5].HeaderText = "Check Out";
            this.payment_DGV.Columns[6].HeaderText = "Payment";
            int sum_pay = 0;
            for (int i = 0; i < this.payment_DGV.Rows.Count - 1; i++)
            {
                sum_pay += int.Parse(this.payment_DGV.Rows[i].Cells[6].Value.ToString());
            }
            this.payment_DGV.Rows[this.payment_DGV.Rows.Count - 1].Cells[6].Value = sum_pay;
        }

        private void overdue_BT_Click(object sender, EventArgs e)
        {
            payment_DGV.DataSource = pguest.getResOverDueInfo(DateTime.Parse(dateSelected_DTP.Value.ToString()).ToString("yyyy/MM/dd"));
            this.payment_DGV.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.payment_DGV.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.payment_DGV.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.payment_DGV.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.payment_DGV.Columns[0].HeaderText = "Reservation ID";
            this.payment_DGV.Columns[1].HeaderText = "Room ID";
            this.payment_DGV.Columns[2].HeaderText = "Date In Book";
            this.payment_DGV.Columns[3].HeaderText = "Date Out Book";
            this.payment_DGV.Columns[4].HeaderText = "Check In";
            this.payment_DGV.Columns[5].HeaderText = "Check Out";
            this.payment_DGV.Columns[6].HeaderText = "Overdue Money";
            int sum_pay = 0;
            for (int i = 0; i < this.payment_DGV.Rows.Count - 1; i++)
            {
                sum_pay += int.Parse(this.payment_DGV.Rows[i].Cells[6].Value.ToString());
            }
            this.payment_DGV.Rows[this.payment_DGV.Rows.Count - 1].Cells[6].Value = sum_pay;
        }
    }
}
