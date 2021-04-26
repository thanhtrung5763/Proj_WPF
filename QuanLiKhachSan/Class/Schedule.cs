using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLiKhachSan
{
    class Schedule
    {
        MY_DB mydb = new MY_DB();
        SqlCommand com = new SqlCommand();
        public int numOfSchedule()
        {
            com.CommandText = "Select Count(distinct schedule_id) From dbo.Schedules";
            com.Connection = mydb.getConnection;
            mydb.openConnection();
            int num = (int)com.ExecuteScalar();
            mydb.closeConnection();
            return num;
        }
        public bool addSchedule(int id, int shift_id, int emp_id, string firstname, string lastname, string title, DateTime date_start, DateTime date_end,
                        string Monday, string Tuesday, string Wednesday, string Thursday, string Friday, string Saturday, string Sunday)
        {
            com.CommandText = "Insert into Schedules(schedule_id, shift_id, emp_id, firstname, lastname, title, date_start, date_end, " +
                "Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday)" +
                "Values(@sch_id, @sid, @eid, @fname, @lname, @tle, @dstart, @dend, @mday, @tday, @wday, @thday, @fday, @satday, @sunday)";
            com.Connection = mydb.getConnection;
            com.Parameters.Add("@sch_id", SqlDbType.Int).Value = id;
            com.Parameters.Add("@sid", SqlDbType.Int).Value = shift_id;
            com.Parameters.Add("@eid", SqlDbType.Int).Value = emp_id;
            com.Parameters.Add("@fname", SqlDbType.NVarChar).Value = firstname;
            com.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lastname;
            com.Parameters.Add("@tle", SqlDbType.NVarChar).Value = title;
            com.Parameters.Add("@dstart", SqlDbType.DateTime).Value = date_start;
            com.Parameters.Add("@dend", SqlDbType.DateTime).Value = date_end;
            com.Parameters.Add("@mday", SqlDbType.NVarChar).Value = Monday;
            com.Parameters.Add("@tday", SqlDbType.NVarChar).Value = Tuesday;
            com.Parameters.Add("@wday", SqlDbType.NVarChar).Value = Wednesday;
            com.Parameters.Add("@thday", SqlDbType.NVarChar).Value = Thursday;
            com.Parameters.Add("@fday", SqlDbType.NVarChar).Value = Friday;
            com.Parameters.Add("@satday", SqlDbType.NVarChar).Value = Saturday;
            com.Parameters.Add("@sunday", SqlDbType.NVarChar).Value = Sunday;
            mydb.openConnection();
            if(com.ExecuteNonQuery() == 1)
            {
                com.Parameters.Clear();
                mydb.closeConnection();
                return true;
            }
            else
            {
                com.Parameters.Clear();
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getScheduleInfo()
        {
            com.CommandText = "Select distinct schedule_id, date_start, date_end From Schedules";
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getScheduleAllInfo(int id)
        {
            com.CommandText = "Select emp_id, firstname, lastname, title, Monday, Tuesday, Wednesday, " + 
                "Thursday, Friday, Saturday, Sunday From Schedules Where schedule_id = @sid";
            com.Parameters.Add("@sid", SqlDbType.Int).Value = id;
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
    }
}
