using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
            rdb_big.Checked = true;
            rb_max.Checked = true;
            pb5.Image = imageList1.Images[0];
            timer1.Enabled = true;
        }
        int k;
        private void s1()
        {
            int h = 0;
            for (h = 0; h <= 200; h += 20)
            {
                pb1.Size = new Size(160, h);
                DateTime t = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - t).TotalSeconds <= 0.1);
            }
        }
        private void s2()
        {
            int h = 0;
            for (h = 0; h <= 200; h += 20)
            {
                pb2.Size = new Size(110, h);
                DateTime t = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - t).TotalSeconds <= 0.1);
            }
        }
        private void s3()
        {
            int h = 0;
            for (h = 0; h <= 200; h += 20)
            {
                pb3.Size = new Size(77, h);
                DateTime t = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - t).TotalSeconds <= 0.1);
            }
        }
        private void s4()
        {
            int h = 0;
            for (h = 0; h <= 200; h += 20)
            {
                pb4.Size = new Size(77, h);
                DateTime t = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - t).TotalSeconds <= 0.1);
            }
        }
        private void s6()
        {
            int h = 0;
            for (h = 0; h <= 200; h += 20)
            {
                pb6.Size = new Size(160, h);
                DateTime t = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - t).TotalSeconds <= 0.1);
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_send.Visible = false;
            pb1.Visible = false; pb2.Visible = false; pb3.Visible = false; pb4.Visible = false;pb6.Visible = false;
            pb1.Size = new Size(0,0);
            pb2.Size = new Size(0, 0);
            pb3.Size = new Size(0, 0);
            pb4.Size = new Size(0, 0);
            pb6.Size = new Size(0, 0);
            int pay = 0;
            string menu = "";
            lbl_menu.Text= "以下是您的餐點內容:";
            if (rdb_big.Checked == true)
            {
                pay += 150;
                menu += "大碗拉麵 濃度:";
                pb1.Visible = true;
                
            }
            else
            {
                pay += 100;
                menu += "小碗拉麵 濃度:";
                pb6.Visible = true;
                
            }
            menu += (rb_max.Checked == true ? "濃\n" : (rb_middle.Checked == true ? "中\n" : "淡\n"));
            if (cb_drink.Checked == true)
            {
                pay += 20;
                menu += "飲料\n";
                if (cb_egg.Checked == true)
                {
                    pb3.Visible = true;
                    
                }
                else
                {
                    pb4.Visible = true;
                    
                }
            }
            if (cb_egg.Checked == true)
            {
                pay += 20;
                menu += "溏心蛋\n";
                pb2.Visible = true;
                
            }
            
            lbl_me.Text = menu.ToString() +" \n"+"總共:"+pay.ToString()+"元";
            if (rdb_big.Checked == true)
            {
                pb1.Visible = true; s1();
            }
            else
            {
                pb1.Visible = true; s6();
            }
            
            
            if (cb_egg.Checked == true)
            {
                pb2.Visible = true;
                s2();
            }
            
            if (cb_drink.Checked == true)
            {
                if (cb_egg.Checked == true)
                {
                    pb3.Visible = true;
                    s3();
                }
                
                else
                {
                    pb4.Visible = true;
                    s4();
                }
            }
            btn_send.Visible = true;
            
  

        }

        private void lbl_me_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //原本使用imageList1來做，但圖片解析度變得很低，為了美觀著想，
            //且以自己已學會的部分做選擇下，選擇用下面方法執行。
            //※將原本imageList的方式記錄下來如下，以供備用。
            //{
            //pb5.Image = imageList1.Image[k];
            //k++;
            //if (k > 31)
            //  k = 0;
            //}
            pb5.Image = Test.Properties.Resources._0;
            k++;
            if(k==0)
                pb5.Image = Test.Properties.Resources._0;
            if (k == 1)
                pb5.Image = Test.Properties.Resources._1;
            if (k == 2)
                pb5.Image = Test.Properties.Resources._2;
            if (k == 3)
                pb5.Image = Test.Properties.Resources._3;
            if (k == 4)
                pb5.Image = Test.Properties.Resources._4;
            if (k == 5)
                pb5.Image = Test.Properties.Resources._5;
            if (k == 6)
                pb5.Image = Test.Properties.Resources._6;
            if (k == 7)
                pb5.Image = Test.Properties.Resources._7;
            if (k == 8)
                pb5.Image = Test.Properties.Resources._8;
            if (k == 9)
                pb5.Image = Test.Properties.Resources._9;
            if (k == 10)
                pb5.Image = Test.Properties.Resources._10;
            if (k == 11)
                pb5.Image = Test.Properties.Resources._11;
            if (k == 12)
                pb5.Image = Test.Properties.Resources._12;
            if (k == 13)
                pb5.Image = Test.Properties.Resources._13;
            if (k == 14)
                pb5.Image = Test.Properties.Resources._14;
            if (k == 15)
                pb5.Image = Test.Properties.Resources._15;
            if (k == 16)
                pb5.Image = Test.Properties.Resources._16;
            if (k == 17)
                pb5.Image = Test.Properties.Resources._15;
            if (k == 18)
                pb5.Image = Test.Properties.Resources._14;
            if (k == 19)
                pb5.Image = Test.Properties.Resources._13;
            if (k == 20)
                pb5.Image = Test.Properties.Resources._12;
            if (k == 21)
                pb5.Image = Test.Properties.Resources._11;
            if (k == 22)
                pb5.Image = Test.Properties.Resources._10;
            if (k == 23)
                pb5.Image = Test.Properties.Resources._9;
            if (k == 24)
                pb5.Image = Test.Properties.Resources._8;
            if (k == 25)
                pb5.Image = Test.Properties.Resources._7;
            if (k == 26)
                pb5.Image = Test.Properties.Resources._6;
            if (k == 27)
                pb5.Image = Test.Properties.Resources._5;
            if (k == 28)
                pb5.Image = Test.Properties.Resources._4;
            if (k == 29)
                pb5.Image = Test.Properties.Resources._3;
            if (k == 30)
                pb5.Image = Test.Properties.Resources._2;
            if (k == 31)
                pb5.Image = Test.Properties.Resources._1;

            if (k > 31)
            {
                k = 0;
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("確認送出訂單", "!!", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
   
}
