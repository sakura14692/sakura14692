using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh_quanli_hocsinh
{
   public class ket_noi
    {
        public string chuoiketnoi = "Data Source=DESKTOP-O0VE9MN;Initial Catalog=quanlihocsinh;Integrated Security=True";

        public SqlConnection ketnoi()
        {
            SqlConnection conection = new SqlConnection(chuoiketnoi);
            return conection;

        }


    }
}
