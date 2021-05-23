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
    public partial class ManageRoomByReceptForm : Form
    {
        public ManageRoomByReceptForm()
        {
            InitializeComponent();
        }
        Room room = new Room();

        private void ManageRoomByReceptForm_Load(object sender, EventArgs e)
        {
            reloadManageRoomsForm();

        }
        void reloadManageRoomsForm()
        {
            room_DGV.DataSource = room.getAllRooms();
            room_DGV.ReadOnly = true;
            room_DGV.AllowUserToAddRows = false;
            room_DGV.Columns[0].HeaderText = "Room ID";
            room_DGV.Columns[1].HeaderText = "Name";
            room_DGV.Columns[2].HeaderText = "Capacity";
            room_DGV.Columns[3].HeaderText = "Bed";
            room_DGV.Columns[4].HeaderText = "Price";
            room_DGV.Columns[5].HeaderText = "Status";

            roomType_CBO.DataSource = room.getRoomType();
            roomType_CBO.DisplayMember = "room_type_name";
            roomType_CBO.ValueMember = "room_type_id";
        }
        private void roomType_CBO_SelectedValueChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)roomType_CBO.SelectedItem;

            int room_type_id = Convert.ToInt32(drv.Row[1]);
            DataTable dt = room.getInfoRoomByType(room_type_id);
            capacity_TB.Text = dt.Rows[0]["room_capacity"].ToString();
            bed_TB.Text = dt.Rows[0]["room_num_beds"].ToString();
            price_TB.Text = dt.Rows[0]["room_price"].ToString();
        }
        private void room_DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            roomType_CBO.Text = room_DGV.CurrentRow.Cells[1].Value.ToString();
        }

        private void chgStat_BT_Click(object sender, EventArgs e)
        {
            if(room_DGV.CurrentRow.Cells[5].Value.ToString() == "Empty")
            {
                room.updateStatus(Convert.ToInt32(room_DGV.CurrentRow.Cells[0].Value), true);
            }
            else
            {
                room.updateStatus(Convert.ToInt32(room_DGV.CurrentRow.Cells[0].Value), false);
            }
            reloadManageRoomsForm();
        }
    }
}
