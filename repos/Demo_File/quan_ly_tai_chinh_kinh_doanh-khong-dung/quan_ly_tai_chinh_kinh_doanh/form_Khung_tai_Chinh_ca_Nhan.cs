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
    public partial class form_Khung_tai_Chinh_ca_Nhan : DevExpress.XtraEditors.XtraForm
    {
        public form_Khung_tai_Chinh_ca_Nhan()
        {
            InitializeComponent();
        }

        private void simpleButton_Thu_nhap_Ca_nhan_Click(object sender, EventArgs e)
        {
            form_Load_csdl_Thu_nhap_Ca_nhan thu_Nhap_Ca_Nhan = new form_Load_csdl_Thu_nhap_Ca_nhan();
            thu_Nhap_Ca_Nhan.TopLevel = false;
            panelControl_Khung_tai_Chinh_Ca_nhan.Controls.Add(thu_Nhap_Ca_Nhan);
            thu_Nhap_Ca_Nhan.Show();
        }

        private void simpleButton_Chi_tieu_Ca_nhan_Click(object sender, EventArgs e)
        {
            form_Load_csdl_Chi_tieu_Ca_nhan chi_Tieu_Ca_Nhan = new form_Load_csdl_Chi_tieu_Ca_nhan();
            chi_Tieu_Ca_Nhan.TopLevel = false;
            panelControl_Khung_tai_Chinh_Ca_nhan.Controls.Add(chi_Tieu_Ca_Nhan);
            chi_Tieu_Ca_Nhan.Show();
        }

        private void simpleButton_Tai_khoan_Ca_Nhan_Click(object sender, EventArgs e)
        {
            form_Load_tai_Khoan_ca_Nhan tai_Khoan_Ca_Nhan = new form_Load_tai_Khoan_ca_Nhan();
            tai_Khoan_Ca_Nhan.TopLevel = false;
            panelControl_Khung_tai_Chinh_Ca_nhan.Controls.Add(tai_Khoan_Ca_Nhan);
            tai_Khoan_Ca_Nhan.Show();
            
        }

        private void simpleButton_Quy_ca_Nhan_Click(object sender, EventArgs e)
        {
            form_Load_csdl_Quy_ca_Nhan quy_Ca_Nhan = new form_Load_csdl_Quy_ca_Nhan();
            quy_Ca_Nhan.TopLevel = false;
            panelControl_Khung_tai_Chinh_Ca_nhan.Controls.Add(quy_Ca_Nhan);
            quy_Ca_Nhan.Show();
        }
    }
}