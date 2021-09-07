using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaiChinh_KinhDoanh.Views.message_Box;
using TaiChinh_KinhDoanh.Views.PhuTro;

namespace TaiChinh_KinhDoanh.Views.TrangChu
{
    /// <summary>
    /// Interaction logic for UserControl_KinhDoanh.xaml
    /// </summary>
    public partial class UserControl_KinhDoanh : UserControl
    {
        public UserControl_KinhDoanh()
        {
            InitializeComponent();

            var fullpath = System.IO.Path.GetFullPath("chuoi_ket_noi.txt");
            if (File.Exists(fullpath))
            {
                string doc_file = File.ReadAllText(fullpath);
                chuoiketnoi = doc_file;
            }

            Tong_so_tien_thu_vao();
            Tong_so_tien_chi_ra();
            textbox_quan_ly_quy_dau_tu_So_du_hien_tai.Text = (Tong_so_tien_thu_vao() - Tong_so_tien_chi_ra()).ToString();


          


        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            button_du_an_da_trien_khai_Luu.Background = Brushes.DarkSlateGray;
            button_du_an_da_trien_khai_Huy.Background = Brushes.DarkSlateGray;
            button_du_an_da_trien_khai_Luu.IsEnabled = false;
            button_du_an_da_trien_khai_Huy.IsEnabled = false;
            button_du_an_da_trien_khai_Luu.Opacity = 0.5;
            button_du_an_da_trien_khai_Huy.Opacity = 0.5;



            button_ke_hoach_cho_du_an_moi_Luu.Background = Brushes.DarkSlateGray;
            button_ke_hoach_cho_du_an_moi_Huy.Background = Brushes.DarkSlateGray;
            button_ke_hoach_cho_du_an_moi_Luu.IsEnabled = false;
            button_ke_hoach_cho_du_an_moi_Huy.IsEnabled = false;
            button_ke_hoach_cho_du_an_moi_Luu.Opacity = 0.5;
            button_ke_hoach_cho_du_an_moi_Huy.Opacity = 0.5;


            button_quan_ly_thong_tin_doi_tac_Luu.Background = Brushes.DarkSlateGray;
            button_thong_tin_doi_tac_Huy.Background = Brushes.DarkSlateGray;
            button_quan_ly_thong_tin_doi_tac_Luu.IsEnabled = false;
            button_thong_tin_doi_tac_Huy.IsEnabled = false;
            button_quan_ly_thong_tin_doi_tac_Luu.Opacity = 0.5;
            button_thong_tin_doi_tac_Huy.Opacity = 0.5;

            thong_tin_doi_dac();
            thong_tin_du_an_da_trien_khai();
            xay_dung_ke_hoach_cho_du_an_moi();


        }







        string chuoiketnoi;
        string flag = "";














        //******** Khu vực của Thông tin dự án đã triển khai***********************************************



        public DataTable thong_tin_du_an_da_trien_khai()
        {


            DataTable data = new DataTable();
            try 
            {
                string truyvan = "select * from thong_tin_du_an_da_trien_khai";

                using (SqlConnection conection = new SqlConnection(chuoiketnoi))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                    adapter.Fill(data);

                    conection.Close();

                    listview_Thong_tin_du_an_da_trien_khai.ItemsSource = data.DefaultView;


                }


            }
            catch (Exception ex) 
            {
                string message = ex.Message;
                MessageBox.Show(message,"Lỗi",MessageBoxButton.OK,MessageBoxImage.Error);
            }
           

            return data;
        }




        public DataTable Them_thong_tin_du_an_da_trien_khai()
        {
            string datepicker = datepicker_thong_tin_du_an_da_trien_khai.SelectedDate.Value.ToString();
            string chon_ngay = datepicker.Replace("12:00:00 AM", null);

            DataTable data = new DataTable();

            try
            {

                string truyvan = "exec them_du_an @ma_du_an =''," +
               "@ten_du_an=N'" + textbox_du_an_da_trien_khai_Ten_du_an.Text + "'," +
               "@ngay_khoi_cong = '" + chon_ngay + "'," +
               "@so_san_pham = " + int.Parse(textbox_du_an_da_trien_khai_So_san_pham.Text) + "," +
               "@ten_san_pham = N'" + textbox_du_an_da_trien_khai_Ten_san_pham.Text + "'," +
               "@so_von = " + int.Parse(textbox_du_an_da_trien_khai_So_von.Text) + "," +
               "@loi_nhuan = " + int.Parse(textbox_du_an_da_trien_khai_Loi_nhuan.Text) + "," +
               "@doanh_thu = " + int.Parse(textbox_du_an_da_trien_khai_Doanh_thu.Text) + " ";

                using (SqlConnection conection = new SqlConnection(chuoiketnoi))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                    adapter.Fill(data);

                    conection.Close();

                    listview_Thong_tin_du_an_da_trien_khai.ItemsSource = data.DefaultView;


                }


            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           

            return data;

        }



        public DataTable Sua_thong_tin_du_an_da_trien_khai()
        {


            string datepicker = datepicker_thong_tin_du_an_da_trien_khai.SelectedDate.Value.ToString();
            string chon_ngay = datepicker.Replace("12:00:00 AM", null);

            DataTable data = new DataTable();

            try
            {

                string truyvan = "update thong_tin_du_an_da_trien_khai set  ten_du_an = N'" + textbox_du_an_da_trien_khai_Ten_du_an.Text + "'," +
               "ngay_khoi_cong = '" + chon_ngay + "'," +
               "so_san_pham = " + int.Parse(textbox_du_an_da_trien_khai_So_san_pham.Text) + "," +
               "ten_san_pham = N'" + textbox_du_an_da_trien_khai_Ten_san_pham.Text + "'," +
               "so_von = " + int.Parse(textbox_du_an_da_trien_khai_So_von.Text) + "," +
               "loi_nhuan = " + int.Parse(textbox_du_an_da_trien_khai_Loi_nhuan.Text) + "," +
               "doanh_thu = " + int.Parse(textbox_du_an_da_trien_khai_Doanh_thu.Text) + " where ma_du_an = '" + textbox_du_an_da_trien_khai_Ma_du_an.Text + "' ";

                SqlConnection conection = new SqlConnection(chuoiketnoi);
                conection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                adapter.Fill(data);

                conection.Close();

                listview_Thong_tin_du_an_da_trien_khai.ItemsSource = data.DefaultView;

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           



            return data;
        }




        public DataTable Xoa_thong_tin_du_an_da_trien_khai()
        {



            DataTable data = new DataTable();


            try
            {
                string truyvan = "delete thong_tin_du_an_da_trien_khai where ma_du_an = '" + textbox_du_an_da_trien_khai_Ma_du_an.Text + "' ";

                SqlConnection conection = new SqlConnection(chuoiketnoi);
                conection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                adapter.Fill(data);

                conection.Close();

                listview_Thong_tin_du_an_da_trien_khai.ItemsSource = data.DefaultView;



            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }


           

            return data;
        }


        public DataTable timkiem_du_an_da_trien_khai()
        {
           

            DataTable data = new DataTable();


            try
            {
                string truyvan = "select * from thong_tin_du_an_da_trien_khai where ma_du_an like '%" + textbox_du_an_da_trien_khai_Tim_kiem.Text+ "%' or ten_du_an like N'%" + textbox_du_an_da_trien_khai_Tim_kiem.Text + "%' ";

                SqlConnection conection = new SqlConnection(chuoiketnoi);
                conection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                adapter.Fill(data);

                conection.Close();

                listview_Thong_tin_du_an_da_trien_khai.ItemsSource = data.DefaultView;



            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }




            return data;


        }








        public void mo_textbox_va_Luu_Huy_Dong_Them_Sua_Xoa_thong_tin_du_an_da_trien_khai()
        {

           
            textbox_du_an_da_trien_khai_Ten_du_an.IsReadOnly = false;
            datepicker_thong_tin_du_an_da_trien_khai.Visibility = Visibility.Visible;
            textbox_du_an_da_trien_khai_Ngay_khoi_cong.Visibility = Visibility.Collapsed;
            textbox_du_an_da_trien_khai_Ngay_khoi_cong.IsReadOnly = false;
            textbox_du_an_da_trien_khai_So_san_pham.IsReadOnly = false;
            textbox_du_an_da_trien_khai_Ten_san_pham.IsReadOnly = false;
            textbox_du_an_da_trien_khai_So_von.IsReadOnly = false;
            textbox_du_an_da_trien_khai_Loi_nhuan.IsReadOnly = false;
            textbox_du_an_da_trien_khai_Doanh_thu.IsReadOnly = false;

            button_du_an_da_trien_khai_Luu.Background = Brushes.Transparent;
            button_du_an_da_trien_khai_Huy.Background = Brushes.Transparent;

            button_du_an_da_trien_khai_Luu.IsEnabled = true;
            button_du_an_da_trien_khai_Huy.IsEnabled = true;

            button_du_an_da_trien_khai_Luu.Opacity = 1;
            button_du_an_da_trien_khai_Huy.Opacity = 1;

            button_du_an_da_trien_khai_Them.Background = Brushes.DarkSlateGray;
            button_du_an_da_trien_khai_Sua.Background = Brushes.DarkSlateGray;
            button_thong_tin_du_an_da_trien_khai_Xoa.Background = Brushes.DarkSlateGray;

            button_du_an_da_trien_khai_Them.IsEnabled = false;
            button_du_an_da_trien_khai_Sua.IsEnabled = false;
            button_thong_tin_du_an_da_trien_khai_Xoa.IsEnabled = false;

            button_du_an_da_trien_khai_Them.Opacity = 0.5;
            button_du_an_da_trien_khai_Sua.Opacity = 0.5;
            button_thong_tin_du_an_da_trien_khai_Xoa.Opacity = 0.5;

        }





        public void dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_thong_tin_du_an_da_trien_khai()
        {

           
            textbox_du_an_da_trien_khai_Ten_du_an.IsReadOnly = true;
            datepicker_thong_tin_du_an_da_trien_khai.Visibility = Visibility.Collapsed;
            textbox_du_an_da_trien_khai_Ngay_khoi_cong.Visibility = Visibility.Visible;
            textbox_du_an_da_trien_khai_Ngay_khoi_cong.IsReadOnly = true;
            textbox_du_an_da_trien_khai_Ngay_khoi_cong.IsReadOnly = true;
            textbox_du_an_da_trien_khai_So_san_pham.IsReadOnly = true;
            textbox_du_an_da_trien_khai_Ten_san_pham.IsReadOnly = true;
            textbox_du_an_da_trien_khai_So_von.IsReadOnly = true;
            textbox_du_an_da_trien_khai_Loi_nhuan.IsReadOnly = true;
            textbox_du_an_da_trien_khai_Doanh_thu.IsReadOnly = true;

            button_du_an_da_trien_khai_Luu.Background = Brushes.DarkSlateGray;
            button_du_an_da_trien_khai_Huy.Background = Brushes.DarkSlateGray;

            button_du_an_da_trien_khai_Luu.IsEnabled = false;
            button_du_an_da_trien_khai_Huy.IsEnabled = false;

            button_du_an_da_trien_khai_Luu.Opacity = 0.5;
            button_du_an_da_trien_khai_Huy.Opacity = 0.5;

            button_du_an_da_trien_khai_Them.Background = Brushes.Transparent;
            button_du_an_da_trien_khai_Sua.Background = Brushes.Transparent;
            button_thong_tin_du_an_da_trien_khai_Xoa.Background = Brushes.Transparent;

            button_du_an_da_trien_khai_Them.IsEnabled = true;
            button_du_an_da_trien_khai_Sua.IsEnabled = true;
            button_thong_tin_du_an_da_trien_khai_Xoa.IsEnabled = true;

            button_du_an_da_trien_khai_Them.Opacity = 1;
            button_du_an_da_trien_khai_Sua.Opacity = 1;
            button_thong_tin_du_an_da_trien_khai_Xoa.Opacity = 1;


        }


        public bool textIsnotNull_thong_tin_du_an_da_trien_khai()
        {

            if (string.IsNullOrEmpty(textbox_du_an_da_trien_khai_Ten_du_an.Text))
            {
                MessageBox.Show("'Tên dự án' không được để trống", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_du_an_da_trien_khai_Ten_du_an.Focus();

                return false;
            }
            else
            if (datepicker_thong_tin_du_an_da_trien_khai.SelectedDate == null)
            {
                MessageBox.Show("'Ngày khởi công' không được để trống", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);

                return false;
            }
            else
            if (string.IsNullOrEmpty(textbox_du_an_da_trien_khai_So_san_pham.Text))
            {

                MessageBox.Show("'Số sản phẩm' không được để trống", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);

                textbox_du_an_da_trien_khai_So_san_pham.Focus();
                return false;
            }
            else
            if (string.IsNullOrEmpty(textbox_du_an_da_trien_khai_Ten_san_pham.Text))
            {

                MessageBox.Show("'Tên sản phẩm' không được để trống", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);

                textbox_du_an_da_trien_khai_Ten_san_pham.Focus();
                return false;
            }

            else
            if (string.IsNullOrEmpty(textbox_du_an_da_trien_khai_So_von.Text))
            {
                MessageBox.Show("'Số vốn' không được để trống", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);

                textbox_du_an_da_trien_khai_So_von.Focus();
                return false;
            }

            else
            if (string.IsNullOrEmpty(textbox_du_an_da_trien_khai_Loi_nhuan.Text))
            {

                MessageBox.Show("'Lợi nhuận' không được để trống", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_du_an_da_trien_khai_Loi_nhuan.Focus();

                return false;
            }

            else
            if (string.IsNullOrEmpty(textbox_du_an_da_trien_khai_Doanh_thu.Text))
            {
                MessageBox.Show("'Doanh thu' không được để trống", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);

                textbox_du_an_da_trien_khai_Doanh_thu.Focus();
                return false;
            }

            return true;
        }


        public void thong_tin_du_an_da_trien_khai_Lam_trang_textbox()
        {

            textbox_du_an_da_trien_khai_Ma_du_an.Text = "";
            textbox_du_an_da_trien_khai_Ten_du_an.Text = "";
            datepicker_thong_tin_du_an_da_trien_khai.SelectedDate = null;
            textbox_du_an_da_trien_khai_So_san_pham.Text = "";
            textbox_du_an_da_trien_khai_Ten_san_pham.Text = "";
            textbox_du_an_da_trien_khai_So_von.Text = "";
            textbox_du_an_da_trien_khai_Loi_nhuan.Text = "";
            textbox_du_an_da_trien_khai_Doanh_thu.Text = "";



        }


        public void binding_to_textbox()
        {

            Binding ma_du_an = new Binding();
            ma_du_an.Mode = BindingMode.OneWay;
            Binding ten_du_an = new Binding();
            ten_du_an.Mode = BindingMode.OneWay;
            Binding so_san_pham = new Binding();
            so_san_pham.Mode = BindingMode.OneWay;
            Binding ten_san_pham = new Binding();
            ten_san_pham.Mode = BindingMode.OneWay;
            Binding so_von = new Binding();
            so_von.Mode = BindingMode.OneWay;
            Binding loi_nhuan = new Binding();
            loi_nhuan.Mode = BindingMode.OneWay;
            Binding doanh_thu = new Binding();
            doanh_thu.Mode = BindingMode.OneWay;
            Binding ngay_khoi_cong = new Binding();
            ngay_khoi_cong.Mode = BindingMode.OneWay;

            // The source
            ma_du_an.Path = new PropertyPath("SelectedValue.[ma_du_an]");
            ma_du_an.ElementName = "listview_Thong_tin_du_an_da_trien_khai";
            ten_du_an.Path = new PropertyPath("SelectedValue.[ten_du_an]");
            ten_du_an.ElementName = "listview_Thong_tin_du_an_da_trien_khai";
            so_san_pham.Path = new PropertyPath("SelectedValue.[so_san_pham]");
            so_san_pham.ElementName = "listview_Thong_tin_du_an_da_trien_khai";
            ten_san_pham.Path = new PropertyPath("SelectedValue.[ten_san_pham]");
            ten_san_pham.ElementName = "listview_Thong_tin_du_an_da_trien_khai";
            so_von.Path = new PropertyPath("SelectedValue.[so_von]");
            so_von.ElementName = "listview_Thong_tin_du_an_da_trien_khai";
            loi_nhuan.Path = new PropertyPath("SelectedValue.[loi_nhuan]");
            loi_nhuan.ElementName = "listview_Thong_tin_du_an_da_trien_khai";
            doanh_thu.Path = new PropertyPath("SelectedValue.[doanh_thu]");
            doanh_thu.ElementName = "listview_Thong_tin_du_an_da_trien_khai";
            ngay_khoi_cong.Path = new PropertyPath("SelectedValue.[ngay_khoi_cong]");
            ngay_khoi_cong.ElementName = "listview_Thong_tin_du_an_da_trien_khai";

            // The target
            textbox_du_an_da_trien_khai_Ma_du_an.SetBinding(TextBox.TextProperty, ma_du_an);
            textbox_du_an_da_trien_khai_Ten_du_an.SetBinding(TextBox.TextProperty, ten_du_an);
            textbox_du_an_da_trien_khai_So_san_pham.SetBinding(TextBox.TextProperty, so_san_pham);
            textbox_du_an_da_trien_khai_Ten_san_pham.SetBinding(TextBox.TextProperty, ten_san_pham);
            textbox_du_an_da_trien_khai_So_von.SetBinding(TextBox.TextProperty, so_von);
            textbox_du_an_da_trien_khai_Loi_nhuan.SetBinding(TextBox.TextProperty, loi_nhuan);
            textbox_du_an_da_trien_khai_Doanh_thu.SetBinding(TextBox.TextProperty, doanh_thu);
            textbox_du_an_da_trien_khai_Ngay_khoi_cong.SetBinding(TextBox.TextProperty, ngay_khoi_cong);



        }













       








        //Listview dự án đã triển khai
        private void listview_Thong_tin_du_an_da_trien_khai_MouseEnter(object sender, MouseEventArgs e)
        {
            listview_Thong_tin_du_an_da_trien_khai.Foreground = Brushes.DarkGoldenrod;


        }

        private void listview_Thong_tin_du_an_da_trien_khai_MouseLeave(object sender, MouseEventArgs e)
        {
            listview_Thong_tin_du_an_da_trien_khai.Foreground = Brushes.DarkBlue;
        }








        //Chức năng của button dự án đã triển khai
        private void button_du_an_da_trien_khai_Them_Click(object sender, RoutedEventArgs e)
        {

            mo_textbox_va_Luu_Huy_Dong_Them_Sua_Xoa_thong_tin_du_an_da_trien_khai();

            thong_tin_du_an_da_trien_khai_Lam_trang_textbox();
            flag = "Thêm";



            button_du_an_da_trien_khai_Them.BorderBrush = Brushes.DarkGoldenrod;
            button_du_an_da_trien_khai_Sua.BorderBrush = Brushes.LightSkyBlue;
            button_thong_tin_du_an_da_trien_khai_Xoa.BorderBrush = Brushes.LightSkyBlue;
            button_du_an_da_trien_khai_Luu.BorderBrush = Brushes.LightSkyBlue;
            button_du_an_da_trien_khai_Huy.BorderBrush = Brushes.LightSkyBlue;


        }

        private void button_du_an_da_trien_khai_Sua_Click(object sender, RoutedEventArgs e)
        {



            // binding_to_textbox();

            datepicker_thong_tin_du_an_da_trien_khai.SelectedDate = null;

            flag = "Sửa";

            button_du_an_da_trien_khai_Them.BorderBrush = Brushes.LightSkyBlue;
            button_du_an_da_trien_khai_Sua.BorderBrush = Brushes.DarkGoldenrod;
            button_thong_tin_du_an_da_trien_khai_Xoa.BorderBrush = Brushes.LightSkyBlue;
            button_du_an_da_trien_khai_Luu.BorderBrush = Brushes.LightSkyBlue;
            button_du_an_da_trien_khai_Huy.BorderBrush = Brushes.LightSkyBlue;



        }





    private void button_thong_tin_du_an_da_trien_khai_Xoa_Click(object sender, RoutedEventArgs e)
        {
           
          
            if (string.IsNullOrEmpty(textbox_du_an_da_trien_khai_Ma_du_an.Text))
                MessageBox.Show("Hãy chọn đối tượng để xóa !", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu không ?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {

                    Xoa_thong_tin_du_an_da_trien_khai();
                    thong_tin_du_an_da_trien_khai();

                    button_du_an_da_trien_khai_Them.BorderBrush = Brushes.LightSkyBlue;
                    button_du_an_da_trien_khai_Sua.BorderBrush = Brushes.LightSkyBlue;
                    button_thong_tin_du_an_da_trien_khai_Xoa.BorderBrush = Brushes.DarkGoldenrod;
                    button_du_an_da_trien_khai_Luu.BorderBrush = Brushes.LightSkyBlue;
                    button_du_an_da_trien_khai_Huy.BorderBrush = Brushes.LightSkyBlue;
                }

            }






        }



        







        private void button_du_an_da_trien_khai_Luu_Click(object sender, RoutedEventArgs e)
        {



            if (textIsnotNull_thong_tin_du_an_da_trien_khai())
            {

                if (flag == "Thêm")
                {

                    dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_thong_tin_du_an_da_trien_khai();
                    Them_thong_tin_du_an_da_trien_khai();
                }




                if (flag == "Sửa")
                {

                    Sua_thong_tin_du_an_da_trien_khai();
                    dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_thong_tin_du_an_da_trien_khai();
                }



                button_du_an_da_trien_khai_Them.BorderBrush = Brushes.LightSkyBlue;
                button_du_an_da_trien_khai_Sua.BorderBrush = Brushes.LightSkyBlue;
                button_thong_tin_du_an_da_trien_khai_Xoa.BorderBrush = Brushes.LightSkyBlue;
                button_du_an_da_trien_khai_Luu.BorderBrush = Brushes.DarkGoldenrod;
                button_du_an_da_trien_khai_Huy.BorderBrush = Brushes.LightSkyBlue;

            }







            binding_to_textbox();

            thong_tin_du_an_da_trien_khai();

            //flag = "Lưu";
        }







        private void button_du_an_da_trien_khai_Huy_Click(object sender, RoutedEventArgs e)
        {
            dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_thong_tin_du_an_da_trien_khai();

            textbox_du_an_da_trien_khai_Ngay_khoi_cong.Text = "";
            binding_to_textbox();
            flag = "Hủy";
            
            button_du_an_da_trien_khai_Them.BorderBrush = Brushes.LightSkyBlue;
            button_du_an_da_trien_khai_Sua.BorderBrush = Brushes.LightSkyBlue;
            button_thong_tin_du_an_da_trien_khai_Xoa.BorderBrush = Brushes.LightSkyBlue;
            button_du_an_da_trien_khai_Luu.BorderBrush = Brushes.LightSkyBlue;
            button_du_an_da_trien_khai_Huy.BorderBrush = Brushes.DarkGoldenrod;

        }

        private void listview_Thong_tin_du_an_da_trien_khai_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (flag == "Thêm" & flag != "Lưu")
            {

                thong_tin_du_an_da_trien_khai_Lam_trang_textbox();


            }






        }

        private void listview_Thong_tin_du_an_da_trien_khai_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (flag == "Sửa") mo_textbox_va_Luu_Huy_Dong_Them_Sua_Xoa_thong_tin_du_an_da_trien_khai();
        }










        //*****************************************************************************************************************








        //*****Khu vực kế hoạch cho dự án mới**********************************************************************


        public DataTable xay_dung_ke_hoach_cho_du_an_moi()
        {


            DataTable data = new DataTable();

            try
            {

                string truyvan = "select * from xay_dung_ke_hoach_cho_du_an_moi";

                using (SqlConnection conection = new SqlConnection(chuoiketnoi))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                    adapter.Fill(data);

                    conection.Close();

                    listview_xay_dung_ke_hoach_cho_du_an_moi.ItemsSource = data.DefaultView;


                }


            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

           

            return data;
        }





        public DataTable Them_ke_hoach_cho_du_an_moi()
        {
            string datepicker = datepicker_ke_hoach_cho_du_an_moi.SelectedDate.Value.ToString();
            string chon_ngay = datepicker.Replace("12:00:00 AM", null);

            DataTable data = new DataTable();

            try
            {

                string truyvan = "exec them_ke_hoach @ma_du_an=''," +
                "@ten_du_an=N'" + textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_du_an.Text + "'," +
                "@ngay_khoi_cong_du_kien = '" + chon_ngay + "'," +
                "@so_san_pham_du_tinh = " + int.Parse(textbox_xay_dung_ke_hoach_cho_du_an_moi_So_san_pham_du_tinh.Text) + "," +
                "@ten_san_pham=N'" + textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_san_pham.Text + "'," +
                "@so_von_du_kien = " + int.Parse(textbox_xay_dung_ke_hoach_cho_du_an_moi_So_von_du_kien.Text) + "," +
                "@loi_nhuan_du_kien = " + textbox_xay_dung_ke_hoach_cho_du_an_moi_Loi_nhuan_du_kien.Text + " ";

                using (SqlConnection conection = new SqlConnection(chuoiketnoi))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                    adapter.Fill(data);

                    conection.Close();

                    listview_Thong_tin_du_an_da_trien_khai.ItemsSource = data.DefaultView;


                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

           


            return data;

        }






        public DataTable Sua_ke_hoach_cho_du_an_moi()
        {


            string datepicker = datepicker_ke_hoach_cho_du_an_moi.SelectedDate.Value.ToString();
            string chon_ngay = datepicker.Replace("12:00:00 AM", null);

            DataTable data = new DataTable();

            try
            {

                string truyvan = "update xay_dung_ke_hoach_cho_du_an_moi set " +
                "ten_du_an=N'" + textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_du_an.Text + "'," +
                "ngay_khoi_cong_du_kien = '" + chon_ngay + "'," +
                "so_san_pham_du_tinh = " + int.Parse(textbox_xay_dung_ke_hoach_cho_du_an_moi_So_san_pham_du_tinh.Text) + "," +
                "ten_san_pham=N'" + textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_san_pham.Text + "'," +
                "so_von_du_kien = " + int.Parse(textbox_xay_dung_ke_hoach_cho_du_an_moi_So_von_du_kien.Text) + "," +
                "loi_nhuan_du_kien = " + textbox_xay_dung_ke_hoach_cho_du_an_moi_Loi_nhuan_du_kien.Text + " where ma_du_an = '" + textbox_xay_dung_ke_hoach_cho_du_an_moi_Ma_du_an.Text + "' ";

                SqlConnection conection = new SqlConnection(chuoiketnoi);
                conection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                adapter.Fill(data);

                conection.Close();

                listview_Thong_tin_du_an_da_trien_khai.ItemsSource = data.DefaultView;

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

           



            return data;
        }




        public DataTable Xoa_ke_hoach_cho_du_an_moi()
        {



            DataTable data = new DataTable();

            try
            {

                string truyvan = "delete xay_dung_ke_hoach_cho_du_an_moi where ma_du_an = '" + textbox_xay_dung_ke_hoach_cho_du_an_moi_Ma_du_an.Text + "' ";

                SqlConnection conection = new SqlConnection(chuoiketnoi);
                conection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                adapter.Fill(data);

                conection.Close();

                listview_Thong_tin_du_an_da_trien_khai.ItemsSource = data.DefaultView;

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

          



            return data;
        }





        public DataTable timkiem_ke_hoach_du_an_moi()
        {


            DataTable data = new DataTable();


            try
            {
                string truyvan = "select * from xay_dung_ke_hoach_cho_du_an_moi where ma_du_an like '%" +textbox_Xay_dung_ke_hoach_du_an_moi_Tim_kiem.Text + "%' or ten_du_an like N'%" + textbox_Xay_dung_ke_hoach_du_an_moi_Tim_kiem.Text + "%' ";

                SqlConnection conection = new SqlConnection(chuoiketnoi);
                conection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                adapter.Fill(data);

                conection.Close();

                listview_xay_dung_ke_hoach_cho_du_an_moi.ItemsSource = data.DefaultView;



            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }




            return data;


        }





        public void mo_textbox_va_Luu_Huy_Dong_Them_Sua_Xoa_ke_hoach_cho_du_an_moi()
        {

            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ma_du_an.IsReadOnly = true;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_du_an.IsReadOnly = false;
            datepicker_ke_hoach_cho_du_an_moi.Visibility = Visibility.Visible;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ngay_khoi_cong_du_kien.Visibility = Visibility.Collapsed;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ngay_khoi_cong_du_kien.IsReadOnly = false;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_So_san_pham_du_tinh.IsReadOnly = false;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_san_pham.IsReadOnly = false;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_So_von_du_kien.IsReadOnly = false;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Loi_nhuan_du_kien.IsReadOnly = false;


            button_ke_hoach_cho_du_an_moi_Luu.Background = Brushes.Transparent;
            button_ke_hoach_cho_du_an_moi_Huy.Background = Brushes.Transparent;

            button_ke_hoach_cho_du_an_moi_Luu.IsEnabled = true;
            button_ke_hoach_cho_du_an_moi_Huy.IsEnabled = true;

            button_ke_hoach_cho_du_an_moi_Luu.Opacity = 1;
            button_ke_hoach_cho_du_an_moi_Huy.Opacity = 1;

            button_ke_hoach_cho_du_an_moi_Them.Background = Brushes.DarkSlateGray;
            button_ke_hoach_cho_du_an_moi_Sua.Background = Brushes.DarkSlateGray;
            button_ke_hoach_cho_du_an_moi_Xoa.Background = Brushes.DarkSlateGray;

            button_ke_hoach_cho_du_an_moi_Them.IsEnabled = false;
            button_ke_hoach_cho_du_an_moi_Sua.IsEnabled = false;
            button_ke_hoach_cho_du_an_moi_Xoa.IsEnabled = false;

            button_ke_hoach_cho_du_an_moi_Them.Opacity = 0.5;
            button_ke_hoach_cho_du_an_moi_Sua.Opacity = 0.5;
            button_ke_hoach_cho_du_an_moi_Xoa.Opacity = 0.5;

        }





        public void dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_ke_hoach_cho_du_an_moi()
        {

            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ma_du_an.IsReadOnly = true;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_du_an.IsReadOnly = true;
            datepicker_ke_hoach_cho_du_an_moi.Visibility = Visibility.Collapsed;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ngay_khoi_cong_du_kien.Visibility = Visibility.Visible;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ngay_khoi_cong_du_kien.IsReadOnly = true;

            textbox_xay_dung_ke_hoach_cho_du_an_moi_So_san_pham_du_tinh.IsReadOnly = true;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_san_pham.IsReadOnly = true;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_So_von_du_kien.IsReadOnly = true;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Loi_nhuan_du_kien.IsReadOnly = true;


            button_ke_hoach_cho_du_an_moi_Luu.Background = Brushes.DarkSlateGray;
            button_ke_hoach_cho_du_an_moi_Huy.Background = Brushes.DarkSlateGray;

            button_ke_hoach_cho_du_an_moi_Luu.IsEnabled = false;
            button_ke_hoach_cho_du_an_moi_Huy.IsEnabled = false;

            button_ke_hoach_cho_du_an_moi_Luu.Opacity = 0.5;
            button_ke_hoach_cho_du_an_moi_Huy.Opacity = 0.5;

            button_ke_hoach_cho_du_an_moi_Them.Background = Brushes.Transparent;
            button_ke_hoach_cho_du_an_moi_Sua.Background = Brushes.Transparent;
            button_ke_hoach_cho_du_an_moi_Xoa.Background = Brushes.Transparent;

            button_ke_hoach_cho_du_an_moi_Them.IsEnabled = true;
            button_ke_hoach_cho_du_an_moi_Sua.IsEnabled = true;
            button_ke_hoach_cho_du_an_moi_Xoa.IsEnabled = true;

            button_ke_hoach_cho_du_an_moi_Them.Opacity = 1;
            button_ke_hoach_cho_du_an_moi_Sua.Opacity = 1;
            button_ke_hoach_cho_du_an_moi_Xoa.Opacity = 1;


        }




        public void ke_hoach_cho_du_an_moi_Lam_trang_textbox()
        {

            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ma_du_an.Text = "";
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_du_an.Text = "";
            datepicker_ke_hoach_cho_du_an_moi.SelectedDate = null;
            textbox_xay_dung_ke_hoach_cho_du_an_moi_So_san_pham_du_tinh.Text = "";
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_san_pham.Text = "";
            textbox_xay_dung_ke_hoach_cho_du_an_moi_So_von_du_kien.Text = "";
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Loi_nhuan_du_kien.Text = "";




        }



        public bool textIsnotNull_ke_hoach_cho_du_an_moi()
        {

            if (string.IsNullOrEmpty(textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_du_an.Text))
            {

                MessageBox.Show("'Tên dự án' không được để trống !", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_du_an.Focus();

                return false;
            }
            else
            if (datepicker_ke_hoach_cho_du_an_moi.SelectedDate == null)
            {

                MessageBox.Show("'Ngày khởi công' không được để trống !", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);

                return false;
            }
            else
            if (string.IsNullOrEmpty(textbox_xay_dung_ke_hoach_cho_du_an_moi_So_san_pham_du_tinh.Text))
            {

                MessageBox.Show("'Số sản phẩm' không được để trống !", "", MessageBoxButton.OK, MessageBoxImage.Warning);

                textbox_xay_dung_ke_hoach_cho_du_an_moi_So_san_pham_du_tinh.Focus();
                return false;
            }
            else
            if (string.IsNullOrEmpty(textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_san_pham.Text))
            {

                MessageBox.Show("Tên sản phẩm không được để trống", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);

                textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_san_pham.Focus();
                return false;
            }

            else
            if (string.IsNullOrEmpty(textbox_xay_dung_ke_hoach_cho_du_an_moi_So_von_du_kien.Text))
            {

                MessageBox.Show("Số vốn dự kiến không được để trống !", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_xay_dung_ke_hoach_cho_du_an_moi_So_von_du_kien.Focus();
                return false;
            }

            else
            if (string.IsNullOrEmpty(textbox_xay_dung_ke_hoach_cho_du_an_moi_Loi_nhuan_du_kien.Text))
            {

                MessageBox.Show("'Lợi nhuận' không được để trống !", "Nhăc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);
                textbox_xay_dung_ke_hoach_cho_du_an_moi_Loi_nhuan_du_kien.Focus();

                return false;
            }



            return true;
        }




        public void binding_to_textbox_ke_hoach_du_an_moi()
        {

            Binding ma_du_an = new Binding();
            ma_du_an.Mode = BindingMode.OneWay;
            Binding ten_du_an = new Binding();
            ten_du_an.Mode = BindingMode.OneWay;
            Binding so_san_pham_du_tinh = new Binding();
            so_san_pham_du_tinh.Mode = BindingMode.OneWay;
            Binding ten_san_pham = new Binding();
            ten_san_pham.Mode = BindingMode.OneWay;
            Binding so_von_du_kien = new Binding();
            so_von_du_kien.Mode = BindingMode.OneWay;
            Binding loi_nhuan_du_kien = new Binding();
            loi_nhuan_du_kien.Mode = BindingMode.OneWay;
            Binding ngay_khoi_cong_du_kien = new Binding();
            ngay_khoi_cong_du_kien.Mode = BindingMode.OneWay;



            // The source
            ma_du_an.Path = new PropertyPath("SelectedValue.[ma_du_an]");
            ma_du_an.ElementName = "listview_xay_dung_ke_hoach_cho_du_an_moi";
            ten_du_an.Path = new PropertyPath("SelectedValue.[ten_du_an]");
            ten_du_an.ElementName = "listview_xay_dung_ke_hoach_cho_du_an_moi";
            so_san_pham_du_tinh.Path = new PropertyPath("SelectedValue.[so_san_pham_du_tinh]");
            so_san_pham_du_tinh.ElementName = "listview_xay_dung_ke_hoach_cho_du_an_moi";
            ten_san_pham.Path = new PropertyPath("SelectedValue.[ten_san_pham]");
            ten_san_pham.ElementName = "listview_xay_dung_ke_hoach_cho_du_an_moi";
            so_von_du_kien.Path = new PropertyPath("SelectedValue.[so_von_du_kien]");
            so_von_du_kien.ElementName = "listview_xay_dung_ke_hoach_cho_du_an_moi";
            loi_nhuan_du_kien.Path = new PropertyPath("SelectedValue.[loi_nhuan_du_kien]");
            loi_nhuan_du_kien.ElementName = "listview_xay_dung_ke_hoach_cho_du_an_moi";
            ngay_khoi_cong_du_kien.Path = new PropertyPath("SelectedValue.[ ngay_khoi_cong_du_kien]");
            ngay_khoi_cong_du_kien.ElementName = "listview_xay_dung_ke_hoach_cho_du_an_moi";


            // The target
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ma_du_an.SetBinding(TextBox.TextProperty, ma_du_an);
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_du_an.SetBinding(TextBox.TextProperty, ten_du_an);
            textbox_xay_dung_ke_hoach_cho_du_an_moi_So_san_pham_du_tinh.SetBinding(TextBox.TextProperty, so_san_pham_du_tinh);
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ten_san_pham.SetBinding(TextBox.TextProperty, ten_san_pham);
            textbox_xay_dung_ke_hoach_cho_du_an_moi_So_von_du_kien.SetBinding(TextBox.TextProperty, so_von_du_kien);
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Loi_nhuan_du_kien.SetBinding(TextBox.TextProperty, loi_nhuan_du_kien);
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ngay_khoi_cong_du_kien.SetBinding(TextBox.TextProperty, ngay_khoi_cong_du_kien);


        }



        private void listview_xay_dung_ke_hoach_cho_du_an_moi_MouseEnter(object sender, MouseEventArgs e)
        {
            listview_xay_dung_ke_hoach_cho_du_an_moi.Foreground = Brushes.DarkGoldenrod;
        }

        private void listview_xay_dung_ke_hoach_cho_du_an_moi_MouseLeave(object sender, MouseEventArgs e)
        {
            listview_xay_dung_ke_hoach_cho_du_an_moi.Foreground = Brushes.DarkBlue;
        }









        private void button_ke_hoach_cho_du_an_moi_Them_Click(object sender, RoutedEventArgs e)
        {
            mo_textbox_va_Luu_Huy_Dong_Them_Sua_Xoa_ke_hoach_cho_du_an_moi();

            thong_tin_du_an_da_trien_khai_Lam_trang_textbox();

            button_ke_hoach_cho_du_an_moi_Them.BorderBrush = Brushes.DarkGoldenrod;
            button_ke_hoach_cho_du_an_moi_Sua.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Xoa.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Luu.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Huy.BorderBrush = Brushes.LightSkyBlue;
            flag = "Thêm dự án mới";
        }

        private void button_ke_hoach_cho_du_an_moi_Sua_Click(object sender, RoutedEventArgs e)
        {
           


            binding_to_textbox_ke_hoach_du_an_moi();

            button_ke_hoach_cho_du_an_moi_Them.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Sua.BorderBrush = Brushes.DarkGoldenrod;
            button_ke_hoach_cho_du_an_moi_Xoa.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Luu.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Huy.BorderBrush = Brushes.LightSkyBlue;



            flag = "Sửa dự án mới";

        }

        private void button_ke_hoach_cho_du_an_moi_Xoa_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(textbox_xay_dung_ke_hoach_cho_du_an_moi_Ma_du_an.Text))
                MessageBox.Show("Hãy chọn đối tượng để xóa !", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {

                MessageBoxResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu không ?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {



                    Xoa_ke_hoach_cho_du_an_moi();
                    xay_dung_ke_hoach_cho_du_an_moi();

                    button_ke_hoach_cho_du_an_moi_Them.BorderBrush = Brushes.LightSkyBlue;
                    button_ke_hoach_cho_du_an_moi_Sua.BorderBrush = Brushes.LightSkyBlue;
                    button_ke_hoach_cho_du_an_moi_Xoa.BorderBrush = Brushes.DarkGoldenrod;
                    button_ke_hoach_cho_du_an_moi_Luu.BorderBrush = Brushes.LightSkyBlue;
                    button_ke_hoach_cho_du_an_moi_Huy.BorderBrush = Brushes.LightSkyBlue;
                }

            }



          



        }




        








        private void button_ke_hoach_cho_du_an_moi_Luu_Click(object sender, RoutedEventArgs e)
        {

            button_ke_hoach_cho_du_an_moi_Luu.BorderBrush = Brushes.DarkGoldenrod;

            if (textIsnotNull_ke_hoach_cho_du_an_moi() & flag == "Thêm dự án mới")
            {
                dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_ke_hoach_cho_du_an_moi();
                Them_ke_hoach_cho_du_an_moi();



            }

            if (textIsnotNull_ke_hoach_cho_du_an_moi())
            {
                if (flag == "Sửa dự án mới")
                {



                    Sua_ke_hoach_cho_du_an_moi();


                }
                dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_ke_hoach_cho_du_an_moi();



            }


            xay_dung_ke_hoach_cho_du_an_moi();


            button_ke_hoach_cho_du_an_moi_Them.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Sua.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Xoa.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Luu.BorderBrush = Brushes.DarkGoldenrod;
            button_ke_hoach_cho_du_an_moi_Huy.BorderBrush = Brushes.LightSkyBlue;

            binding_to_textbox_ke_hoach_du_an_moi();


        }

        private void button_ke_hoach_cho_du_an_moi_Huy_Click(object sender, RoutedEventArgs e)
        {
            dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_ke_hoach_cho_du_an_moi();

            binding_to_textbox_ke_hoach_du_an_moi();
            
            textbox_xay_dung_ke_hoach_cho_du_an_moi_Ngay_khoi_cong_du_kien.Text = "";

            button_ke_hoach_cho_du_an_moi_Them.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Sua.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Xoa.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Luu.BorderBrush = Brushes.LightSkyBlue;
            button_ke_hoach_cho_du_an_moi_Huy.BorderBrush = Brushes.DarkGoldenrod;

            flag = "Hủy dự án mới";


        }




        private void listview_xay_dung_ke_hoach_cho_du_an_moi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (flag == "Sửa dự án mới") mo_textbox_va_Luu_Huy_Dong_Them_Sua_Xoa_ke_hoach_cho_du_an_moi();
        }




















        //****************************************************************************************************************







        //***Khu vực thông tin đối tác******************************************************************************************





        public DataTable thong_tin_doi_dac()
        {


            DataTable data = new DataTable();

            try
            {

                string truyvan = "select * from quan_ly_thong_tin_doi_tac";

                using (SqlConnection conection = new SqlConnection(chuoiketnoi))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                    adapter.Fill(data);

                    conection.Close();

                    listview_quan_ly_thong_tin_doi_tac.ItemsSource = data.DefaultView;


                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            

            return data;
        }






        public DataTable Them_thong_tin_doi_dac()
        {
            string datepicker_ngay_Sinh = datepicker_Thong_tin_doi_tac_Ngay_sinh.SelectedDate.Value.ToString();
            string chon_ngay_sinh = datepicker_ngay_Sinh.Replace("12:00:00 AM", null);
            string datepicker_ngay_bat_dau_hop_tac = datepicker_Thong_tin_doi_tac_Ngay_bat_dau_hop_tac.SelectedDate.Value.ToString();
            string chon_ngay_bat_dau_hop_tac = datepicker_ngay_Sinh.Replace("12:00:00 AM", null);

            DataTable data = new DataTable();

            try
            {

                string truyvan = "exec them_doi_tac @ma_doi_tac =''," +
                "@ten_doi_tac=N'" + textbox_quan_ly_thong_tin_doi_tac_Ten_doi_tac.Text + "'," +
                "@nghe_nghiep = N'" + textbox_quan_ly_thong_tin_doi_tac_Nghe_nghiep.Text + "'," +
                "@so_dien_thoai ='" + textbox_quan_ly_thong_tin_doi_tac_So_dien_thoai.Text + "'," +
                "@ngay_sinh = '" + chon_ngay_sinh + "'," +
                "@dia_chi=N'" + textbox_quan_ly_thong_tin_doi_tac_Dia_chi.Text + "'," +
                "@ngay_bat_dau_hop_tac = '" + chon_ngay_bat_dau_hop_tac + "'";

                using (SqlConnection conection = new SqlConnection(chuoiketnoi))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                    adapter.Fill(data);

                    conection.Close();

                    listview_quan_ly_thong_tin_doi_tac.ItemsSource = data.DefaultView;


                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           

            return data;
        }





        public DataTable Sua_thong_tin_doi_dac()
        {
            string datepicker_ngay_Sinh = datepicker_Thong_tin_doi_tac_Ngay_sinh.SelectedDate.Value.ToString();
            string chon_ngay_sinh = datepicker_ngay_Sinh.Replace("12:00:00 AM", null);
            string datepicker_ngay_bat_dau_hop_tac = datepicker_Thong_tin_doi_tac_Ngay_bat_dau_hop_tac.SelectedDate.Value.ToString();
            string chon_ngay_bat_dau_hop_tac = datepicker_ngay_bat_dau_hop_tac.Replace("12:00:00 AM", null);

            DataTable data = new DataTable();

            try
            {

                string truyvan = "update quan_ly_thong_tin_doi_tac set " +
                "ten_doi_tac=N'" + textbox_quan_ly_thong_tin_doi_tac_Ten_doi_tac.Text + "'," +
                "nghe_nghiep = N'" + textbox_quan_ly_thong_tin_doi_tac_Nghe_nghiep.Text + "'," +
                "so_dien_thoai ='" + textbox_quan_ly_thong_tin_doi_tac_So_dien_thoai.Text + "'," +
                "ngay_sinh = '" + chon_ngay_sinh + "'," +
                "dia_chi=N'" + textbox_quan_ly_thong_tin_doi_tac_Dia_chi.Text + "'," +
                "ngay_bat_dau_hop_tac = '" + chon_ngay_bat_dau_hop_tac + "' where ma_doi_tac = '" + textbox_quan_ly_thong_tin_doi_tac_Ma_doi_tac.Text + "' ";

                using (SqlConnection conection = new SqlConnection(chuoiketnoi))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                    adapter.Fill(data);

                    conection.Close();

                    listview_quan_ly_thong_tin_doi_tac.ItemsSource = data.DefaultView;


                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            

            return data;
        }




        public DataTable Xoa_thong_tin_doi_dac()
        {


            DataTable data = new DataTable();

            try
            {

                string truyvan = "delete quan_ly_thong_tin_doi_tac where ma_doi_tac = '" + textbox_quan_ly_thong_tin_doi_tac_Ma_doi_tac.Text + "' ";

                using (SqlConnection conection = new SqlConnection(chuoiketnoi))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                    adapter.Fill(data);

                    conection.Close();

                    listview_quan_ly_thong_tin_doi_tac.ItemsSource = data.DefaultView;


                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

           

            return data;
        }




        public DataTable timkiem_thong_tin_doi_tac()
        {


            DataTable data = new DataTable();


            try
            {
                string truyvan = "select * from quan_ly_thong_tin_doi_tac where ma_doi_tac like '%" + textbox_quan_ly_thong_tin_doi_tac_Tim_kiem.Text + "%' or ten_doi_tac like N'%" + textbox_quan_ly_thong_tin_doi_tac_Tim_kiem.Text + "%' ";

                SqlConnection conection = new SqlConnection(chuoiketnoi);
                conection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                adapter.Fill(data);

                conection.Close();

                listview_quan_ly_thong_tin_doi_tac.ItemsSource = data.DefaultView;



            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }




            return data;


        }







        public void mo_textbox_va_Luu_Huy_Dong_Them_Sua_Xoa_thong_tin_doi_tac()
        {

            textbox_quan_ly_thong_tin_doi_tac_Ma_doi_tac.IsReadOnly = true;
            textbox_quan_ly_thong_tin_doi_tac_Ten_doi_tac.IsReadOnly = false;
            textbox_quan_ly_thong_tin_doi_tac_Nghe_nghiep.IsReadOnly = false;
            textbox_quan_ly_thong_tin_doi_tac_So_dien_thoai.IsReadOnly = false;
            datepicker_Thong_tin_doi_tac_Ngay_sinh.Visibility = Visibility.Visible;
            textbox_quan_ly_thong_tin_doi_tac_Ngay_sinh.Visibility = Visibility.Collapsed;
            textbox_quan_ly_thong_tin_doi_tac_Dia_chi.IsReadOnly = false;
            datepicker_Thong_tin_doi_tac_Ngay_bat_dau_hop_tac.Visibility = Visibility.Visible;
            textbox_quan_ly_thong_tin_doi_tac_Ngay_bat_dau_hop_tac.Visibility = Visibility.Collapsed;





            button_quan_ly_thong_tin_doi_tac_Luu.Background = Brushes.Transparent;
            button_thong_tin_doi_tac_Huy.Background = Brushes.Transparent;

            button_quan_ly_thong_tin_doi_tac_Luu.IsEnabled = true;
            button_thong_tin_doi_tac_Huy.IsEnabled = true;

            button_quan_ly_thong_tin_doi_tac_Luu.Opacity = 1;
            button_thong_tin_doi_tac_Huy.Opacity = 1;

            button_quan_ly_thong_tin_doi_tac_Them.Background = Brushes.DarkSlateGray;
            button_quan_ly_thong_tin_doi_tac_Sua.Background = Brushes.DarkSlateGray;
            button_quan_ly_thong_tin_doi_tac_Xoa.Background = Brushes.DarkSlateGray;

            button_quan_ly_thong_tin_doi_tac_Them.IsEnabled = false;
            button_quan_ly_thong_tin_doi_tac_Sua.IsEnabled = false;
            button_quan_ly_thong_tin_doi_tac_Xoa.IsEnabled = false;

            button_quan_ly_thong_tin_doi_tac_Them.Opacity = 0.5;
            button_quan_ly_thong_tin_doi_tac_Sua.Opacity = 0.5;
            button_quan_ly_thong_tin_doi_tac_Xoa.Opacity = 0.5;

        }





        public void dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_thong_tin_doi_tac()
        {

            textbox_quan_ly_thong_tin_doi_tac_Ma_doi_tac.IsReadOnly = true;
            textbox_quan_ly_thong_tin_doi_tac_Ten_doi_tac.IsReadOnly = true;
            textbox_quan_ly_thong_tin_doi_tac_Nghe_nghiep.IsReadOnly = true;
            textbox_quan_ly_thong_tin_doi_tac_So_dien_thoai.IsReadOnly = true;
            datepicker_Thong_tin_doi_tac_Ngay_sinh.Visibility = Visibility.Collapsed;
            textbox_quan_ly_thong_tin_doi_tac_Ngay_sinh.Visibility = Visibility.Visible;
            textbox_quan_ly_thong_tin_doi_tac_Dia_chi.IsReadOnly = true;
            datepicker_Thong_tin_doi_tac_Ngay_bat_dau_hop_tac.Visibility = Visibility.Collapsed;
            textbox_quan_ly_thong_tin_doi_tac_Ngay_bat_dau_hop_tac.Visibility = Visibility.Visible;





            button_quan_ly_thong_tin_doi_tac_Luu.Background = Brushes.DarkSlateGray;
            button_thong_tin_doi_tac_Huy.Background = Brushes.DarkSlateGray;

            button_quan_ly_thong_tin_doi_tac_Luu.IsEnabled = false;
            button_thong_tin_doi_tac_Huy.IsEnabled = false;

            button_quan_ly_thong_tin_doi_tac_Luu.Opacity = 0.5;
            button_thong_tin_doi_tac_Huy.Opacity = 0.5;

            button_quan_ly_thong_tin_doi_tac_Them.Background = Brushes.Transparent;
            button_quan_ly_thong_tin_doi_tac_Sua.Background = Brushes.Transparent;
            button_quan_ly_thong_tin_doi_tac_Xoa.Background = Brushes.Transparent;

            button_quan_ly_thong_tin_doi_tac_Them.IsEnabled = true;
            button_quan_ly_thong_tin_doi_tac_Sua.IsEnabled = true;
            button_quan_ly_thong_tin_doi_tac_Xoa.IsEnabled = true;

            button_quan_ly_thong_tin_doi_tac_Them.Opacity = 1;
            button_quan_ly_thong_tin_doi_tac_Sua.Opacity = 1;
            button_quan_ly_thong_tin_doi_tac_Xoa.Opacity = 1;


        }




        public bool textIsnotNull_thong_tin_doi_tac()
        {

            int ketqua;

            if (string.IsNullOrEmpty(textbox_quan_ly_thong_tin_doi_tac_Ten_doi_tac.Text))
            {

                MessageBox.Show("'Tên đối tác' không được để trống !", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);

                return false;
            }
            else
            if (string.IsNullOrEmpty(textbox_quan_ly_thong_tin_doi_tac_Nghe_nghiep.Text))
            {

                MessageBox.Show("'Nghề nghiệp' không được để trống !", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);

                textbox_quan_ly_thong_tin_doi_tac_Nghe_nghiep.Focus();
                return false;
            }
            else
            if (string.IsNullOrEmpty(textbox_quan_ly_thong_tin_doi_tac_So_dien_thoai.Text))
            {


                MessageBox.Show("'Số điện thoại không được để trống !'", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);

                textbox_xay_dung_ke_hoach_cho_du_an_moi_So_san_pham_du_tinh.Focus();




                return false;
            }
            else
            if (datepicker_Thong_tin_doi_tac_Ngay_sinh.SelectedDate == null)
            {

                MessageBox.Show("'Ngày sinh' không được để trống !", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);


                return false;
            }

            else
            if (string.IsNullOrEmpty(textbox_quan_ly_thong_tin_doi_tac_Dia_chi.Text))
            {

                MessageBox.Show("'Địa chỉ' không được để trống", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Warning);

                textbox_quan_ly_thong_tin_doi_tac_Dia_chi.Focus();
                return false;
            }

            else
            if (datepicker_Thong_tin_doi_tac_Ngay_bat_dau_hop_tac.SelectedDate == null)
            {

                MessageBox.Show("'Ngày bắt đầu hợp tác' không được để trống !", "", MessageBoxButton.OK, MessageBoxImage.Warning);


                return false;
            }



            if (int.TryParse(textbox_quan_ly_thong_tin_doi_tac_So_dien_thoai.Text, out ketqua) == false)
            {


                MessageBox.Show(" Định dạng của 'Số điện thoại' không đúng ! ", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Information);
                textbox_quan_ly_thong_tin_doi_tac_So_dien_thoai.Text = "";
                textbox_quan_ly_thong_tin_doi_tac_So_dien_thoai.IsReadOnly = false;
                textbox_quan_ly_thong_tin_doi_tac_So_dien_thoai.Focus();


            }




            return true;
        }




        public void thong_tin_doi_tac_Lam_trang_textbox()
        {

            textbox_quan_ly_thong_tin_doi_tac_Ma_doi_tac.Text = "";
            textbox_quan_ly_thong_tin_doi_tac_Ten_doi_tac.Text = "";
            textbox_quan_ly_thong_tin_doi_tac_Nghe_nghiep.Text = "";
            textbox_quan_ly_thong_tin_doi_tac_So_dien_thoai.Text = "";
            datepicker_Thong_tin_doi_tac_Ngay_sinh.SelectedDate = null;
            textbox_quan_ly_thong_tin_doi_tac_Dia_chi.Text = "";
            datepicker_Thong_tin_doi_tac_Ngay_bat_dau_hop_tac.SelectedDate = null;




        }







        public void binding_to_textbox_thong_tin_doi_tac()
        {

            Binding ma_doi_tac = new Binding();
            ma_doi_tac.Mode = BindingMode.OneWay;
            Binding ten_doi_tac = new Binding();
            ten_doi_tac.Mode = BindingMode.OneWay;
            Binding nghe_nghiep = new Binding();
            nghe_nghiep.Mode = BindingMode.OneWay;
            Binding so_dien_thoai = new Binding();
            so_dien_thoai.Mode = BindingMode.OneWay;
            Binding dia_chi = new Binding();
            dia_chi.Mode = BindingMode.OneWay;




            // The source
            ma_doi_tac.Path = new PropertyPath("SelectedValue.[  ma_doi_tac]");
            ma_doi_tac.ElementName = "listview_quan_ly_thong_tin_doi_tac";
            ten_doi_tac.Path = new PropertyPath("SelectedValue.[ ten_doi_tac]");
            ten_doi_tac.ElementName = "listview_quan_ly_thong_tin_doi_tac";
            nghe_nghiep.Path = new PropertyPath("SelectedValue.[ nghe_nghiep]");
            nghe_nghiep.ElementName = "listview_quan_ly_thong_tin_doi_tac";
            so_dien_thoai.Path = new PropertyPath("SelectedValue.[so_dien_thoai]");
            so_dien_thoai.ElementName = "listview_quan_ly_thong_tin_doi_tac";
            dia_chi.Path = new PropertyPath("SelectedValue.[ dia_chi]");
            dia_chi.ElementName = "listview_quan_ly_thong_tin_doi_tac";




            // The target
            textbox_quan_ly_thong_tin_doi_tac_Ma_doi_tac.SetBinding(TextBox.TextProperty, ma_doi_tac);
            textbox_quan_ly_thong_tin_doi_tac_Ten_doi_tac.SetBinding(TextBox.TextProperty, ten_doi_tac);
            textbox_quan_ly_thong_tin_doi_tac_Nghe_nghiep.SetBinding(TextBox.TextProperty, nghe_nghiep);
            textbox_quan_ly_thong_tin_doi_tac_So_dien_thoai.SetBinding(TextBox.TextProperty, so_dien_thoai);
            textbox_quan_ly_thong_tin_doi_tac_Dia_chi.SetBinding(TextBox.TextProperty, dia_chi);




        }





        private void listview_quan_ly_thong_tin_doi_tac_MouseEnter(object sender, MouseEventArgs e)
        {
            listview_quan_ly_thong_tin_doi_tac.Foreground = Brushes.DarkGoldenrod;
        }

        private void listview_quan_ly_thong_tin_doi_tac_MouseLeave(object sender, MouseEventArgs e)
        {
            listview_quan_ly_thong_tin_doi_tac.Foreground = Brushes.DarkBlue;

        }




        private void button_quan_ly_thong_tin_doi_tac_Them_Click(object sender, RoutedEventArgs e)
        {

            mo_textbox_va_Luu_Huy_Dong_Them_Sua_Xoa_thong_tin_doi_tac();

            thong_tin_doi_tac_Lam_trang_textbox();


            button_quan_ly_thong_tin_doi_tac_Them.BorderBrush = Brushes.DarkGoldenrod;
            button_quan_ly_thong_tin_doi_tac_Sua.BorderBrush = Brushes.LightSkyBlue;
            button_quan_ly_thong_tin_doi_tac_Xoa.BorderBrush = Brushes.LightSkyBlue;
            button_quan_ly_thong_tin_doi_tac_Luu.BorderBrush = Brushes.LightSkyBlue;
            button_thong_tin_doi_tac_Huy.BorderBrush = Brushes.LightSkyBlue;

            flag = "Thêm đối tác";


        }

        private void button_quan_ly_thong_tin_doi_tac_Sua_Click(object sender, RoutedEventArgs e)
        {


            flag = "Sửa đối tác";
            binding_to_textbox_thong_tin_doi_tac();

            button_quan_ly_thong_tin_doi_tac_Them.BorderBrush = Brushes.LightSkyBlue;
            button_quan_ly_thong_tin_doi_tac_Sua.BorderBrush = Brushes.DarkGoldenrod;
            button_quan_ly_thong_tin_doi_tac_Xoa.BorderBrush = Brushes.LightSkyBlue;
            button_quan_ly_thong_tin_doi_tac_Luu.BorderBrush = Brushes.LightSkyBlue;
            button_thong_tin_doi_tac_Huy.BorderBrush = Brushes.LightSkyBlue;


        }

        private void button_quan_ly_thong_tin_doi_tac_Xoa_Click(object sender, RoutedEventArgs e)
        {



            if (string.IsNullOrEmpty(textbox_quan_ly_thong_tin_doi_tac_Ma_doi_tac.Text))
                MessageBox.Show("Hãy chọn đối tượng để xóa !", "Nhắc nhở", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {


                MessageBoxResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu không ?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {



                    Xoa_thong_tin_doi_dac();
                    thong_tin_doi_dac();

                    button_quan_ly_thong_tin_doi_tac_Them.BorderBrush = Brushes.LightSkyBlue;
                    button_quan_ly_thong_tin_doi_tac_Sua.BorderBrush = Brushes.LightSkyBlue;
                    button_quan_ly_thong_tin_doi_tac_Xoa.BorderBrush = Brushes.DarkGoldenrod;
                    button_quan_ly_thong_tin_doi_tac_Luu.BorderBrush = Brushes.LightSkyBlue;
                    button_thong_tin_doi_tac_Huy.BorderBrush = Brushes.LightSkyBlue;
                }
            }


          


            binding_to_textbox_thong_tin_doi_tac();
        }







      









        private void button_quan_ly_thong_tin_doi_tac_Luu_Click(object sender, RoutedEventArgs e)
        {



            if (textIsnotNull_thong_tin_doi_tac() & flag == "Thêm đối tác")
            {

                dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_thong_tin_doi_tac();
                Them_thong_tin_doi_dac();



            }

            if (textIsnotNull_thong_tin_doi_tac())
            {
                if (flag == "Sửa đối tác")
                {



                    Sua_thong_tin_doi_dac();


                }
                dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_thong_tin_doi_tac();



            }









            thong_tin_doi_dac();
            binding_to_textbox_thong_tin_doi_tac();


            button_quan_ly_thong_tin_doi_tac_Them.BorderBrush = Brushes.LightSkyBlue;
            button_quan_ly_thong_tin_doi_tac_Sua.BorderBrush = Brushes.LightSkyBlue;
            button_quan_ly_thong_tin_doi_tac_Xoa.BorderBrush = Brushes.LightSkyBlue;
            button_quan_ly_thong_tin_doi_tac_Luu.BorderBrush = Brushes.DarkGoldenrod;
            button_thong_tin_doi_tac_Huy.BorderBrush = Brushes.LightSkyBlue;


        }

        private void button_thong_tin_doi_tac_Huy_Click(object sender, RoutedEventArgs e)
        {

            dong_textbox_va_Luu_Huy_Mo_Them_Sua_Xoa_thong_tin_doi_tac();

            binding_to_textbox_thong_tin_doi_tac();
        
            textbox_quan_ly_thong_tin_doi_tac_Ngay_sinh.Text = "";
            textbox_quan_ly_thong_tin_doi_tac_Ngay_bat_dau_hop_tac.Text = "";

            button_quan_ly_thong_tin_doi_tac_Them.BorderBrush = Brushes.LightSkyBlue;
            button_quan_ly_thong_tin_doi_tac_Sua.BorderBrush = Brushes.LightSkyBlue;
            button_quan_ly_thong_tin_doi_tac_Xoa.BorderBrush = Brushes.LightSkyBlue;
            button_quan_ly_thong_tin_doi_tac_Luu.BorderBrush = Brushes.LightSkyBlue;
            button_thong_tin_doi_tac_Huy.BorderBrush = Brushes.DarkGoldenrod;

            flag = "Hủy đối tác";


        }


        private void listview_quan_ly_thong_tin_doi_tac_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (flag == "Sửa đối tác") mo_textbox_va_Luu_Huy_Dong_Them_Sua_Xoa_thong_tin_doi_tac();
        }






        //**************************************************************************************************************************


        //************Khu vực chức năng đặc biệt*********************************





        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            form_Thu_Vao form_Thu_Vao = new form_Thu_Vao();
            form_Thu_Vao.Show();
        }

        private void textblock_Chi_Ra_MouseDown(object sender, MouseButtonEventArgs e)
        {
            form_Chi_Ra form_Chi_Ra = new form_Chi_Ra();
            form_Chi_Ra.Show();
        }




        public DataTable Thu_vao()
        {


            DataTable data = new DataTable();

            try
            {

                string truyvan = "select * from thu_vao";

                using (SqlConnection conection = new SqlConnection(chuoiketnoi))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                    adapter.Fill(data);

                    conection.Close();

                    listview_quan_ly_thong_tin_doi_tac.ItemsSource = data.DefaultView;


                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

           



            return data;
        }




        public long Tong_so_tien_thu_vao()
        {

            int so_hang = Thu_vao().Rows.Count;
            int i;
            long S = 0;
            for (i = 0; i < so_hang; i++)
            {
                S = S + long.Parse(Thu_vao().Rows[i]["so_tien"].ToString());


            }

            textbox_quan_ly_quy_dau_tu_Thu_Vao.Text = S.ToString();

            return S;
        }


        public long Tong_so_tien_chi_ra()
        {
            int so_hang = chi_ra().Rows.Count;
            int i;
            long S = 0;
            for (i = 0; i < so_hang; i++)
            {
                S = S + long.Parse(chi_ra().Rows[i]["so_tien"].ToString());


            }

            textbox_quan_ly_quy_dau_tu_Chi_Ra.Text = S.ToString();


            return S;
        }






        public DataTable chi_ra()
        {


            DataTable data = new DataTable();

            try
            {

                string truyvan = "select * from chi_ra";

                using (SqlConnection conection = new SqlConnection(chuoiketnoi))
                {
                    conection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyvan, conection);
                    adapter.Fill(data);

                    conection.Close();

                    listview_quan_ly_thong_tin_doi_tac.ItemsSource = data.DefaultView;


                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            



            return data;
        }



        private void textbox_du_an_da_trien_khai_Tim_kiem_TextChanged(object sender, TextChangedEventArgs e)
        {
            timkiem_du_an_da_trien_khai();
        }

        private void textbox_du_an_moi_Tim_kiem_TextChanged(object sender, TextChangedEventArgs e)
        {
            timkiem_ke_hoach_du_an_moi();
           
        }

        private void textbox_quan_ly_thong_tin_doi_tac_Tim_kiem_TextChanged(object sender, TextChangedEventArgs e)
        {
            timkiem_thong_tin_doi_tac();
        }
    } 


        
    

}
