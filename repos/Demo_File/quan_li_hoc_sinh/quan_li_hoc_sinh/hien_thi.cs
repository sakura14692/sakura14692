using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh_quanli_hocsinh
{
   public class hien_thi
    {

        public hien_thi()
        {
            ketnoi = new ket_noi();


        }
        ket_noi ketnoi;
        public string truyvan;
        public SqlConnection conection;
        SqlDataAdapter adapter;








        public DataTable table_hocsinh()
        {

            DataTable data = new DataTable();
            truyvan = "select * from hocsinh";
            conection = ketnoi.ketnoi();
            conection.Open(); conection.Close();
            adapter = new SqlDataAdapter(truyvan, conection);
            adapter.Fill(data);
            return data;



        }











    }



















}


