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
        public DataTable getDataCheckInCheckOut(int id)
        {
            command.CommandText = "Select day, shift_name, time_start, time_end, time_in, time_out From CheckInOut Where emp_id=@id";
            command.Connection = myDB.getConnection;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            command.Parameters.Clear();
            return dt;
        }
        public DataTable getDataCheckInCheckOutAndCalPayment(DateTime dselect)
        {
            command.CommandText = "Select Employees.emp_id, firstname, lastname, day, shift_name, time_start, time_end, time_in, time_out, time_worked, DATEPART(hour, time_worked)*salary As Salary From (Select * From CheckInOut Where day=@dselect) C, Employees, Payment Where Employees.Title = Payment.Title And C.emp_id = Employees.emp_id";
            command.Parameters.Add("@dselect", SqlDbType.Date).Value = dselect.Date;
            command.Connection = myDB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            command.Parameters.Clear();
            return dt;
        }
        public DataTable getDataCheckInCheckOutWith(int id, DateTime dname)
        {
            command.CommandText = "Select emp_id, day, shift_name, time_start, time_end, time_in, time_out From CheckInOut Where emp_id=@eid and day=@date";
            command.Connection = myDB.getConnection;
            command.Parameters.Add("@eid", SqlDbType.Int).Value = id;
            command.Parameters.Add("@date", SqlDbType.Date).Value = dname;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            command.Parameters.Clear();

            return dt;
        }
        public bool insertCheckOutData(int id, DateTime dname, string sname, TimeSpan tout, TimeSpan twork)
        {
            command.Parameters.Clear();
            command.CommandText = "Update CheckInOut Set time_out = @time_out, time_worked = @twork Where emp_id=@eid and day=@dname and shift_name=@sname";
            command.Parameters.Add("@eid", SqlDbType.Int).Value = id;
            command.Parameters.Add("@dname", SqlDbType.Date).Value = dname;
            command.Parameters.Add("@sname", SqlDbType.NVarChar).Value = sname;
            command.Parameters.Add("@time_out", SqlDbType.Time).Value = tout;
            command.Parameters.Add("@twork", SqlDbType.Time).Value = twork;
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
        public DataTable getScheduleByUserId(DateTime tnow, int eid)
        {
            command.CommandText = "select Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday from  Schedules " +
                "where Schedules.emp_id = @eid  and date_start <= @tnow and date_end >= @tnow";
            command.Parameters.Add("@eid", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@tnow", SqlDbType.DateTime).Value = tnow;
            command.Connection = myDB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            command.Parameters.Clear();
            return table;
        }
        public DataTable getShiftTimeByUserId(DateTime tnow, int eid)
        {
            command.CommandText = "Select shift_name, time_start, time_end, num_manager, num_receptionist, num_janitor From Shifts Where set_id=(select distinct set_id from Schedules Where Schedules.emp_id = @eid and @tnow BETWEEN date_start And date_end)";
            command.Parameters.Add("@eid", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@tnow", SqlDbType.DateTime).Value = tnow;
            command.Connection = myDB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            command.Parameters.Clear();
            return table;
        }
        public bool insertCheckInData(int eid, DateTime date_name, string shift_name, TimeSpan tstart, TimeSpan tend, TimeSpan tin)
        {
            command.CommandText = "Insert into CheckInOut(emp_id, day, shift_name, time_start, time_end, time_in) Values(@eid, @dname, @sname, @tstart, @tend, @tin)";
            command.Parameters.Add("@eid", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@dname", SqlDbType.Date).Value = date_name;
            command.Parameters.Add("@sname", SqlDbType.NVarChar).Value = shift_name;
            command.Parameters.Add("@tstart", SqlDbType.Time).Value = tstart;
            command.Parameters.Add("@tend", SqlDbType.Time).Value = tend;
            command.Parameters.Add("@tin", SqlDbType.Time).Value = tin;
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
        public bool isExist(int id, DateTime dname, string sname)
        {
            command.CommandText = "Select Count(*) From CheckInOut Where emp_id=@eid and day=@dname and shift_name=@sname";
            command.Parameters.Add("@eid", SqlDbType.Int).Value = id;
            command.Parameters.Add("@dname", SqlDbType.Date).Value = dname;
            command.Parameters.Add("@sname", SqlDbType.NVarChar).Value = sname;
            command.Connection = myDB.getConnection;
            myDB.openConnection();
            int num = (int)command.ExecuteScalar();
            myDB.closeConnection();
            command.Parameters.Clear();
            if (num > 0)
                return true;
            return false;
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
