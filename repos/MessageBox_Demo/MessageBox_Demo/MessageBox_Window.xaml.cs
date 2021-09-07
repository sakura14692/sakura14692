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

namespace MessageBox_Demo
{
    /// <summary>
    /// Interaction logic for MessageBox_Window.xaml
    /// </summary>
    public partial class MessageBox_Window : Window
    {
        public MessageBox_Window()
        {
            InitializeComponent();
           

        }

        public delegate void truyen_gia_tri_giua_cac_window(bool parameter);
        public event truyen_gia_tri_giua_cac_window nut_yes, nut_no;
   


        public void Show_Message(string message) 
        {
            this.Show();

            nhan_Lenh.Text = message;
          

        }

        

        private void nut_Yes_Click(object sender, RoutedEventArgs e)
        {
            nut_yes(true);
            
          
        }

        private void nut_No_Click(object sender, RoutedEventArgs e)
        {
            nut_no(true);
        }
    }
}
