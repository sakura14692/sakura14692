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

namespace Truyen_gia_tri_giua_cac_Form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StackPanel myStackPanel = new StackPanel();
           
            
        }

      



        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 frm = new Window1();
            // Gán nội dung textbox1 cho thuộc tính Message
            frm.Message = tb1.Text;


           
            
            frm.LoginEvent += frm2_LoginEvent;
            frm.Show();
        }

        private void frm2_LoginEvent(string username, string password)
        {
            lblInfo.Content = string.Format("Hello {0}, your password is {1}.", username, password);
            MessageBox.Show("Đã xóa!");
        }
    }
}
