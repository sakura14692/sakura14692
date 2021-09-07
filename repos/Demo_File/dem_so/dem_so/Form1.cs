using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dem_so
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] Ones = {"Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
            string[] Tens = { "Mười", "Hai mươi", "Ba mươi", "Bốn mươi", "Năm mươi", "Sáu mươi", "Bảy mươi", "Tám mươi", "Chín mươi" };
            string[] Zero = { "Lẻ" };
           

            try
            {
               
                long no = long.Parse(textBox1.Text);
                long kiemtra_Zero = long.Parse(textBox1.Text);
                string flag="";


                string strWords = "";

                if (no > 99999999999 && no < 1000000000000)
                {
                    int i = (int)(no / 100000000000);
                    strWords = strWords + Ones[i - 1] + " trăm tỷ ";
                    no = no % 100000000000;
                }

                if (no > 9999999999 && no < 100000000000)
                {
                    int i = (int)(no / 10000000000);
                    strWords = strWords + Ones[i - 1] + " mươi tỷ ";
                    no = no % 10000000000;
                }

                if (no > 999999999 && no < 10000000000)
                {
                    int i = (int)(no / 1000000000);
                    strWords = strWords + Ones[i - 1] + " tỷ ";
                    no = no % 1000000000;
                }

                if (no > 99999999 && no < 1000000000)
                {
                    int i = (int)(no / 100000000);
                    strWords = strWords + Ones[i - 1] + " trăm triệu ";
                    no = no % 100000000;
                }


                if (no > 9999999 && no < 100000000)
                {
                    int i = (int)(no / 10000000);
                    strWords = strWords + Ones[i - 1] + " mươi triệu ";
                    no = no % 10000000;
                }


                if (no > 999999 && no < 10000000)
                {
                    int i = (int)(no / 1000000);
                    strWords = strWords + Ones[i - 1] + " triệu ";
                    no = no % 1000000;
                }

                if (no > 99999 && no < 1000000)
                {
                    int i = (int)(no / 100000);
                    strWords = strWords + Ones[i - 1] + " trăm nghìn ";
                    no = no % 100000;
                }

                if (no > 9999 && no < 100000)
                {
                    int i = (int)(no / 10000);
                    strWords = strWords + Ones[i - 1] + " mươi nghìn ";
                    no = no % 10000;
                }

                if (no > 999 && no < 10000)
                {
                    int i = (int)(no / 1000);
                    strWords = strWords + Ones[i - 1] + " ngàn ";
                    no = no % 1000;
                }


                if (no > 99 && no < 1000)
                {
                    int i = (int)(no / 100);
                    strWords = strWords + Ones[i - 1] + " trăm ";
                    no = no % 100;
                    
                }


                if (no > 19 && no < 100)
                {
                    int i = (int)(no / 10);
                    strWords = strWords + Tens[i - 1] + " ";
                    no = no % 10;
                    flag = "1";
                }

                if (no > 0 && no < 20)
                {
                    if (flag == "1") strWords = strWords + Ones[no - 1];

                    if (flag != "1") strWords = strWords + Zero[0] + " " + Ones[no - 1];
                    if ((strWords == Zero[0] + " " + Ones[no - 1]) & kiemtra_Zero < 10 & kiemtra_Zero > 0)
                    {
                        strWords = Ones[no - 1];

                    }

                }


                if (kiemtra_Zero % 10000!=0) { strWords = strWords.Replace("mươi nghìn", ""); }
                strWords = strWords.Replace("Một mươi", "Mười");
                if(kiemtra_Zero % 100000 != 0) { strWords = strWords.Replace("trăm nghìn", "trăm"); }
                if (kiemtra_Zero % 10000000 != 0) { strWords = strWords.Replace("mươi triệu", "mươi"); }
                if (kiemtra_Zero % 100000000 != 0 & kiemtra_Zero / 10000000 <100  ) { strWords = strWords.Replace("trăm triệu", "trăm"); }
                if (kiemtra_Zero % 10000000000 != 0) { strWords = strWords.Replace("mươi tỷ", "mươi"); }
                if (kiemtra_Zero % 100000000000 != 0) { strWords = strWords.Replace("trăm tỷ", "trăm"); }
                strWords = strWords.Replace("trăm Năm ngàn","Trăm lẻ Năm Ngàn");


                label1.Text = strWords;





            }

            catch (Exception)
            {
                label1.Text = "";

            };








        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "125555";
            textBox1.Text = a;
        }
    }
}
