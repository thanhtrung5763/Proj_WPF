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
    public partial class ManagerScheduleJanitorForm : Form
    {
        public ManagerScheduleJanitorForm()
        {
            InitializeComponent();
        }
        Shift shift = new Shift();
        Schedule schedule = new Schedule();
        Employee emp = new Employee();
        MY_DB mydb = new MY_DB();

        private void ManagerScheduleJanitorForm_Load(object sender, EventArgs e)
        {
            this.ParentForm.Width = 1280;
            this.ParentForm.Height = 475;

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
    }
}
