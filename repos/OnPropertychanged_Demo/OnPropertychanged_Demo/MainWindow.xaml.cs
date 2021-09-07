using OnPropertychanged_Demo.ViewModels;
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

namespace OnPropertychanged_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModels Main = new MainViewModels();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Main;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            Main.SetBackground(Brushes.Red);
        }

            

        private void BlueClick(object sender, RoutedEventArgs e)
        {

        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {

        }
    }

        
    }
