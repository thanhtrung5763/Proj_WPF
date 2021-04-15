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
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        private void ManageRoomsForm_Load(object sender, EventArgs e)
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

        private void add_BT_Click(object sender, EventArgs e)
        {
            int room_type_id = Convert.ToInt32(roomType_CBO.SelectedValue);
            bool status_id = false;
            room.insertRoom(room_type_id, status_id);
            room_DGV.DataSource = room.getAllRooms();
        }

        private void delete_BT_Click(object sender, EventArgs e)
        {
            int room_id = Convert.ToInt32(room_DGV.CurrentRow.Cells[0].Value);
            string status_name = Convert.ToString(room_DGV.CurrentRow.Cells[5].Value);
            try
            {
                if (status_name == "Empty")
                {
                    room.delRoom(room_id);
                }
                else
                {
                    MessageBox.Show("Cannot Delete This Room!", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                reloadManageRoomsForm();
            }
        }

        private void showRoomType_BT_Click(object sender, EventArgs e)
        {
            ManageRoomTypesForm frm = new ManageRoomTypesForm();
            frm.TopLevel = false;

            panelMngRoom.Controls.Clear();
            panelMngRoom.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
