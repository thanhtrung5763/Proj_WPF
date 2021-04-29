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

        private void Check_in_outForm_Load_1(object sender, EventArgs e)
        {
            DateTime tmp = dateTimePicker1.Value;
            SqlCommand command = new SqlCommand("select  * from  Schedules where Schedules.emp_id = (select emp_id from (select acc_id from Accounts where username = '"
                + username+ "') as p inner join EmployeeAccounts on p.acc_id = EmployeeAccounts.acc_id)");
            dgv.RowTemplate.Height = 50;
            command.Parameters.Add("@tmp", SqlDbType.DateTime).Value = tmp;
            dgv.DataSource = ck.getSchedule(command);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emp_id_TB.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            shift_id_TB.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            firstname_TB.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            lastname_TB.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            title_TB.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            day_TB.Text = DateTime.Now.DayOfWeek.ToString();
        }

        public int shift()
        {
            int sht = 0;
            SqlCommand command = new SqlCommand("select shift_id, time_start, time_end from Shifts");
            DataTable dt = ck.getSchedule(command);
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

        public bool checkout()
        {
            SqlCommand command = new SqlCommand("select * from check_in_out");
            DataTable dt = ck.getSchedule(command);

            SqlCommand commandID = new SqlCommand("select emp_id from EmployeeAccounts where EmployeeAccounts.acc_id = (select acc_id from Accounts where username = @user)");
            commandID.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            DataTable dtID = ck.getSchedule(commandID);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["emp_id"].ToString() == dtID.Rows[0]["emp_id"].ToString()
                    && Convert.ToDateTime(dt.Rows[i]["day_check"].ToString()).ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")
                    && dt.Rows[i]["status_check"].ToString() == "Check Out" && dt.Rows[i]["shift_id"].ToString() == shift().ToString())
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkin()
        {
            SqlCommand command = new SqlCommand("select * from check_in_out");
            DataTable dt = ck.getSchedule(command);

            SqlCommand commandID  = new SqlCommand("select emp_id from EmployeeAccounts where EmployeeAccounts.acc_id = (select acc_id from Accounts where username = @user)");
            commandID.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            DataTable dtID = ck.getSchedule(commandID);


            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i]["emp_id"].ToString() == dtID.Rows[0]["emp_id"].ToString() 
                    && Convert.ToDateTime(dt.Rows[i]["day_check"].ToString()).ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")
                    && dt.Rows[i]["status_check"].ToString() == "Check In" && dt.Rows[i]["shift_id"].ToString() == shift().ToString())
                {
                    return false;
                }
            }
            return true;
        }


        private void Check_in_BT_Click(object sender, EventArgs e)
        {
            if (shift().ToString() != shift_id_TB.Text)
            {
                MessageBox.Show("Please select the correct shift to check in!", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(checkin() && MessageBox.Show("Are you sure to check in?", "Check In", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ck.insertCheckinout(int.Parse(emp_id_TB.Text), DateTime.Now, "Check In", shift());
                    MessageBox.Show("Check in is successful", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!checkin())
                {
                    MessageBox.Show("You have already checked in", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Check_out_BT_Click(object sender, EventArgs e)
        {
            if (shift().ToString() != shift_id_TB.Text)
            {
                MessageBox.Show("Please select the correct shift to check out!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (checkout() && MessageBox.Show("Are you sure to check out?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ck.insertCheckinout(int.Parse(emp_id_TB.Text), DateTime.Now, "Check Out", shift());
                    MessageBox.Show("Check out is successful", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!checkout())
                {
                    MessageBox.Show("You have already checked out", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
