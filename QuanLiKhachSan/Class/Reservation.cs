using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    class Reservation
    {
        MY_DB mydb = new MY_DB();
        public bool createRes(int gid, int rid, DateTime cin, DateTime cout)
        {
            int res_id = getNumOfRes() + 1;
            SqlCommand com = new SqlCommand("Insert into Reservation(res_id, guest_id, room_id, cin_date_book, cout_date_book) Values(@res_id, @gid, @rid, @cin, @cout)", mydb.getConnection);
            com.Parameters.Add("@res_id", SqlDbType.Int).Value = res_id;
            com.Parameters.Add("@gid", SqlDbType.Int).Value = gid;
            com.Parameters.Add("@rid", SqlDbType.Int).Value = rid;
            com.Parameters.Add("@cin", SqlDbType.Date).Value = cin.Date;
            com.Parameters.Add("@cout", SqlDbType.Date).Value = cout.Date;
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
        public int getNumOfRes()
        {
            SqlCommand com = new SqlCommand("Select Count(*) From Reservation", mydb.getConnection);
            mydb.openConnection();
            int num = (int)com.ExecuteScalar();
            mydb.closeConnection();
            return num;
        }
        public DataTable getRes(int gid)
        {
            SqlCommand com = new SqlCommand("Select res_id, room_id, cin_date_book, cout_date_book, cin_date, cout_date From Reservation Where guest_id=@gid And cin_date is null Or cout_date is null", mydb.getConnection);
            com.Parameters.Add("@gid", SqlDbType.Int).Value = gid;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
        public bool insertCheckInData(int res_id, DateTime cin)
        {
            SqlCommand com = new SqlCommand("Update Reservation Set cin_date=@cin Where res_id=@res_id", mydb.getConnection);
            com.Parameters.Add("@cin", SqlDbType.Date).Value = cin.Date;
            com.Parameters.Add("@res_id", SqlDbType.Int).Value = res_id;
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
        public bool insertCheckOutData(int res_id, DateTime cout)
        {
            SqlCommand com = new SqlCommand("Update Reservation Set cout_date=@cout Where res_id=@res_id", mydb.getConnection);
            com.Parameters.Add("@cout", SqlDbType.Date).Value = cout.Date;
            com.Parameters.Add("@res_id", SqlDbType.Int).Value = res_id;
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
        public DataTable getAllRes(int gid)
        {
            SqlCommand com = new SqlCommand("Select res_id, Reservation.room_id, cin_date_book, cout_date_book, cin_date, cout_date, room_price From Reservation, RoomTypes, Rooms Where Reservation.room_id = Rooms.room_id And Rooms.room_type_id = RoomTypes.room_type_id And guest_id=@gid", mydb.getConnection);
            com.Parameters.Add("@gid", SqlDbType.Int).Value = gid;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
        public DataTable getAllRes()
        {
            SqlCommand com = new SqlCommand("Select res_id, Reservation.room_id, cin_date_book, cout_date_book, cin_date, cout_date, room_price From Reservation, RoomTypes, Rooms Where Reservation.room_id = Rooms.room_id And Rooms.room_type_id = RoomTypes.room_type_id", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
        public DataTable getAllRes(string time)
        {
            SqlCommand com = new SqlCommand($"Select Reservation.res_id, Reservation.room_id, cin_date_book, " +
                $"cout_date_book, cin_date, cout_date, room_price From Reservation, RoomTypes, " +
                $"Rooms Where Reservation.room_id = Rooms.room_id And Rooms.room_type_id = RoomTypes.room_type_id And '{time}' = cin_date_book", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
        public DataTable getResOverDue(string time)
        {
            SqlCommand com = new SqlCommand($"Select res_id, Reservation.room_id, cin_date_book, cout_date_book, cin_date, cout_date, room_price From Reservation, RoomTypes, Rooms Where Reservation.room_id = Rooms.room_id And Rooms.room_type_id = RoomTypes.room_type_id And '{time}' > cout_date_book", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
    }
}
