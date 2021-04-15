using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*ManagerForm mngForm = new ManagerForm();
            mngForm.ShowDialog();
*/
            LoginForm logForm = new LoginForm();
            if (logForm.ShowDialog() == DialogResult.OK)
            {
                logForm.menu_role();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
