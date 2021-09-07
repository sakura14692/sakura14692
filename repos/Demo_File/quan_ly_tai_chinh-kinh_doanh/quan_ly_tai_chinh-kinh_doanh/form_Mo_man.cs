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
    public partial class form_Mo_man : DevExpress.XtraEditors.XtraForm
    {
        public form_Mo_man()
        {
            InitializeComponent();
        }

        private void form_Mo_man_Load(object sender, EventArgs e)
        {
            timer_form_Mo_man.Start();
        }
        int i=-1;
        string[] gioi_thieu = {
            "Phần mềm","quản lý","tài chính - kinh doanh","version 1.1",
            "sản xuất","bởi TrungproGroup","","","","","" 
        };
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;labelControl_Dem_thoi_gian.Text = i.ToString();
            labelControl_Gioi_thieu.Text =labelControl_Gioi_thieu.Text+" "+ gioi_thieu[i];
            if (i == 10) { this.Hide(); new form_Main_tai_chinh_Kinh_doanh().Show();timer_form_Mo_man.Stop(); }
            //if (i == 7) labelControl_Gioi_thieu.Appearance.Font= new Font("Arial", 18);
        }

        
    }
}