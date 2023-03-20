using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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
        public void ThemThongTinCongDan(ThongTinCongDan congDan)
        {
            string sqlStr = string.Format("INSERT INTO CongDan(HoTen, GioiTinh, CCCD, NgaySinh, NoiSinh, HonNhan, QuocTich, DanToc, TonGiao, ThuongTru, QueQuan, DiaChi, SDT, Email) VALUES " +
                "(N'{0}', N'{1}', '{2}', '{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', '{12}', '{13}')", 
                congDan.HoTen, congDan.GioiTinh, congDan.CCCD, congDan.NgaySinh, congDan.NoiSinh, congDan.TinhTrangHonNhan, congDan.QuocTich, congDan.DanToc, congDan.TonGiao, congDan.ThuongTru, congDan.QueQuan, congDan.DiaChi, congDan.SDT, congDan.Email);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }

        public void XoaThongTinCongDan(ThongTinCongDan congDan)
        {
            string sqlStr = string.Format("DELETE FROM CongDan WHERE CCCD = '{0}'", congDan.CCCD);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }

        public void SuaThongTinCongDan(ThongTinCongDan congDan)
        {
            string sqlStr = string.Format("UPDATE CongDan SET HoTen = N'{0}', GioiTinh = N'{1}', NgaySinh = '{2}', NoiSinh = N'{3}', HonNhan = N'{4}', QuocTich = N'{5}', DanToc = N'{6}', TonGiao = N'{7}', ThuongTru = N'{8}', QueQuan = N'{9}', DiaChi = N'{10}', SDT = '{11}', Email = '{12}' WHERE CCCD = '{13}'",
                congDan.HoTen, congDan.GioiTinh, congDan.NgaySinh, congDan.NoiSinh, congDan.TinhTrangHonNhan, congDan.QuocTich, congDan.DanToc, congDan.TonGiao, congDan.ThuongTru, congDan.QueQuan, congDan.DiaChi, congDan.SDT, congDan.Email, congDan.CCCD);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }

        public void ThemThongTinThue(Thue ttThue)
        {
            string sqlStr = string.Format("INSERT INTO Thue(Masothue, Tennguoinopthue, Coquanthue, SoCMT_CCCD, Ngaythaydoithongtingannhat) VALUES " +
                "('{0}', N'{1}', N'{2}', '{3}', '{4}')", ttThue.Masothue, ttThue.Tenguoinopthue, ttThue.Coquanthue, ttThue.SoCMT_CCCD, ttThue.Ngaythaydoithongtingannhat);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }
        public void XoaThongTinThue(Thue ttThue)
        {
            string sqlStr = string.Format("DELETE FROM Thue WHERE Masothue = '{0}'", ttThue.Masothue);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }
        public void SuaThongTinThue(Thue ttThue)
        {
            string sqlStr = string.Format("UPDATE Thue SET Tennguoinopthue = N'{0}', Coquanthue = N'{1}', SoCMT_CCCD = '{2}', Ngaythaydoithongtingannhat = '{3}' WHERE Masothue = '{4}'",
                                            ttThue.Tenguoinopthue, ttThue.Coquanthue, ttThue.SoCMT_CCCD, ttThue.Ngaythaydoithongtingannhat, ttThue.Masothue);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }
        public void ThemThongTinTamTru(TamTru tamTru)
        {
            string sqlStr = string.Format("INSERT INTO Tamtru(Ngaydk, Noidk, Hoten, Ngaysinh, Cmnd, Nccmnd, Ngccmnd, Diachitht, Diachitt, Ngayden, Ngaydi, Lydo) VALUES " +
                "('{0}', N'{1}', N'{2}', '{3}', '{4}', N'{5}', '{6}', N'{7}', N'{8}', '{9}', '{10}', N'{11}')",
                tamTru.Ngaydk, tamTru.Noidk, tamTru.Hoten, tamTru.Ngaysinh, tamTru.CCCD, tamTru.Noicapcccd, tamTru.Ngaycapcccd, tamTru.Diachitht, tamTru.Diachitt, tamTru.Ngayden, tamTru.Ngaydi, tamTru.Lydo);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }

        public void XoaThongTinTamTru(TamTru tamTru)
        {
            string sqlStr = string.Format("DELETE FROM Tamtru WHERE Cmnd = '{0}'", tamTru.CCCD);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }

        public void SuaThongTinTamTru(TamTru tamTru)
        {
            string sqlStr = string.Format("UPDATE Tamtru SET Ngaydk = '{0}', Noidk = N'{1}', Hoten = N'{2}', Ngaysinh = '{3}', Nccmnd = N'{4}', Ngccmnd = '{5}', Diachitht = N'{6}', Diachitt = N'{7}', Ngayden = '{8}', Ngaydi = '{9}', Lydo = N'{10}' WHERE Cmnd = '{11}'",
                tamTru.Ngaydk, tamTru.Noidk, tamTru.Hoten, tamTru.Ngaysinh, tamTru.Noicapcccd, tamTru.Ngaycapcccd, tamTru.Diachitht, tamTru.Diachitt, tamTru.Ngayden, tamTru.Ngaydi, tamTru.Lydo, tamTru.CCCD);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }

        public void ThemThongTinTamVang(TamVang tamvang)
        {
            string sqlStr = string.Format("INSERT INTO TamVang(Ncdi, Ncden, Hoten, Ngaysinh, Cmnd, NcCmnd, NgcCmnd, DiaChitht, DiaChitt, Ngaydi, Ngayve, Lydo) VALUES " +
                " (N'{0}', N'{1}', N'{2}', '{3}', N'{4}', N'{5}', '{6}', N'{7}', N'{8}', '{9}', '{10}', N'{11}')",
                tamvang.noichuyendi, tamvang.noichyenden, tamvang.hovaten, tamvang.ngaysinh, tamvang.CMND, tamvang.noicapCMND, tamvang.ngaycapCMND,
                tamvang.diachithuongtru, tamvang.diachitamtru, tamvang.ngaydi, tamvang.ngayve, tamvang.lydo);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }
        public void XoaThongTinTamVang(TamVang tamvang)
        {
            string sqlStr = string.Format("DELETE FROM TAMVANG WHERE Cmnd = {0}", tamvang.CMND);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }
        public void SuaThongTinTamVang(TamVang tamvang)
        {
            string sqlStr = string.Format("UPDATE TAMVANG SET Ncdi = N'{0}', Ncden = N'{1}', Hoten = N'{2}', Ngaysinh = '{3}', NcCmnd = N'{5}', NgcCmnd = '{6}', " +
                "DiaChitht = N'{7}', DiaChitt = N'{8}', Ngaydi = '{9}', Ngayve = '{10}', Lydo = N'{11}' WHERE Cmnd = '{4}'",
                tamvang.noichuyendi, tamvang.noichyenden, tamvang.hovaten, tamvang.ngaysinh, tamvang.CMND, tamvang.noicapCMND, tamvang.ngaycapCMND,
                tamvang.diachithuongtru, tamvang.diachitamtru, tamvang.ngaydi, tamvang.ngayve, tamvang.lydo);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }

        public void ThemThongTinKetHon(Cnkh cnkh)
        {
            string sqlStr = string.Format("INSERT INTO Cnkh(Hotenvo, NgaySinhvo, Dantocvo, Quoctichvo, Noicutruvo, Giaytotuythanvo, Hotenchong, NgaySinhchong, Dantocchong, Quoctichchong, Noicutruchong, Giaytotuythanchong, Noidk, Ngaydk) VALUES " +
                " (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}')",
                cnkh.hotenvo, cnkh.ngaysinhvo, cnkh.dantocvo, cnkh.quoctichvo, cnkh.noicutruvo, cnkh.gtttvo, cnkh.hotenchong, cnkh.ngaysinhchong, cnkh.dantocchong, cnkh.quoctichchong, cnkh.noicutruchong, cnkh.gtttchong,
                cnkh.noidkkh, cnkh.ngaydkkh);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }
        public void XoaThongTinKetHon(Cnkh cnkh)
        {
            string sqlStr = string.Format("DELETE FROM Cnkh Where HotenVo = N'{0}' AND HotenChong = N'{1}'",
                cnkh.hotenvo, cnkh.hotenchong);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }
        public void SuaThongTinKetHon(Cnkh cnkh)
        {
            string sqlStr = string.Format("UPDATE Cnkh SET NgaySinhvo = N'{1}', Dantocvo = N'{2}', Quoctichvo = N'{3}', Noicutruvo = N'{4}', Giaytotuythanvo = N'{5}', NgaySinhchong = N'{7}', Dantocchong = N'{8}', Quoctichchong = N'{9}', Noicutruchong = N'{10}', Giaytotuythanchong = N'{11}', Noidk = N'{12}', Ngaydk = N'{13}' WHERE HoTenVo = N'{0}' AND HoTenChong = N'{6}'",
                cnkh.hotenvo, cnkh.ngaysinhvo, cnkh.dantocvo, cnkh.quoctichvo, cnkh.noicutruvo, cnkh.gtttvo, cnkh.hotenchong, cnkh.ngaysinhchong, cnkh.dantocchong, cnkh.quoctichchong, cnkh.noicutruchong, cnkh.gtttchong,
                cnkh.noidkkh, cnkh.ngaydkkh);
            dbc.Sql_Them_Xoa_Sua(sqlStr);
        }
    }
}
