using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace MessageBox_Demo
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

        MediaPlayer m = new MediaPlayer();
        

       


        private void gui_lenh_Click(object sender, RoutedEventArgs e)
        {
            MessageBox_Window mesage = new MessageBox_Window();
            mesage.Show_Message("Bạn có muốn nghe nhạc không ?");

            mesage.nut_yes += Mesage_nut_yes;
            mesage.nut_no += Mesage_nut_no;
            OpenFileDialog a = new OpenFileDialog();
           // a.ShowDialog();

            
            

        }

        private void Mesage_nut_no(bool la_nut_No)
        {
            Nhan_Phan_Hoi.Text = "Đã nhận phản hồi từ nút NO";

        }

        private void Mesage_nut_yes(bool la_nut_Yes)
        {
            Nhan_Phan_Hoi.Text = "Đã nhận phản hồi từ nút Yes";
            m.Open(new Uri(@"C:\Users\user\source\repos\MessageBox_Demo\MessageBox_Demo\luu_thanh_cong.mp3"));
            m.Play();
        }
    }
}
