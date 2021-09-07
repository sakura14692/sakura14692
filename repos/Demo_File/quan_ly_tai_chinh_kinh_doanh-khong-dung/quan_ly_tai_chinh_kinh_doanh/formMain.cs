using DevExpress.XtraBars;
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
    public partial class form_Main_quan_ly_tai_chinh_kinh_doanh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public form_Main_quan_ly_tai_chinh_kinh_doanh()
        {
            InitializeComponent();
        }

        private void barButtonItem_Admin_ItemClick(object sender, ItemClickEventArgs e)
        {
            form_Khung_Admin admin = new form_Khung_Admin();
            admin.TopLevel = false;
            panelControl_form_Main.Controls.Add(admin);
            admin.Show();

          
        }

        private void barButtonItem_cai_dat_he_thong_ItemClick(object sender, ItemClickEventArgs e)
        {
            form_Khung_Cai_dat_He_thong cai_Dat_He_Thong = new form_Khung_Cai_dat_He_thong();
            cai_Dat_He_Thong.TopLevel = false;
            panelControl_form_Main.Controls.Add(cai_Dat_He_Thong);
            cai_Dat_He_Thong.Show();
        }

        private void barButtonItem_kinh_doanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            formKhung_Kinh_doanh khung_Kinh_Doanh = new formKhung_Kinh_doanh();
            khung_Kinh_Doanh.TopLevel = false;
            panelControl_form_Main.Controls.Add(khung_Kinh_Doanh);
            khung_Kinh_Doanh.Show();
        }

        private void barButtonItem_tai_chinh_gia_dinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            form_Khung_tai_Chinh_gia_Dinh tai_Chinh_Gia_Dinh = new form_Khung_tai_Chinh_gia_Dinh();
            tai_Chinh_Gia_Dinh.TopLevel = false;
            panelControl_form_Main.Controls.Add(tai_Chinh_Gia_Dinh);
            tai_Chinh_Gia_Dinh.Show();
        }

        private void barButtonItem_tai_chinh_ca_nhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            form_Khung_tai_Chinh_ca_Nhan tai_Chinh_Ca_Nhan = new form_Khung_tai_Chinh_ca_Nhan();
            tai_Chinh_Ca_Nhan.TopLevel = false;
            panelControl_form_Main.Controls.Add(tai_Chinh_Ca_Nhan);
            tai_Chinh_Ca_Nhan.Show();
        }
    }
}