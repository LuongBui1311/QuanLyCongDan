﻿using System;
using System.Collections.Generic;
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

namespace QuanLyCongDan
{
    /// <summary>
    /// Interaction logic for QuanLyDon.xaml
    /// </summary>
    public partial class QuanLyDon : Window
    {
        public QuanLyDon()
        {
            InitializeComponent();
        }

        private void btn_TrangChu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
        }

        private void btn_CongDan_Click(object sender, RoutedEventArgs e)
        {
            CongDan congDan = new CongDan();
            Close();
            congDan.Show();
        }

        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            login login = new login();
            Close();
            login.Show();
        }
    }
}
