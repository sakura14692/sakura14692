using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testdulieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = tablehocsinh();

        }

        DataTable tablehocsinh()
        {
            string chuoiketnoi = @"Data Source=DESKTOP-O0VE9MN;Initial Catalog=formDangNhap;Integrated Security=True";
            DataTable data = new DataTable();
            string truyvan = "select * from NguoiDung";
            using (SqlConnection conection = new SqlConnection(chuoiketnoi)) 
            {
                conection.Open(); conection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(truyvan,conection);
                adapter.Fill(data);
                
            
            
            
            }





                return data;
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {











        }
    }

















    
}
