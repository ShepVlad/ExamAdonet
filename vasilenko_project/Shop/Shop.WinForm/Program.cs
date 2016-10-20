using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data.SqlClient;
namespace Shop.WinForm
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
            //Application.Run(new FrmEditPhoto());
            //Application.Run(new FrmEditPhoto());
            Login frmlogin = new Login();//FrmEditPhoto

            DialogResult result = frmlogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                string login = frmlogin.txtLogin.Text;
                string password = frmlogin.txtPassword.Text;
                string conString = ConfigurationManager.ConnectionStrings["ShopContext"].ConnectionString;

                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(conString);
                sb.UserID = login;
                sb.Password = password;
                SqlConnection connect = new SqlConnection(sb.ToString());
                try
                {
                    connect.Open();

                    Application.Run(new Form1(sb.ToString()));
                }
                catch
                {
                    MessageBox.Show("Неверный логин или пароль!");
                    return;
                }
                finally
                {
                    connect.Close();
                }

            }
            else
            {
                return;
            }
        }
    }
}
