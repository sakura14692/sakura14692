using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuchanh_quanli_hocsinh;

namespace quan_li_hoc_sinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = new hien_thi().table_hocsinh();
            kich_hoat_them_sua_xoa_vo_hieu_hoa_textbox_va_nut_luu_huy();
            textBoxgioitinh.Text = new hien_thi().table_hocsinh().Rows[2]["ths"].ToString();


           


        }

        string flag_danh_dau = "";

       public bool checkdata ()
        {
            if (string.IsNullOrEmpty(textboxmahocsinh.Text)) 
            {
                MessageBox.Show("Bạn chưa nhập mã học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            
            }

            if (string.IsNullOrEmpty(textBoxtenhocsinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(textBoxNgaysinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;

        }




        //Đổ dữ liệu từ bảng lên textbox
        int ID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                textboxmahocsinh.Text = dataGridView1.Rows[index].Cells["mhs"].Value.ToString();
                textBoxtenhocsinh.Text = dataGridView1.Rows[index].Cells["ths"].Value.ToString();
                textBoxNgaysinh.Text = dataGridView1.Rows[index].Cells["ns"].Value.ToString();
                textBoxgioitinh.Text = dataGridView1.Rows[index].Cells["gt"].Value.ToString();
                try
                {
                    ID = int.Parse(dataGridView1.Rows[index].Cells["id"].Value.ToString());
                }
                catch (Exception)
                {

                }
                
                
                



            }
        }












        public void kich_hoat_them_sua_xoa_vo_hieu_hoa_textbox_va_nut_luu_huy() 
        {
            buttonthem.Enabled = true;
            buttonsua.Enabled = true;
            buttonxoa.Enabled = true;
            buttonluu.Enabled = false;
            buttonhuy.Enabled = false;
            textboxmahocsinh.ReadOnly = true;
            textBoxtenhocsinh.ReadOnly = true;
            textBoxNgaysinh.ReadOnly = true;
            textBoxgioitinh.ReadOnly = true;
            buttonthem.Focus();
          

        
        
        
        
        }

        public void vo_hieu_hoa_them_sua_xoa_kich_hoat_textbox_va_nut_luu_huy()
        {
            buttonthem.Enabled = false;
            buttonsua.Enabled = false;
            buttonxoa.Enabled = false;
            buttonluu.Enabled = true;
            buttonhuy.Enabled = true;
            textboxmahocsinh.ReadOnly = false;
            textBoxtenhocsinh.ReadOnly = false;
            textBoxNgaysinh.ReadOnly = false;
            textBoxgioitinh.ReadOnly = false;
            textboxmahocsinh.Focus();






        }



        public void xoa_trang_textbox() 
        {

            textboxmahocsinh.Text = "";
            textBoxtenhocsinh.Text = "";
            textBoxNgaysinh.Text = "";
            textBoxgioitinh.Text = ""; 

        
        
        }







        private void buttonthem_Click(object sender, EventArgs e)
        {
           
            vo_hieu_hoa_them_sua_xoa_kich_hoat_textbox_va_nut_luu_huy();


        }

       

        private void buttonsua_Click(object sender, EventArgs e)
        {

            if (checkdata())
            {
                chuc_nang cn = new chuc_nang
                      (
                       textboxmahocsinh.Text,
                       textBoxtenhocsinh.Text,
                       textBoxNgaysinh.Text,
                       textBoxgioitinh.Text,
                       ID,
                       textBoxtimkiem.Text



                      );


                cn.updatehocsinh();
                dataGridView1.DataSource = new hien_thi().table_hocsinh();




            }



        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if 
                (
                MessageBox.Show("Bạn có chắc chắn muốn xóa không","Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                chuc_nang cn = new chuc_nang
                      (
                       textboxmahocsinh.Text,
                       textBoxtenhocsinh.Text,
                       textBoxNgaysinh.Text,
                       textBoxgioitinh.Text,
                       ID,
                       textBoxtimkiem.Text



                      );

                cn.deletehocsinh();
                dataGridView1.DataSource = new hien_thi().table_hocsinh();






            }



        }

       

        private void textBoxtimkiem_TextChanged(object sender, EventArgs e)
        {
            chuc_nang cn = new chuc_nang
                                  (
                                   textboxmahocsinh.Text,
                                   textBoxtenhocsinh.Text,
                                   textBoxNgaysinh.Text,
                                   textBoxgioitinh.Text,
                                   ID,
                                   textBoxtimkiem.Text



                                  );

            
            dataGridView1.DataSource = cn.timkiem_hocsinh();


        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {
                chuc_nang cn = new chuc_nang
                    (
                     textboxmahocsinh.Text,
                     textBoxtenhocsinh.Text,
                     textBoxNgaysinh.Text,
                     textBoxgioitinh.Text,
                     ID,
                     textBoxtimkiem.Text



                    );


                cn.inserthocsinh();
                dataGridView1.DataSource = new hien_thi().table_hocsinh();

               


            }
            xoa_trang_textbox();
            kich_hoat_them_sua_xoa_vo_hieu_hoa_textbox_va_nut_luu_huy();



        }
    }
}
