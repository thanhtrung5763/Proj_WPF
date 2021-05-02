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
        string username;
        public Check_in_outForm(string user)
        {
            username = user;
            InitializeComponent();
        }
        MY_DB myDB = new MY_DB();
        Check_in_out ck = new Check_in_out();
        Shift sh = new Shift();
        Schedule sch = new Schedule();
        private void Check_in_outForm_Load_1(object sender, EventArgs e)
        {
            DateTime tmp = dateTimePicker1.Value;
     
            dgv.DataSource = ck.schedule(username);
            dgv.RowTemplate.Height = 50;
            dgv.ReadOnly = true;

            DataTable tableSh = sch.getScheduleNow(tmp);
            label1.Text = "Your Shift From " + Convert.ToDateTime(tableSh.Rows[0]["date_start"].ToString()).ToString("MM/dd/yyyy") + " To " + Convert.ToDateTime(tableSh.Rows[0]["date_end"].ToString()).ToString("MM/dd/yyyy");

            int id = IdUser();
            dgv_check.RowTemplate.Height = 50;
            dgv_check.ReadOnly = true;
            dgv_check.DataSource = dgvCheck();
            
        }
        public DataTable dgvCheck()
        {
            int shi = shift();
            int id = IdUser();
            DataTable dtCheckIn = ck.tableCheckinout(id, "Check In");

            DataTable dtCheckOut = ck.tableCheckinout(id, "Check Out");

            DataTable tableCheck = new DataTable();
            tableCheck.Columns.Add("Shift Name", typeof(string));
            tableCheck.Columns.Add("Date", typeof(string));
            tableCheck.Columns.Add("Time In", typeof(string));
            tableCheck.Columns.Add("Time Out", typeof(string));
            for(int i = 0; i < dtCheckIn.Rows.Count; i++)
            {
                DataRow dr = tableCheck.NewRow();
                dr["Shift Name"] = dtCheckIn.Rows[i]["shift_name"].ToString();
                dr["Date"] = Convert.ToDateTime(dtCheckIn.Rows[i]["day_check"].ToString()).DayOfWeek.ToString();
                dr["Time In"] = Convert.ToDateTime(dtCheckIn.Rows[i]["time_check"].ToString()).ToString("HH:mm:ss");
                tableCheck.Rows.Add(dr);
            }
            for(int i = 0; i < dtCheckIn.Rows.Count; i++)
            {
                for(int j = 0; j < dtCheckOut.Rows.Count; j++)
                {
                    if(tableCheck.Rows[i]["Shift Name"].ToString() == dtCheckOut.Rows[j]["shift_name"].ToString())
                    {
                        tableCheck.Rows[i]["Time Out"] = Convert.ToDateTime(dtCheckOut.Rows[i]["time_check"].ToString()).ToString("HH:mm:ss");
                    }
                }
            }
            return tableCheck;

        }
        public int IdUser()
        {
            SqlCommand commandID = new SqlCommand("select emp_id from EmployeeAccounts where EmployeeAccounts.acc_id = (select acc_id from Accounts where username = @user)");
            commandID.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            DataTable dtID = ck.getTable(commandID);
            return int.Parse(dtID.Rows[0]["emp_id"].ToString());
        }
        public int shift()
        {
            int sht = 3;
            SqlCommand command = new SqlCommand("select shift_id, time_start, time_end from Shifts");
            DataTable dt = ck.getTable(command);
            DateTime tmp = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(tmp >= Convert.ToDateTime(dt.Rows[i]["time_start"].ToString()) && tmp < Convert.ToDateTime(dt.Rows[i]["time_end"].ToString()))
                {
                    sht =  int.Parse(dt.Rows[i]["shift_id"].ToString());
                }
            }
            return sht;
        }
        public bool checkin()
        {
            int id = IdUser();
            SqlCommand command = new SqlCommand("select emp_id, shift_id, day_check from CheckInOut where status_check = 'Check In' and emp_id = @idu");
            command.Parameters.Add("@idu", SqlDbType.Int).Value = id;
            DataTable dt = ck.getTable(command);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(shift() == 3 && dt.Rows[i]["shift_id"].ToString() == shift().ToString())
                {
                    if(Convert.ToDateTime(dt.Rows[i]["day_check"].ToString()).ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy") 
                        || Convert.ToDateTime(dt.Rows[i]["day_check"].ToString()).AddDays(1).ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy"))
                    {
                        return false;
                    }
                }
                else if (dt.Rows[i]["shift_id"].ToString() == shift().ToString()
                    && Convert.ToDateTime(dt.Rows[i]["day_check"].ToString()).ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy"))
                {
                    return false;
                }
            }
            return true;
        }
        public bool checkout()
        {
            SqlCommand command = new SqlCommand("select emp_id, shift_id, day_check from CheckInOut where status_check = 'Check Out'");
            DataTable dt = ck.getTable(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["emp_id"].ToString() == IdUser().ToString() && dt.Rows[i]["shift_id"].ToString() == shift().ToString()
                    && Convert.ToDateTime(dt.Rows[i]["day_check"].ToString()).ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy"))
                {
                    return false;
                }
            }
            return true;
        }
        private void Check_in_BT_Click(object sender, EventArgs e)
        {
            if (checkin())
            {
                if(MessageBox.Show("Are You Sure To Check In?", "Check In", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ck.insertCheckinout(IdUser(), shift(), Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")), DateTime.Now, "Check In");
                    MessageBox.Show("You have successfully checked in", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_check.DataSource = dgvCheck();
                    dgv_check.RowTemplate.Height = 50;
                    dgv_check.ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show("You have already checked in this shift !", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void Check_out_BT_Click(object sender, EventArgs e)
        {
            if (checkout())
            {
                if (MessageBox.Show("Are You Sure To Check Out?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ck.insertCheckinout(IdUser(), shift(), Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")), DateTime.Now, "Check Out");
                    MessageBox.Show("You have successfully checked Out", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_check.DataSource = dgvCheck();
                    dgv_check.RowTemplate.Height = 50;
                    dgv_check.ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show("You have already checked out this shift !", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void Cancel_BT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
