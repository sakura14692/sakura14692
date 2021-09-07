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

namespace Truyen_gia_tri_giua_cac_Form
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public delegate void Login(string username, string password);
        public event Login LoginEvent;

        public Window1()
        {
            InitializeComponent();
           
        }

        string strNhan;
        public string Message
        {
            get { return strNhan; }
            set { strNhan = value; }
        }

        private void form2_Loaded(object sender, RoutedEventArgs e)
        {
            tb_nhan_string.Text = strNhan;
           
            
        }

        

        

        private void bt_co_Click(object sender, RoutedEventArgs e)
        {
            string username = "có";
            string password = "có";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Wrong username or password", "Error",
                MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (LoginEvent != null)
            {
                LoginEvent(username, password);
                this.Close();
            }
            else
            {
                // LoginEvent hasn't called in Form1
                this.Close();
            }
        }
    }
    
}
