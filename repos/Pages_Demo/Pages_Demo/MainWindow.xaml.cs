using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Pages_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Page1 p1 = new Page1();
            MainFrame.NavigationService.Navigate(p1);
           
           

        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (MainFrame.NavigationService.CanGoBack) 
            {
                MainFrame.NavigationService.GoBack();
                bt_quay_lai.Background = Brushes.White;
            }
               

            else bt_quay_lai.Background = Brushes.Gray;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (MainFrame.NavigationService.CanGoForward)
                MainFrame.NavigationService.GoForward();
            else bt_di_den.Background = Brushes.Gray;
        }

       
    }
}
