using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    class Shift
    {
        public static int needed_emp;
        public static int emps;
        public static int days;
        public static int shifts;
        public static int[,,] shift_needed_emp;
        public static int[,,] res;
        public static int[] list_id_emps;
        Employee emp = new Employee();
        MY_DB mydb = new MY_DB();
        SqlCommand com = new SqlCommand();
        public DataTable getAllShifts()
        {
            com.CommandText = "Select * From Shifts";
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int numOfShift()
        {
            com.CommandText = "Select Count(*) From Shifts";
            com.Connection = mydb.getConnection;
            mydb.openConnection();
            int num = (int)com.ExecuteScalar();
            mydb.closeConnection();
            return num;
        }
        public bool addShift(string name, TimeSpan time_start, TimeSpan time_end, int no_manager, int no_recept, int no_janitor)
        {
            int num = this.numOfShift();
            com.CommandText = "Insert Into Shifts(shift_id, shift_name, time_start, time_end, num_manager, num_receptionist, num_janitor)" +
                                "Values(@sid, @name, @tstart, @tend, @no_manager, @no_recept, @no_janitor)";
            com.Parameters.Add("@sid", SqlDbType.Int).Value = num + 1;
            com.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            com.Parameters.Add("@tstart", SqlDbType.Time).Value = time_start;
            com.Parameters.Add("@tend", SqlDbType.Time).Value = time_end;
            com.Parameters.Add("@no_manager", SqlDbType.Int).Value = no_manager;
            com.Parameters.Add("@no_recept", SqlDbType.Int).Value = no_recept;
            com.Parameters.Add("@no_janitor", SqlDbType.Int).Value = no_janitor;
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
        public bool delShift(string name)
        {
            com.CommandText = "Delete From Shifts Where shift_name = @name";
            com.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
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
        public int getIdByName(string name)
        {
            com.CommandText = "Select shift_id From Shifts Where shift_name=@name";
            com.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return Convert.ToInt32(dt.Rows[0]["shift_id"]);
        }
        public DataTable getInfoShiftById(int shift_id)
        {
            com.CommandText = "Select * From Shifts Where shift_id =@sid";
            com.Parameters.Add("@sid", SqlDbType.Int).Value = shift_id;
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
        public bool editShift(string name, TimeSpan time_start, TimeSpan time_end, int no_manager, int no_recept, int no_janitor)
        {
            int id = this.getIdByName(name);
            com.CommandText = "Update Shifts Set shift_name=@name, time_start=@tstart, time_end=@tend, num_manager=@no_manager, " +
                                "num_receptionist=@no_recept, num_janitor=@no_janitor WHERE shift_id = @sid";
            com.Parameters.Add("@sid", SqlDbType.Int).Value = id;
            com.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            com.Parameters.Add("@tstart", SqlDbType.Time).Value = time_start;
            com.Parameters.Add("@tend", SqlDbType.Time).Value = time_end;
            com.Parameters.Add("@no_manager", SqlDbType.Int).Value = no_manager;
            com.Parameters.Add("@no_recept", SqlDbType.Int).Value = no_recept;
            com.Parameters.Add("@no_janitor", SqlDbType.Int).Value = no_janitor;
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


        public void schedule(int emps, int days, int shifts, int emp)
        {
            int n = days;
            int m = shifts;
            int[,] arr = new int[m, n];
            int cons_emp = emp;
            int row_begin = 0;
            int col_begin = 0;
            for (int day = 0; day < n + 1; day++)
            {
                int row = row_begin;
                int col = col_begin;
                while (row < m && col < n)
                {
                    arr[row, col] = list_id_emps[emp];
                    row += 1;
                    col += 1;
                }
                emp = (emp + 1) % (emps);
                col_begin += 1;
            }
            row_begin = 1;
            col_begin = 0;
            emp = (cons_emp + 1) % (emps);
            for (int day = 0; day < m - 1; day++)
            {
                int row = row_begin;
                int col = col_begin;
                while (row < m && col < n)
                {
                    arr[row, col] = list_id_emps[emp];
                    row += 1;
                    col += 1;
                }
                emp = (emp + 1) % (emps);
                row_begin += 1;
            }
            for (int i = 1; i < needed_emp; i++)
            {
                for (int j = 0; j < shifts; j++)
                {
                    for (int k = 0; k < days; k++)
                    {
                        shift_needed_emp[i - 1, j, k] = shift_needed_emp[i, j, k];
                    }
                }
            }
            for (int j = 0; j < shifts; j++)
            {
                for (int k = 0; k < days; k++)
                {
                    shift_needed_emp[needed_emp - 1, j, k] = arr[j, k];
                }
            }
        }
        public DataTable getAllShiftsName()
        {
            com.CommandText = "Select shift_name From Shifts";
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable automaticShift(string title, int needEmp, int num_employees, string shift_name, int idx_start)
        {
            days = 7;
            shifts = 1;
            needed_emp = needEmp;
            emps = num_employees;
            shift_needed_emp = new int[needed_emp, shifts, days];
            res = new int[shifts, days, needed_emp];
            com.Parameters.Clear();
            com.CommandText = $"Select emp_id, firstname, lastname, title From Employees Where title=@title";
            com.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
            DataTable dt_empInfo = emp.getEmployees(com);
            list_id_emps = new int[emps];
            for (var i = 0; i < dt_empInfo.Rows.Count; i++)
                list_id_emps[i] = Convert.ToInt32(dt_empInfo.Rows[i][0]);
            int idx = idx_start;
            for (int i = 0; i < needed_emp; i++)
            {
                schedule(emps, days, shifts, idx);
                int pre_idx = idx;
                idx = (idx + shifts) % emps;
                if (idx == pre_idx)
                    idx = (idx + 1) % emps;
            }
            // Note: search trong ma trận nếu nhân viên > 3 ca trong một ngày thì thay bằng nhân viên ko có trong ngày đó

            for (int i = 0; i < shifts; i++)
            {
                for (int j = 0; j < days; j++)
                {
                    for (int k = 0; k < needed_emp; k++)
                    {
                        res[i, j, k] = shift_needed_emp[k, i, j];
                    }
                }
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Employee ID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Title");
            string[] day_of_week = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            DataTable shifts_name = this.getAllShiftsName();
            for (int i = 0; i < days; i++)
            {
                dt.Columns.Add(day_of_week[i]);
            }

            /*for (var i = 0; i < shifts; ++i)
            {
                DataRow row = dt.NewRow();
                for (var j = 0; j < days; ++j)
                {

                    for (var k = 0; k < needed_emp - 1; k++)
                    {
                        row[j] += res[i, j, k].ToString() + ", ";
                    }
                    row[j] += res[i, j, needed_emp - 1].ToString();
                }
                dt.Rows.Add(row);
            }*/
            
            for(var i = 0; i < dt_empInfo.Rows.Count; i++)
            {
                DataRow row = dt.NewRow();
                for(var j = 0; j < dt_empInfo.Columns.Count; j++)
                {
                    row[j] = dt_empInfo.Rows[i][j];
                }
                for (var k = 0; k < shifts; k++)
                {
                    for (var l = 4; l < days + 4; l++)
                    {
                        for (var m = 0; m < needed_emp; m++)
                        {
                            if (res[k, l - 4, m].ToString() == dt_empInfo.Rows[i]["emp_id"].ToString())
                                row[l] = shift_name;
                                        //(shifts_name.Rows[k][0].ToString() + "\n");
                                        // shift_name
                        }
                        
                    }
                }
                dt.Rows.Add(row);
            }
            com.Parameters.Clear();
            return dt;
        }
    }
}
