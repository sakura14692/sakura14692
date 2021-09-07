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


namespace dataGrid_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            table_matkhau();
            
        }

        

        public void table_matkhau()
        {
            string chuoiketnoi = "Data Source=DESKTOP-O0VE9MN;Initial Catalog=formDangNhap;Integrated Security=True";
            DataTable data = new DataTable();
            string truyvan = "select * from NguoiDung";
            using (SqlConnection conection = new SqlConnection(chuoiketnoi))
            {
                conection.Open(); conection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                adapter.Fill(data);




            }

           







        }


        








    }
}
