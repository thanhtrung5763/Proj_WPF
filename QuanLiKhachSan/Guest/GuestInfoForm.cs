using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class GuestInfoForm : Form
    {
        public GuestInfoForm()
        {
            InitializeComponent();
        }
        Guest guest = new Guest();
        private void GuestInfoForm_Load(object sender, EventArgs e)
        {
            cin_DTP.Format = DateTimePickerFormat.Custom;
            cin_DTP.CustomFormat = "dd/MM/yyyy";
            cout_DTP.Format = DateTimePickerFormat.Custom;
            cout_DTP.CustomFormat = "dd/MM/yyyy";

            DataTable dt = guest.getInfoGuestByRoom(Globals.GlobalRoomId);
            usernameT2_TB.Text = dt.Rows[0][1].ToString();
            passwordT2_TB.Text = dt.Rows[0][2].ToString();
            guestID_TB.Text = dt.Rows[0][0].ToString();
            fnameT2_TB.Text = dt.Rows[0][3].ToString();
            lnameT2_TB.Text = dt.Rows[0][4].ToString();
            phoneT2_TB.Text = dt.Rows[0][5].ToString();
            cin_DTP.Value = DateTime.ParseExact(DateTime.Parse(dt.Rows[0][7].ToString()).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            cout_DTP.Value = DateTime.ParseExact(DateTime.Parse(dt.Rows[0][8].ToString()).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            byte[] pic;
            pic = (byte[])dt.Rows[0][6];
            MemoryStream picture = new MemoryStream(pic);
            photoT2_PB.Image = Image.FromStream(picture);
        }
    }
}
