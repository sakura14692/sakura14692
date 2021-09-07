using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_tai_chinh_kinh_doanh
{
    public partial class form_Load_csdl_Dau_tu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public form_Load_csdl_Dau_tu()
        {
            InitializeComponent();
         

        }




        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///                                        Đây là code để phát tín hiệu đến form kinh doanh


        IPEndPoint ipe;
        Stream stream;
        TcpClient tcpClient;
        string tinHieu = "Đầu tư";
        private void form_Load_csdl_Dau_tu_Click(object sender, EventArgs e)
        {

            tinHieu = tinHieu + "";
            send();
           

        }

        private void form_Load_csdl_Dau_tu_Load(object sender, EventArgs e)
        {

            Control.CheckForIllegalCrossThreadCalls = false;
            connect();

        }


        public void connect()
        {

            ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            tcpClient = new TcpClient();
            tcpClient.Connect(ipe);
            stream = tcpClient.GetStream();
            Thread recv = new Thread(receive);
            recv.IsBackground = true;
            recv.Start();


        }

        public void send()
        {

            byte[] data = Encoding.UTF8.GetBytes(tinHieu);
            stream.Write(data, 0, data.Length);

        }


        public void receive()
        {
            while (true)

            {

                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                string s = Encoding.UTF8.GetString(recv);

            }
        }



         /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////































       













    }
}

        
    
