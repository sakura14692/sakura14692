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
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;
using System.Threading;

namespace quan_ly_tai_chinh_kinh_doanh
{
    public partial class form_Main_tai_chinh_Kinh_doanh : DevExpress.XtraEditors.XtraForm
    {
        public form_Main_tai_chinh_Kinh_doanh()
        {
            InitializeComponent();
           
        }
        //{*******Giao diện hệ thống********************************************************************************
      
        ImageCollection img;
        public string chuoiketnoi = "Data Source=DESKTOP-O0VE9MN;Initial Catalog=Quan_ly_Tai_chinh_Kinh_doanh;Integrated Security=True";

        public DataTable Load_index()
        {

            DataTable data = new DataTable();
            string truyvan = "select * from giao_dien";
            SqlConnection conection = new SqlConnection(chuoiketnoi);
            conection.Open(); conection.Close();
            SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
            adapter.Fill(data);
            return data;



        }


        int lay_index;
        public void Tu_dong_Load_giao_dien() 
        {

            ImageCollection img;
            img = new ImageCollection();
            string skinName;
            imageComboBoxEdit_Giao_dien_Cai_dat_He_thong.Properties.SmallImages = img;
            lay_index = int.Parse(Load_index().Rows[0]["lay_index"].ToString());

            for (int i = 0; i < SkinManager.Default.Skins.Count; i++)
            {
                
                skinName = SkinManager.Default.Skins[i].SkinName;

                img.AddImage(SkinCollectionHelper.GetSkinIcon(skinName, SkinIconsSize.Small), skinName);
                imageComboBoxEdit_Giao_dien_Cai_dat_He_thong.Properties.Items.Add(new ImageComboBoxItem(skinName, i, i));
                if (skinName == Properties.Settings.Default.theme)
                {
                    imageComboBoxEdit_Giao_dien_Cai_dat_He_thong.SelectedIndex = i;
                }

            }



            imageComboBoxEdit_Giao_dien_Cai_dat_He_thong.SelectedIndex = lay_index;

            skinName = SkinManager.Default.Skins[lay_index].SkinName;
            //img.AddImage(SkinCollectionHelper.GetSkinIcon(skinName, SkinIconsSize.Small), skinName);
            //imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem(skinName, 1, 1));
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle(skinName);



        }




        public void luu_giao_dien()
        {

            DataTable data = new DataTable();
            string truyvan = "update giao_dien set lay_index=" + imageComboBoxEdit_Giao_dien_Cai_dat_He_thong.SelectedIndex + "";
            SqlConnection conection = new SqlConnection(chuoiketnoi);
            conection.Open(); conection.Close();
            SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
            adapter.Fill(data);

        }





        private void form_Main_tai_chinh_Kinh_doanh_Load(object sender, EventArgs e)
        {
            Tu_dong_Load_giao_dien();

        }




        private void imageComboBoxEdit_Giao_dien_Cai_dat_He_thong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageComboBoxEdit edit = sender as ImageComboBoxEdit;
            simpleButton1.Text = "Hệ thống đang sử dụng giao diện [ " + edit.Text + " ] với index: " + edit.SelectedIndex.ToString(); ;

            string giao_dien = edit.Text;
            defaultLookAndFeel1.LookAndFeel.SetSkinStyle(giao_dien);
            Properties.Settings.Default.theme = giao_dien;
            Properties.Settings.Default.Save();

            luu_giao_dien();
        }


        ///**********************************************************************************************************}
        




        ///{***********************Đây là nơi load form lên form chính ***************************************************


        private void panelControl_Dau_tu_DoubleClick(object sender, EventArgs e)
        {
            form_Load_csdl_Dau_tu dau_Tu = new form_Load_csdl_Dau_tu();
            dau_Tu.TopLevel = false;
            panelControl_Dau_tu.Controls.Add(dau_Tu);
            dau_Tu.Show();
        }


        ///**********************************************************************************************************************}







        ///{***********************Đây là các chức năng bổ trợ****************************************************************





        private void form_Main_tai_chinh_Kinh_doanh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();


        }

        

        ///***********************************************************************************************************************








    }
}