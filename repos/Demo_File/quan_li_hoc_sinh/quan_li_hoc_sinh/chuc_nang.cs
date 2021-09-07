using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh_quanli_hocsinh
{
   public class chuc_nang
    {


        ket_noi ketnoi = new ket_noi();
        public string truyvan;
        public SqlConnection conection;
        SqlDataAdapter adapter;




        public int ma_ID;
        public string mahocsinh;
        public string tenhocsinh;
        public string ngaysinh;
        public string gioitinh;
        public string timkiem;


        public string Mahocsinh
        {
            get { return mahocsinh; }
            set { mahocsinh = value; }

        }


        public string Tenhocsinh
        {
            get { return tenhocsinh; }
            set { tenhocsinh = value; }
        }

        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }


        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public int Ma_ID
        {
            get { return ma_ID; }
            set { ma_ID = value; }

        }

        public string Timkiem
        {
            get { return timkiem; }
            set { timkiem = value; }

        }


        
       public chuc_nang(string mahocsinh,string tenhocsinh,string ngaysinh,string gioitinh,int ma_ID,string timkiem) 
        {

            this.mahocsinh = mahocsinh;
            this.tenhocsinh = tenhocsinh;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.ma_ID = ma_ID;
            this.timkiem = timkiem;
        
        }

       

        public void inserthocsinh()
        {

            try
            {
                DataTable data = new DataTable();
                truyvan = "insert into hocsinh(mhs,ths,ns,gt) values ('" + mahocsinh + "',N'" + tenhocsinh + @"','" + ngaysinh + "',N'" + gioitinh + @"')";
                conection = ketnoi.ketnoi();
                conection.Open(); conection.Close();
                adapter = new SqlDataAdapter(truyvan, conection);
                adapter.Fill(data);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra!,\nXin vui lòng kiểm tra lại thông tin", "Thông báo");

            }


        }


        public void updatehocsinh()
        {

            DataTable data = new DataTable();
            truyvan = "update hocsinh set mhs='" + mahocsinh + "',ths=N'" + tenhocsinh + @"',ns='" + ngaysinh + "',gt='" + gioitinh + "' where id='" + ma_ID + "'   ";
            conection = ketnoi.ketnoi();
            conection.Open(); conection.Close();
            adapter = new SqlDataAdapter(truyvan, conection);
            adapter.Fill(data);




        }








        public void deletehocsinh()
        {

            DataTable data = new DataTable();
            truyvan = "delete hocsinh where mhs='" + mahocsinh + "' ";
            conection = ketnoi.ketnoi();
            conection.Open(); conection.Close();
            adapter = new SqlDataAdapter(truyvan, conection);
            adapter.Fill(data);



        }




        public DataTable timkiem_hocsinh()
        {

            DataTable data = new DataTable();
            truyvan = "select * from hocsinh where mhs like '%" + timkiem + "%' or ths like N'%" + timkiem + "%' ";
            conection = ketnoi.ketnoi();
            conection.Open(); conection.Close();
            adapter = new SqlDataAdapter(truyvan, conection);
            adapter.Fill(data);

            return data;

        }





    }
}
