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
using System.ComponentModel;

namespace Pages_Demo
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

        }

        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

            Page1 p1 = new Page1();
            this.NavigationService.Navigate(p1);

            Page2 p2 = new Page2();
            this.NavigationService.Navigate(p2);
        }
    }
}
