using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    class Check_in_out
    {
        MY_DB myDB = new MY_DB();
        SqlCommand command = new SqlCommand();

        public DataTable getTable(SqlCommand command)
        {
            command.Connection = myDB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool insertCheckinout(int id, int sht, DateTime date, DateTime time, string sta)
        {
            command.CommandText = "insert into CheckInOut (emp_id, shift_id, day_check, time_check, status_check) values (@emp, @shi, @day, @time, @sta)";
            command.Connection = myDB.getConnection;
            command.Parameters.Add("@emp", SqlDbType.Int).Value = id;
            command.Parameters.Add("@shi", SqlDbType.Int).Value = sht;
            command.Parameters.Add("@day", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = time;
            command.Parameters.Add("sta", SqlDbType.VarChar).Value = sta;

            myDB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                command.Parameters.Clear();
                myDB.closeConnection();
                return true;
            }
            else
            {
                command.Parameters.Clear();
                myDB.closeConnection();
                return false;
            }
        }
        public DataTable schedule(string username)
        {
            command.CommandText = "select shift_id as ShiftID,  Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday from  Schedules " +
                "where Schedules.emp_id = (select emp_id from (select acc_id from Accounts where username = '"
                + username + "') as p inner join EmployeeAccounts on p.acc_id = EmployeeAccounts.acc_id)";
            command.Connection = myDB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable tableCheckinout(int id, string status)
        {
            command.CommandText = "select emp_id, Shifts.shift_id, shift_name, day_check, time_check from CheckInOut inner join Shifts on CheckInOut.shift_id = Shifts.shift_id where emp_id = "+ id+" and status_check = '" +status+"'";
            command.Connection = myDB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
