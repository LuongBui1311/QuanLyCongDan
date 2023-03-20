﻿using System;
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
            cdDao.ThemThongTinCongDan(congDan);
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
            cdDao.XoaThongTinCongDan(congDan);
            dtg_ThongTin_Loaded(sender, e);
        }

        private void btn_Sua_ThongTin1_Click(object sender, RoutedEventArgs e)
        {
            ThongTinCongDan congDan = new ThongTinCongDan(txt_tt_hoten.Text, txt_tt_gioitinh.Text, txt_tt_cccd.Text, Convert.ToDateTime(dtp_tt_ngaysinh.Text.Trim()).Date, txt_tt_noisinh.Text, txt_tt_honnhan.Text, txt_tt_quoctich.Text,
                txt_tt_dantoc.Text, txt_tt_tongiao.Text, txt_tt_thuongtru.Text, txt_tt_quequan.Text, txt_tt_diachi.Text, txt_tt_sdt.Text, txt_tt_email.Text);
            cdDao.SuaThongTinCongDan(congDan);
            dtg_ThongTin_Loaded(sender, e);
        }

        private void btn_Them_Thue_Click(object sender, RoutedEventArgs e)
        {
            Thue ttThue = new Thue(txt_thue_masothue.Text, txt_thue_nguoinopthue.Text, txt_thue_coquanthue.Text, txt_thue_cccd.Text, Convert.ToDateTime(dtp_thue_ngaythaydoi.Text.Trim()).Date);
            cdDao.ThemThongTinThue(ttThue);
            dtg_Thue_Loaded(sender, e);
        }

        private void btn_Xoa_Thue_Click(object sender, RoutedEventArgs e)
        {
            Thue ttThue = new Thue(txt_thue_masothue.Text, txt_thue_nguoinopthue.Text, txt_thue_coquanthue.Text, txt_thue_cccd.Text, Convert.ToDateTime(dtp_thue_ngaythaydoi.Text.Trim()).Date);
            cdDao.XoaThongTinThue(ttThue);
            dtg_Thue_Loaded(sender, e);
        }

        private void btn_Sua_Thue_Click(object sender, RoutedEventArgs e)
        {
            Thue ttThue = new Thue(txt_thue_masothue.Text, txt_thue_nguoinopthue.Text, txt_thue_coquanthue.Text, txt_thue_cccd.Text, Convert.ToDateTime(dtp_thue_ngaythaydoi.Text.Trim()).Date);
            cdDao.SuaThongTinThue(ttThue);
            dtg_Thue_Loaded(sender, e);
        }

        private void dtg_Thue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtg_Thue.SelectedIndex.ToString() != null)
            {
                DataRowView rowView = (DataRowView)dtg_Thue.SelectedItem;
                if (rowView != null)
                {
                    txt_thue_masothue.Text = rowView[0].ToString();
                    txt_thue_nguoinopthue.Text = rowView[1].ToString();
                    txt_thue_coquanthue.Text = rowView[2].ToString();
                    txt_thue_cccd.Text = rowView[3].ToString();
                    dtp_thue_ngaythaydoi.Text = rowView[4].ToString();
                }
            }
        }

        private void btn_Them_Tamtru_Click(object sender, RoutedEventArgs e)
        {
            TamTru tamTru = new TamTru(Convert.ToDateTime(dtp_tamtru_ngaydk.Text.Trim()).Date, txt_tamtru_noidk.Text, txt_tamtru_hoten.Text, Convert.ToDateTime(dtp_tamtru_ngaysinh.Text.Trim()).Date, txt_tamtru_cccd.Text, txt_tamtru_noicapcccd.Text,
                                        Convert.ToDateTime(dtp_tamtru_ngaycapcccd.Text.Trim()).Date, txt_tamtru_diachitht.Text, txt_tamtru_diachitt.Text, Convert.ToDateTime(dtp_tamtru_ngayden.Text.Trim()).Date, Convert.ToDateTime(dtp_tamtru_ngaydi.Text.Trim()).Date, txt_tamtru_lydo.Text);
            cdDao.ThemThongTinTamTru(tamTru);
            dtg_Tamtru_Loaded(sender, e);
        }

        private void dtg_Tamtru_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtg_Tamtru.SelectedIndex.ToString() != null)
            {
                DataRowView rowView = (DataRowView)dtg_Tamtru.SelectedItem;
                if (rowView != null)
                {
                    dtp_tamtru_ngaydk.Text = rowView[0].ToString();
                    txt_tamtru_noidk.Text = rowView[1].ToString();
                    txt_tamtru_hoten.Text = rowView[2].ToString();
                    dtp_tamtru_ngaysinh.Text = rowView[3].ToString();
                    txt_tamtru_cccd.Text = rowView[4].ToString();
                    txt_tamtru_noicapcccd.Text = rowView[5].ToString();
                    dtp_tamtru_ngaycapcccd.Text = rowView[6].ToString();
                    txt_tamtru_diachitht.Text = rowView[7].ToString();
                    txt_tamtru_diachitt.Text = rowView[8].ToString();
                    dtp_tamtru_ngayden.Text = rowView[9].ToString();
                    dtp_tamtru_ngaydi.Text = rowView[10].ToString();
                    txt_tamtru_lydo.Text = rowView[11].ToString();
                }
            }
        }

        private void btn_Xoa_Tamtru_Click(object sender, RoutedEventArgs e)
        {
            TamTru tamTru = new TamTru(Convert.ToDateTime(dtp_tamtru_ngaydk.Text.Trim()).Date, txt_tamtru_noidk.Text, txt_tamtru_hoten.Text, Convert.ToDateTime(dtp_tamtru_ngaysinh.Text.Trim()).Date, txt_tamtru_cccd.Text, txt_tamtru_noicapcccd.Text,
                                        Convert.ToDateTime(dtp_tamtru_ngaycapcccd.Text.Trim()).Date, txt_tamtru_diachitht.Text, txt_tamtru_diachitt.Text, Convert.ToDateTime(dtp_tamtru_ngayden.Text.Trim()).Date, Convert.ToDateTime(dtp_tamtru_ngaydi.Text.Trim()).Date, txt_tamtru_lydo.Text);
            cdDao.XoaThongTinTamTru(tamTru);
            dtg_Tamtru_Loaded(sender, e);
        }

        private void btn_Sua_Tamtru_Click(object sender, RoutedEventArgs e)
        {
            TamTru tamTru = new TamTru(Convert.ToDateTime(dtp_tamtru_ngaydk.Text.Trim()).Date, txt_tamtru_noidk.Text, txt_tamtru_hoten.Text, Convert.ToDateTime(dtp_tamtru_ngaysinh.Text.Trim()).Date, txt_tamtru_cccd.Text, txt_tamtru_noicapcccd.Text,
                                        Convert.ToDateTime(dtp_tamtru_ngaycapcccd.Text.Trim()).Date, txt_tamtru_diachitht.Text, txt_tamtru_diachitt.Text, Convert.ToDateTime(dtp_tamtru_ngayden.Text.Trim()).Date, Convert.ToDateTime(dtp_tamtru_ngaydi.Text.Trim()).Date, txt_tamtru_lydo.Text);
            cdDao.SuaThongTinTamTru(tamTru);
            dtg_Tamtru_Loaded(sender, e);
        }
    }
}
