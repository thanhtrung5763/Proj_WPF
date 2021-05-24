using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLiKhachSan
{
    class Guest
    {
        MY_DB mydb = new MY_DB();
        public DataTable getInfoGuest(int id)
        {
            SqlCommand com = new SqlCommand("Select * From Guest Where guest_id=@id", mydb.getConnection);
            com.Parameters.Add("@id", SqlDbType.Int).Value = id;
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
        public DataTable getInfoGuestByRoom(int rid)
        {
            SqlCommand com = new SqlCommand("Select Guest.guest_id, username, password, firstname, lastname, phone, photo, cin_date_book, cout_date_book From Guest, (Select distinct guest_id, cin_date_book, cout_date_book From Reservation Where room_id=@rid And cout_date is null) T Where T.guest_id = Guest.guest_id", mydb.getConnection);
            com.Parameters.Add("@rid", SqlDbType.Int).Value = rid;
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
        public int getNumOfGuest()
        {
            SqlCommand com = new SqlCommand("Select Count(*) From Guest", mydb.getConnection);
            mydb.openConnection();
            int num = (int)com.ExecuteScalar();
            mydb.closeConnection();
            return num;
        }
        public bool createGuest(int id, string fname, string lname, string uname, string pwd, string phn, MemoryStream pic, SqlCommand com)
        {
            com.Connection = mydb.getConnection;
            com.Parameters.Add("@id", SqlDbType.Int).Value = id;
            com.Parameters.Add("@fname", SqlDbType.NChar).Value = fname;
            com.Parameters.Add("@lname", SqlDbType.NChar).Value = lname;
            com.Parameters.Add("@uname", SqlDbType.NChar).Value = uname;
            com.Parameters.Add("@pwd", SqlDbType.NChar).Value = pwd;
            com.Parameters.Add("@phn", SqlDbType.NChar).Value = phn;
            com.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            mydb.openConnection();
            int cmd = com.ExecuteNonQuery();
            if (cmd == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
