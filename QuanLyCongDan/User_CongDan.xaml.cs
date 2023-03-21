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
    /// Interaction logic for User_CongDan.xaml
    /// </summary>
    public partial class User_CongDan : Window
    {
        public User_CongDan()
        {
            InitializeComponent();
        }

        private void btn_User_TrangChu_Click(object sender, RoutedEventArgs e)
        {
            User_TrangChu utc = new User_TrangChu();
            utc.Show();
            Close();
        }
        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            login logIn = new login();
            logIn.Show();
            Close();
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

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
        private void btn_User_QuanLyDon_Click(object sender, RoutedEventArgs e)
        {
            User_QuanLyDon uqld = new User_QuanLyDon();
            uqld.Show();
            Close();
        }

        private void btn_User_TraCuu_ThongTin_Click(object sender, RoutedEventArgs e)
        {
            wrp_User_ThongTin.Visibility = Visibility.Visible;
        }
    }
}
