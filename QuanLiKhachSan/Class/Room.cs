using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    class Room
    {
        MY_DB mydb = new MY_DB();
        SqlCommand com = new SqlCommand();
        public DataTable getAllRooms()
        {
            com.CommandText = "Select room_id, room_type_name, room_capacity, room_num_beds, room_price, status_name" +
                " FROM Rooms, RoomTypes, RoomStatus" +
                " WHERE Rooms.room_type_id = RoomTypes.room_type_id and Rooms.status_id = RoomStatus.status_id";
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getRoomType()
        {
            com.CommandText = "Select room_type_name, room_type_id" +
                " FROM RoomTypes";
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getInfoRoomByType(int room_type_id)
        {
            com.CommandText = "Select room_capacity, room_num_beds, room_price " +
                " FROM RoomTypes" +
                $" WHERE room_type_id = {room_type_id}";
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insertRoom(int rtid, bool status)
        {
            com.CommandText = "Insert into Rooms(room_type_id, status_id)" + " Values (@rtid, @stt)";
            com.Parameters.Add("@rtid", SqlDbType.Int).Value = rtid;
            com.Parameters.Add("@stt", SqlDbType.Bit).Value = status;
            com.Connection = mydb.getConnection;
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
        public bool delRoom(int rid)
        {
            com.CommandText = "Delete From Rooms Where room_id = @rid";
            com.Parameters.Add("@rid", SqlDbType.Int).Value = rid;
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
        public DataTable getAllRoomTypes()
        {
            com.CommandText = "Select * From RoomTypes";
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int numOfRoomType()
        {
            com.CommandText = "Select Count(*) From RoomTypes";
            com.Connection = mydb.getConnection;
            mydb.openConnection();
            int num = (int)com.ExecuteScalar();
            mydb.closeConnection();
            return num;
        }
        public bool checkExistRoomType(string roomType)
        {
            com.CommandText = $"Select room_type_name From RoomTypes Where room_type_name = @rtn";
            com.Parameters.Add("@rtn", SqlDbType.NVarChar).Value = roomType;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                com.Parameters.Clear();
                return true;
            }
            else { 
                com.Parameters.Clear();
                return false;

            }
        }
        public bool addRoomType(string roomType, int capacity, int bed, int price, bool status)
        {
            int num = this.numOfRoomType();
            com.CommandText = "Insert into RoomTypes(room_type_id, room_type_name, room_capacity, room_num_beds, room_price) Values(@rtid, @rtn, @rc, @rnb, @rp)";
            com.Parameters.Add("@rtid", SqlDbType.Int).Value = num + 1;
            com.Parameters.Add("@rtn", SqlDbType.NVarChar).Value = roomType;
            com.Parameters.Add("@rc", SqlDbType.NVarChar).Value = capacity;
            com.Parameters.Add("@rnb", SqlDbType.Int).Value = bed;
            com.Parameters.Add("@rp", SqlDbType.Int).Value = price;
            mydb.openConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                com.Parameters.Clear();
                mydb.closeConnection();
                com.CommandText = "Insert into Rooms(room_type_id, status_id) Values(@rtid, @stt)";
                com.Parameters.Add("@rtid", SqlDbType.Int).Value = num + 1;
                com.Parameters.Add("@stt", SqlDbType.Bit).Value = status;
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
            else
            {
                com.Parameters.Clear();
                mydb.closeConnection();
                return false;
            }
        }
        public int getIdRoomTypeByName(string roomType)
        {
            com.CommandText = $"Select Rooms.room_type_id From Rooms, RoomTypes Where Rooms.room_type_id = RoomTypes.room_type_id and room_type_name = @rtn";
            com.Parameters.Add("@rtn", SqlDbType.NVarChar).Value = roomType;
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["room_type_id"]);
        }
        public bool delRoomType(string roomType)
        {
            int id = getIdRoomTypeByName(roomType);
            com.CommandText = $"Delete From Rooms Where room_type_id = {id}";
            mydb.openConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                com.Parameters.Clear();
                mydb.closeConnection();
                com.CommandText = $"Delete From RoomTypes Where room_type_name = @rtn";
                com.Parameters.Add("@rtn", SqlDbType.NVarChar).Value = roomType;
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
            else
            {
                com.Parameters.Clear();
                mydb.closeConnection();
                return false;
            }
        }
    }
}
