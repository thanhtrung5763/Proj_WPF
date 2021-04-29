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

        public DataTable getSchedule(SqlCommand command)
        {
            command.Connection = myDB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool insertCheckinout(int id, DateTime date, string sta, int sht)
        {
            SqlCommand command = new SqlCommand("insert into check_in_out (emp_id, day_check, status_check, shift_id) values (@id, @date, @sta, @sht)", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@sta", SqlDbType.NVarChar).Value = sta;
            command.Parameters.Add("@sht", SqlDbType.Int).Value = sht;
            myDB.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                myDB.closeConnection();
                return true;
            }
            else
            {
                myDB.closeConnection();
                return false;
            }
        }
    }
}
