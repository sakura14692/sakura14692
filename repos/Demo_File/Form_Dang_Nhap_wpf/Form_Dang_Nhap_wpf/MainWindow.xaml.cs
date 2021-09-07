using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using MahApps;
using System.Security.Cryptography;

namespace Form_Dang_Nhap_wpf_
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


        public bool text_Box_isNotNull()
        {

            if (string.IsNullOrEmpty(textBox_Ten_Dang_Nhap.Text))
            {
                MessageBox.Show("Bạn phải [Điền tên đăng nhập]", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                textBox_Ten_Dang_Nhap.Focus();
                return false;
            }
            else

            if (string.IsNullOrEmpty(textBox_Mat_Khau.Password))
            {
                MessageBox.Show("Bạn phải nhập [Mật khẩu]", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                textBox_Mat_Khau.Focus();
                return false;
            }
            else 
            {
                
                byte[] ma_hoa_mat_khau = ASCIIEncoding.ASCII.GetBytes(textBox_Mat_Khau.Password);
                byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(ma_hoa_mat_khau);
                var list = hashData.ToString();
                list.Reverse();
                
                string chuoiketnoi = "Data Source=DESKTOP-O0VE9MN;Initial Catalog=formDangNhap;Integrated Security=True";
                DataTable data = new DataTable();
                string truyvan = "select * from NguoiDung where tenDangNhap='"+textBox_Ten_Dang_Nhap.Text+"' and matKhau='"+textBox_Mat_Khau.Password+"'";
                using (SqlConnection conection = new SqlConnection(chuoiketnoi))
                {
                    conection.Open(); conection.Close();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                    adapter.Fill(data);




                }
                if (data.Rows.Count > 0)
                {
                    MessageBox.Show("Bạn đã [Đăng nhập] thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);


                }
                else 
                {
                    MessageBox.Show("[Đăng nhập] thất bại! xin vui lòng kiểm tra lại thông tin", 
                    "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    textBox_Ten_Dang_Nhap.Text = "Tên đăng nhập";
                    textBox_Mat_Khau.Password = "Mật khẩu";
                }

               
            }


            return true;
        }



        private void Di_Chuyen_Form(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();

        }

        private void Button_Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Dang_NHap_Click(object sender, RoutedEventArgs e)
        {
            text_Box_isNotNull();

        }

        private void textBox_Ten_Dang_Nhap_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox_Ten_Dang_Nhap.Text = null;
        }

        private void textBox_Mat_Khau_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox_Mat_Khau.Password =null;
        }
    }
}
