using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class automaticShiftForm : Form
    {
        public automaticShiftForm()
        {
            InitializeComponent();
        }
        Shift shift = new Shift();
        Schedule schedule = new Schedule();
        Employee emp = new Employee();
        MY_DB mydb = new MY_DB();
        private DataTable scheduleByShift(int shift_id, int no_manager, int no_recept, int no_janitor, int idx_start_mng, int idx_start_recept, int idx_start_janitor)
        {
            DataTable dt = shift.getInfoShiftById(shift_id);
            string shift_name = Convert.ToString(dt.Rows[0]["shift_name"]);
            int no_manager_need = Convert.ToInt32(dt.Rows[0]["num_manager"]);

            int no_recept_need = Convert.ToInt32(dt.Rows[0]["num_receptionist"]);
            int no_janitor_need = Convert.ToInt32(dt.Rows[0]["num_janitor"]);
            dt = new DataTable();
            // Xếp lịch cho manager, receptionist, janitor
            dt.Merge(shift.automaticShift("Manager", no_manager_need, no_manager, shift_name, idx_start_mng));
            dt.Merge(shift.automaticShift("Receptionist", no_recept_need, no_recept, shift_name, idx_start_recept));
            dt.Merge(shift.automaticShift("Janitor", no_janitor_need, no_janitor, shift_name, idx_start_janitor));
            return dt;
        }
        private void automaticShiftForm_Load(object sender, EventArgs e)
        {
            datestart_DTP.Format = DateTimePickerFormat.Custom;
            datestart_DTP.CustomFormat = "dd/MM/yyyy";
            dateend_DTP.Format = DateTimePickerFormat.Custom;
            dateend_DTP.CustomFormat = "dd/MM/yyyy";
            automaticShiftReload();
        }
        void automaticShiftReload()
        {
            // ***This code below for Manage Shifts TabPage***
            DataTable shift_result = new DataTable();
            int idx_start_mng = -1;
            int idx_start_recept = -1;
            int idx_start_janitor = -1;
            // Số ca làm
            int no_shift = shift.numOfShift();
            // Lấy ra slnv là Manager, Receptionist, Janitor

            int no_manager = emp.countEmployeesByTitle("Manager");

            int no_recept = emp.countEmployeesByTitle("Receptionist");

            int no_janitor = emp.countEmployeesByTitle("Janitor");

            for (int shift_id = 1; shift_id <= no_shift; shift_id++)
            {
                idx_start_mng = (idx_start_mng + 1) % (no_manager);
                idx_start_recept = (idx_start_recept + 1) % (no_recept);
                idx_start_janitor = (idx_start_janitor + 1) % (no_janitor);
                shift_result.Merge(scheduleByShift(shift_id, no_manager, no_recept, no_janitor, idx_start_mng, idx_start_recept, idx_start_janitor));
            }

            automaticShift_DGV.DataSource = shift_result;


            automaticShift_DGV.ReadOnly = true;
            automaticShift_DGV.AllowUserToAddRows = false;
        }
        private void add2_BT_Click(object sender, EventArgs e)
        {
            int schedule_id = schedule.numOfSchedule() + 1;
            int shift_id = 1;
            for (int i = 0; i < automaticShift_DGV.Rows.Count; i++)
            {
                if ((i + 1) % emp.numOfEmployees() == 0)
                    shift_id += 1;
                int emp_id = Convert.ToInt32(automaticShift_DGV.Rows[i].Cells["Employee ID"].Value);
                string firstname = automaticShift_DGV.Rows[i].Cells["First Name"].Value.ToString();
                string lastname = automaticShift_DGV.Rows[i].Cells["Last Name"].Value.ToString();
                string title = automaticShift_DGV.Rows[i].Cells["Title"].Value.ToString();
                string Monday = automaticShift_DGV.Rows[i].Cells["Monday"].Value.ToString();
                string Tuesday = automaticShift_DGV.Rows[i].Cells["Tuesday"].Value.ToString();
                string Wednesday = automaticShift_DGV.Rows[i].Cells["Wednesday"].Value.ToString();
                string Thursday = automaticShift_DGV.Rows[i].Cells["Thursday"].Value.ToString();
                string Friday = automaticShift_DGV.Rows[i].Cells["Friday"].Value.ToString();
                string Saturday = automaticShift_DGV.Rows[i].Cells["Saturday"].Value.ToString();
                string Sunday = automaticShift_DGV.Rows[i].Cells["Sunday"].Value.ToString();
                schedule.addSchedule(schedule_id, shift_id, emp_id, firstname, lastname, title, datestart_DTP.Value, dateend_DTP.Value,
                                    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday);
            }
        }

        private void cancel_BT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
