using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    class Employee
    {
        MY_DB mydb = new MY_DB();
        public string insertEmployee(string fname, string lname, string email, string title, string gender, DateTime bdate, DateTime hdate, string address, string phone,  MemoryStream picture)
        {
            SqlCommand com = new SqlCommand("AddEmployeeReturnIDwithoutput", mydb.getConnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            com.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            com.Parameters.Add("@eml", SqlDbType.NVarChar).Value = email;
            com.Parameters.Add("@tle", SqlDbType.NVarChar).Value = title;
            com.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gender;
            com.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            com.Parameters.Add("@hdt", SqlDbType.DateTime).Value = hdate;
            com.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            com.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            com.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            com.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

            mydb.openConnection();
            try
            {
                int cmd = com.ExecuteNonQuery();

                string id = com.Parameters["@id"].Value.ToString();
                mydb.closeConnection();
                return id;
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
        public bool updateEmployee(int id, string fname, string lname, string email, string title, string gender, DateTime bdate, DateTime hdate, string address, string phone, MemoryStream picture)
        {
            SqlCommand com = new SqlCommand("UPDATE Employees SET FirstName=@fn, LastName=@ln, Email=@eml, Title=@tle, Gender=@gdr, bdate=@bdt, hdate=@hdt, Phone=@phn, Ad" +
                                            "dress=@adrs, Photo = @pic WHERE emp_id=@ID", mydb.getConnection);
            com.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            com.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            com.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            com.Parameters.Add("@eml", SqlDbType.NVarChar).Value = email;
            com.Parameters.Add("@tle", SqlDbType.NVarChar).Value = title;
            com.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gender;
            com.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            com.Parameters.Add("@hdt", SqlDbType.DateTime).Value = hdate;
            com.Parameters.Add("@phn", SqlDbType.NVarChar).Value = phone;
            com.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            com.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if (com.ExecuteNonQuery() == 1)
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
        public bool delEmployee(int id)
        {
            try
            {
                SqlCommand com = new SqlCommand("DELETE FROM Employees WHERE emp_id = @id", mydb.getConnection);
                com.Parameters.Add("@id", SqlDbType.Int).Value = id;
                mydb.openConnection();
                if (com.ExecuteNonQuery() == 1)
                {
                    mydb.closeConnection();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mydb.closeConnection();
            }
            return false;
        }
        public DataTable getEmployees(SqlCommand com)
        {
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int countEmployeesByTitle(string title)
        {
            SqlCommand com = new SqlCommand("Select Count(*) From Employees Where title=@tle", mydb.getConnection);
            com.Parameters.Add("@tle", SqlDbType.NVarChar).Value = title;
            mydb.openConnection();
            int res = (int)com.ExecuteScalar();
            mydb.closeConnection();
            return res;
        }
        public int numOfEmployees()
        {
            SqlCommand com = new SqlCommand("Select Count(*) From Employees ", mydb.getConnection);
            mydb.openConnection();
            int res = (int)com.ExecuteScalar();
            mydb.closeConnection();
            return res;
        }
    }
}
