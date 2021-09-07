using System;
using System.Collections.Generic;
using System.Globalization;
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
using TaiChinh_KinhDoanh.Views;

namespace TaiChinh_KinhDoanh
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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void button_KinhDoanh_Click(object sender, RoutedEventArgs e)
        {
            UserControl1_KinhDoanh KinhDoanh = new UserControl1_KinhDoanh();
            grid_Add_UserControls.Children.Add(KinhDoanh);
            button_KinhDoanh.Background = Brushes.SlateBlue;

        

        }

        private void button_KinhDoanh_LostFocus(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
