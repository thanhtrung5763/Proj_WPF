using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class ManageSchedulesForm : Form
    {
        public ManageSchedulesForm()
        {
            InitializeComponent();
        }
        Shift shift = new Shift();
        Schedule schedule = new Schedule();
        Employee emp = new Employee();
        MY_DB mydb = new MY_DB();
        private void ManageSchedulesForm_Load(object sender, EventArgs e)
        {
            reloadShiftsForm();
        }
        void reloadShiftsForm()
        {
            this.ParentForm.Width = 1000;
            this.ParentForm.Height = 500;
            shifts_DGV.DataSource = shift.getAllShifts();
            shifts_DGV.ReadOnly = true;
            shifts_DGV.AllowUserToAddRows = false;
            shifts_DGV.Columns[0].HeaderText = "ID";
            shifts_DGV.Columns[1].HeaderText = "Shift Name";
            shifts_DGV.Columns[2].HeaderText = "Time Start";
            shifts_DGV.Columns[3].HeaderText = "Time End";
            shifts_DGV.Columns[2].DefaultCellStyle.Format = "hh\\:mm";
            shifts_DGV.Columns[3].DefaultCellStyle.Format = "hh\\:mm";
            shifts_DGV.Columns[4].HeaderText = "No.Manager";
            shifts_DGV.Columns[5].HeaderText = "No.Receptionist";
            shifts_DGV.Columns[6].HeaderText = "No.Janitor";
            if (shifts_DGV.Rows.Count > 0)
            {
                shifts_DGV_CellMouseClick(null, null);
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
                this.ParentForm.Width = 1280;
                this.ParentForm.Height = 500;

                schedule_DGV.DataSource = schedule.getScheduleInfo();
                schedule_DGV.Columns[0].HeaderText = "Schedule ID";
                schedule_DGV.Columns[1].HeaderText = "Date Start";
                schedule_DGV.Columns[2].HeaderText = "Date End";
                schedule_DGV.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                schedule_DGV.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                schedule_DGV.ReadOnly = true;
                schedule_DGV.AllowUserToAddRows = false;
                if (schedule_DGV.Rows.Count > 0)
                    schedule_DGV_CellClick(null, null);
            }
            else
            {
                this.ParentForm.Width = 1000;
                this.ParentForm.Height = 500;
            }
        }
        
        private void schedule_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int schedule_id = int.Parse(schedule_DGV.CurrentRow.Cells[0].Value.ToString());
            schedules_DGV.DataSource = schedule.getScheduleAllInfo(schedule_id);
            schedules_DGV.Columns[0].HeaderText = "Employee ID";
            schedules_DGV.Columns[1].HeaderText = "First Name";
            schedules_DGV.Columns[2].HeaderText = "Last Name";
            schedules_DGV.Columns[3].HeaderText = "Title";
            schedules_DGV.Columns[4].HeaderText = "Monday";
            schedules_DGV.Columns[5].HeaderText = "Tuesday";
            schedules_DGV.Columns[6].HeaderText = "Wednesday";
            schedules_DGV.Columns[7].HeaderText = "Thursday";
            schedules_DGV.Columns[8].HeaderText = "Friday";
            schedules_DGV.Columns[9].HeaderText = "Saturday";
            schedules_DGV.Columns[10].HeaderText = "Sunday";
        }

        private void add_BT_Click(object sender, EventArgs e)
        {
            string name = shiftName_TB.Text;
            TimeSpan time_start = TimeSpan.Parse(timeStart_TB.Text);
            TimeSpan time_end = TimeSpan.Parse(timeEnd_TB.Text);
            int no_manager = Convert.ToInt32(manage_CBO.Text);
            int no_recept = Convert.ToInt32(recept_CBO.Text);
            int no_janitor = Convert.ToInt32(janitor_CBO.Text);
            shift.addShift(name, time_start, time_end, no_manager, no_recept, no_janitor);
            shifts_DGV.DataSource = shift.getAllShifts();
        }

        private void del_BT_Click(object sender, EventArgs e)
        {
            string name = shiftName_TB.Text;
            shift.delShift(name);
            shifts_DGV.DataSource = shift.getAllShifts();
        }

        private void edit_BT_Click(object sender, EventArgs e)
        {
            string name = shiftName_TB.Text;
            TimeSpan time_start = TimeSpan.Parse(timeStart_TB.Text);
            TimeSpan time_end = TimeSpan.Parse(timeEnd_TB.Text);
            int no_manager = Convert.ToInt32(manage_CBO.Text);
            int no_recept = Convert.ToInt32(recept_CBO.Text);
            int no_janitor = Convert.ToInt32(janitor_CBO.Text);
            shift.editShift(name, time_start, time_end, no_manager, no_recept, no_janitor);
            shifts_DGV.DataSource = shift.getAllShifts();
        }

        private void shifts_DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            shiftName_TB.Text = shifts_DGV.CurrentRow.Cells[1].Value.ToString();
            timeStart_TB.Text = shifts_DGV.CurrentRow.Cells[2].FormattedValue.ToString();
            timeEnd_TB.Text = shifts_DGV.CurrentRow.Cells[3].FormattedValue.ToString();
            manage_CBO.Text = shifts_DGV.CurrentRow.Cells[4].Value.ToString();
            recept_CBO.Text = shifts_DGV.CurrentRow.Cells[5].Value.ToString();
            janitor_CBO.Text = shifts_DGV.CurrentRow.Cells[6].Value.ToString();
        }

        private void showSchedule_BT_Click(object sender, EventArgs e)
        {
            automaticShiftForm frm = new automaticShiftForm();

            frm.Show();
        }
    }
}
