using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ComboBox_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ket_noi_csdl();
            this.Title = ket_noi_csdl().Rows[0]["matKhau"].ToString();
        }



           
        
                
           

       


       

        string chuoiketnoi = "Data Source=DESKTOP-O0VE9MN;Initial Catalog=formDangNhap;Integrated Security=True";
        
         DataTable ket_noi_csdl() 
        {

            DataTable data = new DataTable();
            string truyvan = "select * from nguoiDung";
            SqlConnection conect = new SqlConnection(chuoiketnoi);
            conect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(truyvan, chuoiketnoi);
            adapter.Fill(data);
            combobox1.ItemsSource = data.DefaultView;
            combobox2.ItemsSource = data.DefaultView;
            combobox1.DisplayMemberPath = "tenDangNhap";
            combobox2.DisplayMemberPath = "matKhau";
            conect.Close();
            return data;


        }

        private void combobox1_GotFocus(object sender, RoutedEventArgs e)
        {
            int index = combobox1.Items.IndexOf(combobox1.SelectedValue);
            combobox2.SelectedIndex = index;
        }
    }














}
