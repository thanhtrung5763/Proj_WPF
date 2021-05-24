using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class BookRoomForm : Form
    {
        public BookRoomForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        Guest guest = new Guest();
        private void BookRoomForm_Load(object sender, EventArgs e)
        {
            cin_DTP.Format = DateTimePickerFormat.Custom;
            cin_DTP.CustomFormat = "dd/MM/yyyy";
            cout_DTP.Format = DateTimePickerFormat.Custom;
            cout_DTP.CustomFormat = "dd/MM/yyyy";

            DataTable dt = guest.getInfoGuest(Globals.GlobalUserId);
            guestID_TB.Text = dt.Rows[0][0].ToString();
            fnameT2_TB.Text = dt.Rows[0][3].ToString();
            lnameT2_TB.Text = dt.Rows[0][4].ToString();
            byte[] pic;
            pic = (byte[])dt.Rows[0][6];
            MemoryStream picture = new MemoryStream(pic);
            photoT2_PB.Image = Image.FromStream(picture);

            reloadDGV();
            
        }
        private void reloadDGV()
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
            room_DGV.DataSource = room.getAllRoomsByType(room_type_id);
        }

        private void room_DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (room_DGV.CurrentRow.Cells[5].Value.ToString() == "Full")
            {
                MessageBox.Show("This Room Was Booked By Some One Else. Please Choose Another Room That Empty", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                roomID_TB.Text = "";
                return;
            }
            else
                roomID_TB.Text = room_DGV.CurrentRow.Cells[0].Value.ToString();
        }
        Reservation res = new Reservation();
        private void bookRoom_BT_Click(object sender, EventArgs e)
        {
            int room_id = int.Parse(roomID_TB.Text);

            if (res.createRes(Globals.GlobalUserId, room_id, cin_DTP.Value, cout_DTP.Value))
            {

                room.updateStatus(Convert.ToInt32(room_DGV.CurrentRow.Cells[0].Value), true);
                reloadDGV();
                roomID_TB.Text = "";
                MessageBox.Show("Successful", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fail To Book", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
