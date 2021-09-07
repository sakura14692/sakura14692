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



namespace KetNoiCSDL_Entity_FrameWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            hien_thi();
        }

        string chuoiketnoi = "Data Source=DESKTOP-O0VE9MN;Initial Catalog=formDangNhap;Integrated Security=true";

        public void hien_thi() 
        {
            DataTable data = new DataTable();
            string truyvan = "select * from nguoiDung";
            SqlConnection connect = new SqlConnection(chuoiketnoi);
            connect.Open();connect.Close();
            SqlDataAdapter apdapter = new SqlDataAdapter(truyvan,connect);
            apdapter.Fill(data);
            test_ketnoi_csdl.ItemsSource=data.DefaultView;
            
        
        
        }





    }
}
