using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using QuanLyCongDan.DBClass;

namespace QuanLyCongDan
{
    /// <summary>
    /// Interaction logic for CongDan.xaml
    /// </summary>
    public partial class CongDan : Window
    {
        CongDanDAO cdDao = new CongDanDAO();
        public CongDan()
        {
            InitializeComponent();
        }

        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            login logIn = new login();
            Close();
            logIn.Show();
        }

        private void dtg_ThongTin_Loaded(object sender, RoutedEventArgs e)
        {
            cdDao.HienThiThongTin(dtg_ThongTin);
        }

        private void dtg_Thue_Loaded(object sender, RoutedEventArgs e)
        {
            cdDao.HienThiThue(dtg_Thue);
        }

        private void dtg_Tamtru_Loaded(object sender, RoutedEventArgs e)
        {
            cdDao.HienThiTamTru(dtg_Tamtru);
        }

        private void dtg_Tamvang_Loaded(object sender, RoutedEventArgs e)
        {
            cdDao.HienThiTamVang(dtg_Tamvang);
        }

        private void dtg_Cnkh_Loaded(object sender, RoutedEventArgs e)
        {
            cdDao.HienThiHonNhan(dtg_Cnkh);
        }
        private void btn_Them_ThongTin_Click(object sender, RoutedEventArgs e)
        {
            ThongTinCongDan congDan = new ThongTinCongDan(txt_tt_hoten.Text, txt_tt_gioitinh.Text, txt_tt_cccd.Text, Convert.ToDateTime(dtp_tt_ngaysinh.Text.Trim()).Date, txt_tt_noisinh.Text, txt_tt_honnhan.Text, txt_tt_quoctich.Text,
                txt_tt_dantoc.Text, txt_tt_tongiao.Text, txt_tt_thuongtru.Text, txt_tt_quequan.Text, txt_tt_diachi.Text, txt_tt_sdt.Text, txt_tt_email.Text);
            cdDao.ThemThongTin(congDan);
            dtg_ThongTin_Loaded(sender, e);
        }

        private void dtg_ThongTin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dtg_ThongTin.SelectedIndex.ToString() != null)
            {
                DataRowView rowView = (DataRowView)dtg_ThongTin.SelectedItem;
                if (rowView != null)
                {
                    txt_tt_cccd.Text = rowView[2].ToString();
                    txt_tt_dantoc.Text = rowView[7].ToString();
                    txt_tt_diachi.Text = rowView[11].ToString();
                    txt_tt_email.Text = rowView[13].ToString();
                    txt_tt_gioitinh.Text = rowView[1].ToString();
                    txt_tt_honnhan.Text = rowView[5].ToString();
                    txt_tt_hoten.Text = rowView[0].ToString();
                    txt_tt_noisinh.Text = rowView[4].ToString();
                    txt_tt_quequan.Text = rowView[10].ToString();
                    txt_tt_quoctich.Text = rowView[6].ToString();
                    txt_tt_sdt.Text = rowView[12].ToString();
                    txt_tt_thuongtru.Text = rowView[9].ToString();
                    txt_tt_tongiao.Text = rowView[8].ToString();
                    dtp_tt_ngaysinh.Text = rowView[3].ToString();
                }
            }    
        }

        private void btn_Xoa_ThongTin_Click(object sender, RoutedEventArgs e)
        {
            ThongTinCongDan congDan = new ThongTinCongDan(txt_tt_hoten.Text, txt_tt_gioitinh.Text, txt_tt_cccd.Text, Convert.ToDateTime(dtp_tt_ngaysinh.Text.Trim()).Date, txt_tt_noisinh.Text, txt_tt_honnhan.Text, txt_tt_quoctich.Text,
                txt_tt_dantoc.Text, txt_tt_tongiao.Text, txt_tt_thuongtru.Text, txt_tt_quequan.Text, txt_tt_diachi.Text, txt_tt_sdt.Text, txt_tt_email.Text);
            cdDao.XoaThongTin(congDan);
            dtg_ThongTin_Loaded(sender, e);
        }

        private void btn_Sua_ThongTin1_Click(object sender, RoutedEventArgs e)
        {
            ThongTinCongDan congDan = new ThongTinCongDan(txt_tt_hoten.Text, txt_tt_gioitinh.Text, txt_tt_cccd.Text, Convert.ToDateTime(dtp_tt_ngaysinh.Text.Trim()).Date, txt_tt_noisinh.Text, txt_tt_honnhan.Text, txt_tt_quoctich.Text,
                txt_tt_dantoc.Text, txt_tt_tongiao.Text, txt_tt_thuongtru.Text, txt_tt_quequan.Text, txt_tt_diachi.Text, txt_tt_sdt.Text, txt_tt_email.Text);
            cdDao.SuaThongTin(congDan);
            dtg_ThongTin_Loaded(sender, e);
        }
    }
}
