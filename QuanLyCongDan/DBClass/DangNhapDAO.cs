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
        public void Login(DangNhap user)
        {
            string sqlStr = string.Format("SELECT *FROM DangNhap WHERE TenDangNhap = '{0}' AND MatKhau = '{1}'", user.Username, user.Password);
            if (dbc.KetQuaDangNhap(sqlStr) == 1)   
            {
                login login = new login();
                login.Close();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

            }
            if (dbc.KetQuaDangNhap(sqlStr)  == 2)
            {
                login login = new login();
                login.Close();
                User_TrangChu utc = new User_TrangChu();
                utc.Show();
            }
            if (dbc.KetQuaDangNhap(sqlStr) == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
            }    
        }
    }
}
