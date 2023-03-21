using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyCongDan.DBClass
{
    public class DangNhapDAO
    {
        DBConnection dbc = new DBConnection();
        public Boolean Login(DangNhap user)
        {
            string sqlStr = string.Format("SELECT *FROM DangNhap WHERE TenDangNhap = '{0}' AND MatKhau = '{1}'", user.Username, user.Password);
            if (dbc.KetQuaDangNhap(sqlStr).Rows.Count > 0)
            {
                login login = new login();
                MainWindow mainWindow = new MainWindow();
                login.Close();
                mainWindow.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
                return false;
            }
        }
    }
}
