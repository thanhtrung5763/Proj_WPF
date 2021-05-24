using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public bool verify()
        {
            if (usernameT2_TB.Text == "" |
                passwordT2_TB.Text == "" |
                fnameT2_TB.Text == "" |
                lnameT2_TB.Text == "" |
                phoneT2_TB.Text == "" |
                photoT2_PB.Image == null)
                return false;
            return true;
        }
        private void reg_BT_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                MessageBox.Show("Missing Fields. Cannot Sign Up, Please Try Again", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand com = new SqlCommand();
                SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\ProjectsV13; Initial Catalog = DB_QLKS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                int id = int.Parse(guestID_TB.Text);
                string username = usernameT2_TB.Text;
                string pass = passwordT2_TB.Text;
                string phone = phoneT2_TB.Text;
                string fname = fnameT2_TB.Text;
                string lname = lnameT2_TB.Text;
                MemoryStream picture = new MemoryStream();
                photoT2_PB.Image.Save(picture, photoT2_PB.Image.RawFormat);
                SqlCommand check_User_Name = new SqlCommand();
                check_User_Name.CommandText = "SELECT COUNT(*) FROM Guest WHERE username = @user";
                check_User_Name.Connection = conn;
                conn.Open();
                check_User_Name.Parameters.AddWithValue("@user", username);
                int UserExist = (int)check_User_Name.ExecuteScalar();
                conn.Close();
                if (UserExist > 0)
                {
                    MessageBox.Show("Your username has been used!", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    com.CommandText = "Insert into Guest(guest_id, firstname, lastname, username, password, phone, photo)" + "Values(@id, @fname, @lname, @uname, @pwd, @phn, @pic)";
                    guest.createGuest(id, fname, lname, username, pass, phone, picture, com);
                    MessageBox.Show("Your account has been created!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        Guest guest = new Guest();
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            guestID_TB.Text = (guest.getNumOfGuest() + 1).ToString();
        }

        private void chophotoT2_BT_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                photoT2_PB.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void Log_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
