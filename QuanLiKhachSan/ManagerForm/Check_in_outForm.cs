using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class Check_in_outForm : Form
    {
        public Check_in_outForm()
        {
            InitializeComponent();
        }
        MY_DB myDB = new MY_DB();
        Check_in_out ck = new Check_in_out();
        Shift sh = new Shift();
        Schedule sch = new Schedule();
        private void Check_in_outForm_Load_1(object sender, EventArgs e)
        {
            this.ParentForm.Width = 1050;
            this.ParentForm.Height = 560;
            DateTime tmp = dateTimePicker1.Value;
     
            shifts_DGV.DataSource = ck.getScheduleByUserId(tmp, Globals.GlobalUserId);
            shifts_DGV.RowTemplate.Height = 50;
            shifts_DGV.ReadOnly = true;
            shifts_DGV.AllowUserToAddRows = false;


            DataTable tableSh = sch.getDateStartEnd(tmp);
            label1.Text = "Your Shift From " + Convert.ToDateTime(tableSh.Rows[0]["date_start"].ToString()).ToString("MM/dd/yyyy") + " To " + Convert.ToDateTime(tableSh.Rows[0]["date_end"].ToString()).ToString("MM/dd/yyyy");

            setting_DGV.DataSource = ck.getShiftTimeByUserId(DateTime.Now, Globals.GlobalUserId);
            setting_DGV.ReadOnly = true;
            setting_DGV.AllowUserToAddRows = false;
            setting_DGV.Columns[0].HeaderText = "Shift Name";
            setting_DGV.Columns[1].HeaderText = "Time Start";
            setting_DGV.Columns[2].HeaderText = "Time End";
            setting_DGV.Columns[1].DefaultCellStyle.Format = "hh\\:mm";
            setting_DGV.Columns[2].DefaultCellStyle.Format = "hh\\:mm";
            setting_DGV.Columns[3].HeaderText = "No.Manager";
            setting_DGV.Columns[4].HeaderText = "No.Receptionist";
            setting_DGV.Columns[5].HeaderText = "No.Janitor";

            checkInOut_DGV.RowTemplate.Height = 50;
            checkInOut_DGV.ReadOnly = true;
            checkInOut_DGV.AllowUserToAddRows = false;

            checkInOut_DGV.DataSource = ck.getDataCheckInCheckOut(Globals.GlobalUserId);
            checkInOut_DGV.Columns[0].HeaderText = "Date";
            checkInOut_DGV.Columns[1].HeaderText = "Shift";
            checkInOut_DGV.Columns[2].HeaderText = "Time Start";
            checkInOut_DGV.Columns[2].DefaultCellStyle.Format = "hh\\:mm";
            checkInOut_DGV.Columns[3].DefaultCellStyle.Format = "hh\\:mm";
            checkInOut_DGV.Columns[3].HeaderText = "Time End";
            checkInOut_DGV.Columns[4].HeaderText = "Time In";
            checkInOut_DGV.Columns[5].HeaderText = "Time Out";

        }
        public Tuple<int, TimeSpan> getShiftName(TimeSpan time_late, TimeSpan time)
        {
            int idx = -1;
            TimeSpan minus = new TimeSpan();
            foreach(DataGridViewRow row in setting_DGV.Rows)
            {
                TimeSpan time_start = (TimeSpan)(row.Cells["time_start"].Value);
                TimeSpan time_end = (TimeSpan)(row.Cells["time_end"].Value);
                if(time <= time_start || TimeSpan.Compare(time.Subtract(time_start), time_late) == - 1)
                {
                    idx = row.Index;
                    minus = time_start.Subtract(time);
                    return Tuple.Create(idx, minus);
                }
            }
            return Tuple.Create(idx, minus);
        }
        private void checkIn_BT_Click(object sender, EventArgs e)
        {
            var time_late_max = new TimeSpan(1, 0, 0);
            var dateAndTime = DateTime.Now;
            var date_name = dateAndTime.ToString("dddd");
            var time_now = TimeSpan.Parse((dateAndTime.ToString("HH:mm:ss")));
            var shiftNameIdx = getShiftName(time_late_max, time_now);
            if(shiftNameIdx.Item1 != -1)
            {
                int temp = TimeSpan.Compare(shiftNameIdx.Item2, new TimeSpan(0, 0, 0));
                var shiftName = setting_DGV.Rows[shiftNameIdx.Item1].Cells["shift_name"].Value.ToString();
                TimeSpan time_start = TimeSpan.Parse(setting_DGV.Rows[shiftNameIdx.Item1].Cells["time_start"].Value.ToString()); 
                TimeSpan time_end = TimeSpan.Parse(setting_DGV.Rows[shiftNameIdx.Item1].Cells["time_end"].Value.ToString());
                if(ck.isExist(Globals.GlobalUserId, dateAndTime.Date, shiftName))
                {
                    MessageBox.Show("You Checked In Already", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ck.insertCheckInData(Globals.GlobalUserId, dateAndTime.Date, shiftName, time_start, time_end, time_now);
                    if (temp == -1)
                    {
                        MessageBox.Show("You're late. -100.000 Salary", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    MessageBox.Show("Check In Successful.", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkInOut_DGV.DataSource = ck.getDataCheckInCheckOut(Globals.GlobalUserId);
                }

            }
            else
            {
                MessageBox.Show("You don't have shift today. Please comback later", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkOut_BT_Click(object sender, EventArgs e)
        {
            var dateAndTime = DateTime.Now;
            var time_now = TimeSpan.Parse((dateAndTime.ToString("HH:mm:ss")));
            DataTable dt = ck.getDataCheckInCheckOutWith(Globals.GlobalUserId, dateAndTime.Date);
            if(dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["time_out"] == DBNull.Value)
                    {
                        if(TimeSpan.Compare(time_now, TimeSpan.Parse(row["time_start"].ToString())) <= 0) {
                            MessageBox.Show("You cannot check out before the time your shift start.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            checkInOut_DGV.DataSource = ck.getDataCheckInCheckOut(Globals.GlobalUserId);
                            return;
                        }
                        if (TimeSpan.Compare(time_now, TimeSpan.Parse(row["time_end"].ToString())) < 0)
                        {
                            if (MessageBox.Show("Too Soon To Check Out. Are You Still Want To Check Out?.", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                TimeSpan twork = new TimeSpan(time_now.Hours - TimeSpan.Parse(row["time_start"].ToString()).Hours, 0, 0);
                                ck.insertCheckOutData(Globals.GlobalUserId, dateAndTime.Date, row["shift_name"].ToString(), time_now, twork);
                                checkInOut_DGV.DataSource = ck.getDataCheckInCheckOut(Globals.GlobalUserId);
                                return;
                            }
                        }
                        else
                        {
                            TimeSpan twork = TimeSpan.Parse(row["time_end"].ToString()).Subtract(TimeSpan.Parse(row["time_start"].ToString()));
                            ck.insertCheckOutData(Globals.GlobalUserId, dateAndTime.Date, row["shift_name"].ToString(), time_now, twork);
                            checkInOut_DGV.DataSource = ck.getDataCheckInCheckOut(Globals.GlobalUserId);
                            MessageBox.Show("Check Out Successful.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if(dt.Rows.IndexOf(row) == dt.Rows.Count - 1)
                            MessageBox.Show("You Were Checked Out Before.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                checkInOut_DGV.DataSource = ck.getDataCheckInCheckOut(Globals.GlobalUserId);
            }
            else
            {
                TimeSpan t = new TimeSpan(12, 0, 0);
                dateAndTime = dateAndTime.AddDays(-1);

                dt = ck.getDataCheckInCheckOutWith(Globals.GlobalUserId, dateAndTime.Date);
                if(dt.Rows.Count >= 1)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (TimeSpan.Parse(row["time_start"].ToString()) >= t && TimeSpan.Parse(row["time_end"].ToString()) <= t)
                        {
                            if (row["time_out"] == DBNull.Value)
                            {
                                if (TimeSpan.Compare(time_now, TimeSpan.Parse(row["time_end"].ToString())) < 0)
                                {
                                    if (MessageBox.Show("Too Soon To Check Out. Are You Still Want To Check Out?.", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        TimeSpan twork = new TimeSpan(time_now.Hours + (24 - TimeSpan.Parse(row["time_start"].ToString()).Hours), 0, 0);
                                        ck.insertCheckOutData(Globals.GlobalUserId, dateAndTime.Date, row["shift_name"].ToString(), time_now, twork);
                                        checkInOut_DGV.DataSource = ck.getDataCheckInCheckOut(Globals.GlobalUserId);
                                        return;
                                    }
                                }
                                else
                                {
                                    TimeSpan twork = new TimeSpan(TimeSpan.Parse(row["time_end"].ToString()).Hours + (24 - TimeSpan.Parse(row["time_start"].ToString()).Hours), 0, 0);
                                    ck.insertCheckOutData(Globals.GlobalUserId, dateAndTime.Date, row["shift_name"].ToString(), time_now, twork);
                                    checkInOut_DGV.DataSource = ck.getDataCheckInCheckOut(Globals.GlobalUserId);
                                    MessageBox.Show("Check Out Successful.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                if (dt.Rows.IndexOf(row) == dt.Rows.Count - 1)
                                    MessageBox.Show("You Were Checked Out Before.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        checkInOut_DGV.DataSource = ck.getDataCheckInCheckOut(Globals.GlobalUserId);
                    }
                }
                return;
            }
        }
    }
}
