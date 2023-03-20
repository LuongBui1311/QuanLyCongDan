using MaterialDesignColors;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyCongDan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            login logIn = new login();
            Close();
            logIn.Show();
        }

        private void btn_CongDan_Click(object sender, RoutedEventArgs e)
        {
            CongDan congDan = new CongDan();
            Close();
            congDan.Show();
        }
    }
}
