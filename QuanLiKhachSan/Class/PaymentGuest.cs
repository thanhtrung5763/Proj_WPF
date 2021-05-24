using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    class PaymentGuest
    {
        MY_DB mydb = new MY_DB();
        public int getNumOfPGuest()
        {
            SqlCommand com = new SqlCommand("Select Count(*) From PaymentGuest", mydb.getConnection);
            mydb.openConnection();
            int num = (int)com.ExecuteScalar();
            mydb.closeConnection();
            return num;
        }
        public bool isExist(int res_id)
        {
            if(this.getNumOfPGuest() == 0)
                return false;
            SqlCommand com = new SqlCommand("Select Count(*) From PaymentGuest Where res_id=@rid", mydb.getConnection);
            com.Parameters.Add("@rid", SqlDbType.Int).Value = res_id;
            com.Connection = mydb.getConnection;
            mydb.openConnection();
            int num = (int)com.ExecuteScalar();
            mydb.closeConnection();
            com.Parameters.Clear();
            if (num > 0)
                return true;
            return false;
        } 
        public bool insertOverdueData(int res_id, int payment, int dif_day)
        {
            int pid = getNumOfPGuest() + 1;
            if(isExist(res_id))
            {
                return false;
            }
            SqlCommand com = new SqlCommand("Insert into PaymentGuest Values(@pid, @rid, @od)", mydb.getConnection);
            com.Parameters.Add("@pid", SqlDbType.Int).Value = pid;
            com.Parameters.Add("@rid", SqlDbType.Int).Value = res_id;
            com.Parameters.Add("@od", SqlDbType.Int).Value = payment * dif_day * 0.2;

            mydb.openConnection();
            if (com.ExecuteNonQuery() == 1)
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
        public DataTable getResOverDueInfo(string time)
        {
            SqlCommand com = new SqlCommand($"Select Reservation.res_id, Reservation.room_id, cin_date_book, cout_date_book, cin_date, cout_date, overdue_money From Reservation, RoomTypes, Rooms, PaymentGuest Where Reservation.room_id = Rooms.room_id And Rooms.room_type_id = RoomTypes.room_type_id And Reservation.res_id = PaymentGuest.res_id And '{time}' = cout_date", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
    }
}
