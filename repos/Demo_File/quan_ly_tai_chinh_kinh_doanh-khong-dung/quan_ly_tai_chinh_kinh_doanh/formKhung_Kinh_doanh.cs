using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace quan_ly_tai_chinh_kinh_doanh
{
    public partial class formKhung_Kinh_doanh : DevExpress.XtraEditors.XtraForm
    {
        public formKhung_Kinh_doanh()
        {
            InitializeComponent();
           

   


        }






        private void simpleButton_dau_tu_Click(object sender, EventArgs e)
        {
            form_Load_csdl_Dau_tu form_Load_Dau_tu = new form_Load_csdl_Dau_tu();
            form_Load_Dau_tu.TopLevel = false;
            panelControl_Khung_Kinh_doanh.Controls.Add(form_Load_Dau_tu);
            labelControl_Nhan_tin_Hieu_va_Dieu_khien.Text = "Đầu tư";//sửa lỗi tên nút và tên label điều khiển không giống nhau
            form_Load_Dau_tu.Show();

           

            //Thay đổi màu sắc lúc nhấn vào

            simpleButton_dau_tu.ForeColor = Color.SeaGreen;
            simpleButton_doi_tac.ForeColor = Color.MediumSlateBlue;
            simpleButton_ke_toan.ForeColor = Color.MediumSlateBlue;


            simpleButton_dau_tu.Focus();


            
        
        }

        private void simpleButton_doi_tac_Click(object sender, EventArgs e)
        {

            form_Load_csdl_Doi_tac form_Load_Doi_tac = new form_Load_csdl_Doi_tac();
            form_Load_Doi_tac.TopLevel = false;
            panelControl_Khung_Kinh_doanh.Controls.Add(form_Load_Doi_tac);
            labelControl_Nhan_tin_Hieu_va_Dieu_khien.Text = "Đối tác";//sửa lỗi tên nút và tên label điều khiển không giống nhau
            form_Load_Doi_tac.Show();


            //Thay đổi màu sắc lúc nhấn vào
            simpleButton_dau_tu.ForeColor = Color.MediumSlateBlue;
            simpleButton_doi_tac.ForeColor = Color.SeaGreen;
            simpleButton_ke_toan.ForeColor = Color.MediumSlateBlue;



            simpleButton_doi_tac.Focus();
        }

        private void simpleButton_ke_toan_Click(object sender, EventArgs e)
        {

            form_Load_csdl_Ke_toan form_Load_Ke_toan = new form_Load_csdl_Ke_toan();
            form_Load_Ke_toan.TopLevel = false;
            panelControl_Khung_Kinh_doanh.Controls.Add(form_Load_Ke_toan);
            labelControl_Nhan_tin_Hieu_va_Dieu_khien.Text = "Kế toán";//sửa lỗi tên nút và tên label điều khiển không giống nhau
            form_Load_Ke_toan.Show();

            //Thay đổi màu sắc lúc nhấn vào

            simpleButton_dau_tu.ForeColor = Color.MediumSlateBlue;
            simpleButton_doi_tac.ForeColor = Color.MediumSlateBlue;
            simpleButton_ke_toan.ForeColor = Color.SeaGreen;




            simpleButton_ke_toan.Focus();
        }








        /// <summary>
        /// Đếm số lượng form đang mở,có thể áp dụng cho controls khác
        /// </summary>
        /// <param name="a"></param>

        void dem_Ribbon_form(int a)
        {
            
            foreach (var ctrl in panelControl_Khung_Kinh_doanh.Controls)
            {
                if (ctrl is RibbonForm && ((RibbonForm)ctrl).Created)
                {
                    a++;
                    form_Load_csdl_Dau_tu f = new form_Load_csdl_Dau_tu();
                    
                 

                }

            }

          labelControl_dem_Form.Text="Bạn đang mở "+a+" cửa sổ";
            
            if (a == 0 )
            {
                simpleButton_dau_tu.ForeColor = Color.MediumSlateBlue;
                simpleButton_doi_tac.ForeColor = Color.MediumSlateBlue;
                simpleButton_ke_toan.ForeColor = Color.MediumSlateBlue;
                labelControl_Nhan_tin_Hieu_va_Dieu_khien.Text = "";
            }

        }
        



        private void panelControl_Khung_Kinh_doanh_ControlRemoved(object sender, ControlEventArgs e)
        {

            dem_Ribbon_form(0);
        }

        

        private void panelControl_Khung_Kinh_doanh_ControlAdded(object sender, ControlEventArgs e)
        {
            dem_Ribbon_form(1);
        }











        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        ///                                      Khu vực nhận tín hiệu

        private void formKhung_Kinh_doanh_Load(object sender, EventArgs e)
        {

            Control.CheckForIllegalCrossThreadCalls = false;
            connect();

 

        }



        IPEndPoint ipe;
        Socket Client;
        
        TcpListener tcplisten;
        string tin_hieu="ok";




        /// //////////// Tạm thời chưa dùng đến
        private void formKhung_Kinh_doanh_Click(object sender, EventArgs e) 
        {
            send(Client);
        }

        //Hàm kết nối
        void connect()
        {
            ipe = new IPEndPoint(IPAddress.Any,9999);
            tcplisten = new TcpListener(ipe);

           

            Thread thread = new Thread
                (() =>
                {
                    while (true)
                    {
                        tcplisten.Start();
                        Client = tcplisten.AcceptSocket();
                        Thread rec = new Thread(receive);
                      
                        rec.IsBackground = true;
                        rec.Start(Client);
                        
                    }

                }

                );

            thread.IsBackground = true;
            thread.Start();
        }


        void send(Socket client)
        {
            byte[] data = Encoding.UTF8.GetBytes(tin_hieu);
            client.Send(data);

        }
        string s;/// Dữ liệu gửi đến
        /// 
        /// </summary>
        /// <param name="obj"></param>
        void receive(object obj)
        {
            while (true)
            {
                Socket client = obj as Socket;
                byte[] recv = new byte[1024];
                client.Receive(recv);
                s = Encoding.UTF8.GetString(recv);
                labelControl_Nhan_tin_Hieu_va_Dieu_khien.Text = s;
              
                
                
                

               

            }

            


        }

       
        


        private void labelControl_Nhan_tin_Hieu_va_Dieu_khien_TextChanged(object sender, EventArgs e)
        {
            ////////////////////// Phân tích tín hiệu và ra lệnh
            if (labelControl_Nhan_tin_Hieu_va_Dieu_khien.Text == "Đầu tư")
            {
                simpleButton_dau_tu.ForeColor = Color.SeaGreen;
                simpleButton_doi_tac.ForeColor = Color.MediumSlateBlue;
                simpleButton_ke_toan.ForeColor = Color.MediumSlateBlue;
            }

            if (labelControl_Nhan_tin_Hieu_va_Dieu_khien.Text == "Đối tác")
            {

                simpleButton_dau_tu.ForeColor = Color.MediumSlateBlue;
                simpleButton_doi_tac.ForeColor = Color.SeaGreen;
                simpleButton_ke_toan.ForeColor = Color.MediumSlateBlue;

            }

            if (labelControl_Nhan_tin_Hieu_va_Dieu_khien.Text == "Kế toán")
            {

                simpleButton_dau_tu.ForeColor = Color.MediumSlateBlue;
                simpleButton_doi_tac.ForeColor = Color.MediumSlateBlue;
                simpleButton_ke_toan.ForeColor = Color.SeaGreen;

            }


        }






        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




























    }
}