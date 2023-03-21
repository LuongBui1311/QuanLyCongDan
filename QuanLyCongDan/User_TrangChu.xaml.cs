using MaterialDesignThemes.Wpf;
using System;
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
    /// Interaction logic for User_TrangChu.xaml
    /// </summary>
    public partial class User_TrangChu : Window
    {
        public User_TrangChu()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();
        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();

            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }
        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            login logIn = new login();
            logIn.Show();
            Close();
        }

        private void btn_User_CongDan_Click(object sender, RoutedEventArgs e)
        {
            User_CongDan ucd = new User_CongDan();
            ucd.Show();
            Close();
        }

        private void btn_User_QuanLyDon_Click(object sender, RoutedEventArgs e)
        {
            User_QuanLyDon uqld = new User_QuanLyDon();
            uqld.Show();
            Close();
        }
    }
}
