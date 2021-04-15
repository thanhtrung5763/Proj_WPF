using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    class Account
    {
        MY_DB mydb = new MY_DB();
        public DataTable getAccounts(SqlCommand com)
        {
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool createAccount(string id, string username, string password)
        {

            
            SqlCommand com = new SqlCommand("INSERT INTO Accounts (username, password)" + $"VALUES (@usn, @psw) ", mydb.getConnection);
            com.Parameters.Add("@usn", SqlDbType.NVarChar).Value = username;
            com.Parameters.Add("@psw", SqlDbType.NVarChar).Value = password;

            mydb.openConnection();
            try
            {
                com.ExecuteNonQuery();
                com.CommandText = "INSERT INTO EmployeeAccounts (emp_id, acc_id)" +
                                 $"VALUES ((SELECT emp_id FROM Employees WHERE emp_id=@id), (SELECT acc_id FROM Accounts WHERE username=@usn))";
                com.Connection = mydb.getConnection;
                com.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                mydb.openConnection();
                com.ExecuteNonQuery();
                mydb.closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mydb.closeConnection();
            }
        }
        public bool delAccount(int id)
        {
            
            try
            {
                SqlCommand com = new SqlCommand("DELETE FROM EmployeeAccounts WHERE acc_id = @id", mydb.getConnection);
                com.Parameters.Add("@id", SqlDbType.Int).Value = id;
                mydb.openConnection();
                com.ExecuteNonQuery();
                com.CommandText = "DELETE FROM Accounts WHERE acc_id=@id";
                com.Connection = mydb.getConnection;
                mydb.openConnection();
                com.ExecuteNonQuery();
                mydb.closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mydb.closeConnection();
            }
        }
    }
}
