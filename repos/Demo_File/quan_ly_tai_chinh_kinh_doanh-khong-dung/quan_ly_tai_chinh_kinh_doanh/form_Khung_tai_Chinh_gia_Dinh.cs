using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_tai_chinh_kinh_doanh
{
    public partial class form_Khung_tai_Chinh_gia_Dinh : DevExpress.XtraEditors.XtraForm
    {
        public form_Khung_tai_Chinh_gia_Dinh()
        {
            InitializeComponent();
        }

        private void simpleButton_Thu_nhap_Gia_dinh_Click(object sender, EventArgs e)
        {
            form_Load_csdl_Thu_nhap_Gia_dinh thu_Nhap_gia_Dinh = new form_Load_csdl_Thu_nhap_Gia_dinh();
            thu_Nhap_gia_Dinh.TopLevel = false;
            panelControl_Khung_tai_Chinh_gia_Dinh.Controls.Add(thu_Nhap_gia_Dinh);
            thu_Nhap_gia_Dinh.Show();
        }

        private void simpleButton_Chi_tieu_Gia_dinh_Click(object sender, EventArgs e)
        {
            form_Load_csdl_Chi_tieu_Gia_dinh chi_Tieu_Gia_Dinh = new form_Load_csdl_Chi_tieu_Gia_dinh();
            chi_Tieu_Gia_Dinh.TopLevel = false;
            panelControl_Khung_tai_Chinh_gia_Dinh.Controls.Add(chi_Tieu_Gia_Dinh);
            chi_Tieu_Gia_Dinh.Show();
        }

        private void simpleButton_Quy_gia_dinh_Click(object sender, EventArgs e)
        {
            form_Load_csdl_Quy_gia_Dinh quy_Gia_Dinh = new form_Load_csdl_Quy_gia_Dinh();
            quy_Gia_Dinh.TopLevel = false;
            panelControl_Khung_tai_Chinh_gia_Dinh.Controls.Add(quy_Gia_Dinh);
            quy_Gia_Dinh.Show();
        }

        private void simpleButton_Tai_khoan_chung_Click(object sender, EventArgs e)
        {
            form_Load_csdl_Tai_khoan_Chung tai_Khoan_Chung = new form_Load_csdl_Tai_khoan_Chung();
            tai_Khoan_Chung.TopLevel = false;
            panelControl_Khung_tai_Chinh_gia_Dinh.Controls.Add(tai_Khoan_Chung);
            tai_Khoan_Chung.Show();
        }
    }
}