using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class form_Load_csdl_Ke_toan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public form_Load_csdl_Ke_toan()
        {
            InitializeComponent();
        }

        private void form_Load_csdl_Ke_toan_Click(object sender, EventArgs e)
        {

           
            send();

        }

        private void form_Load_csdl_Ke_toan_Load(object sender, EventArgs e)
        {

            Control.CheckForIllegalCrossThreadCalls = false;
            connect();

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
        string tinHieu = "Kế toán";









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
