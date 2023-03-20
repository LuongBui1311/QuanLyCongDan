using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using QuanLyCongDan.DBClass;

namespace QuanLyCongDan.DBClass
{
    public class CongDanDAO
    {
        DBConnection dbc = new DBConnection();
        public void HienThiThongTin(DataGrid dataGrid)
        {
            string sqlStr = "SELECT *FROM CongDan";
            dataGrid.ItemsSource = dbc.Sql_Select(sqlStr).DefaultView;
        }
        public void HienThiThue(DataGrid dataGrid)
        {
            string sqlStr = "SELECT *FROM Thue";
            dataGrid.ItemsSource = dbc.Sql_Select(sqlStr).DefaultView;
        }
        public void HienThiTamTru(DataGrid dataGrid)
        {
            string sqlStr = "SELECT *FROM Tamtru";
            dataGrid.ItemsSource = dbc.Sql_Select(sqlStr).DefaultView;
        }
        public void HienThiTamVang(DataGrid dataGrid)
        {
            string sqlStr = "SELECT *FROM Tamvang";
            dataGrid.ItemsSource = dbc.Sql_Select(sqlStr).DefaultView;
        }
        public void HienThiHonNhan(DataGrid dataGrid)
        {
            string sqlStr = "SELECT *FROM Cnkh";
            dataGrid.ItemsSource = dbc.Sql_Select(sqlStr).DefaultView;
        }
        public void ThemThongTin(ThongTinCongDan congDan)
        {
            string sqlStr = string.Format("INSERT INTO CongDan(HoTen, GioiTinh, CCCD, NgaySinh, NoiSinh, HonNhan, QuocTich, DanToc, TonGiao, ThuongTru, QueQuan, DiaChi, SDT, Email) VALUES " +
                "(N'{0}', N'{1}', '{2}', '{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', '{12}', '{13}')", 
                congDan.HoTen, congDan.GioiTinh, congDan.CCCD, congDan.NgaySinh, congDan.NoiSinh, congDan.TinhTrangHonNhan, congDan.QuocTich, congDan.DanToc, congDan.TonGiao, congDan.ThuongTru, congDan.QueQuan, congDan.DiaChi, congDan.SDT, congDan.Email);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }

        internal void XoaThongTin(ThongTinCongDan congDan)
        {
            string sqlStr = string.Format("DELETE FROM CongDan WHERE CCCD = '{0}'", congDan.CCCD);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }

        internal void SuaThongTin(ThongTinCongDan congDan)
        {
            string sqlStr = string.Format("UPDATE CongDan SET HoTen = N'{0}', GioiTinh = N'{1}', NgaySinh = '{2}', NoiSinh = N'{3}', HonNhan = N'{4}', QuocTich = N'{5}', DanToc = N'{6}', TonGiao = N'{7}', ThuongTru = N'{8}', QueQuan = N'{9}', DiaChi = N'{10}', SDT = '{11}', Email = '{12}' WHERE CCCD = '{13}'",
                congDan.HoTen, congDan.GioiTinh, congDan.NgaySinh, congDan.NoiSinh, congDan.TinhTrangHonNhan, congDan.QuocTich, congDan.DanToc, congDan.TonGiao, congDan.ThuongTru, congDan.QueQuan, congDan.DiaChi, congDan.SDT, congDan.Email, congDan.CCCD);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }
    }
}
