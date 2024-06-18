using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electricity_bill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cul_Click(object sender, EventArgs e)
        {
            try
            {
                double bill = Convert.ToDouble(tb_bill.Text);
                if (rdb_open.Checked == true)
                {
                    if (rdb_summer.Checked == true)
                    {
                        double a = 2.53;
                        double b = 3.55;
                        double c = 4.25;
                        double d = 6.43;
                        if (bill <= 330)
                        {
                            double sum = bill * a;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 700)
                        {
                            double sum = (330 * a) + (bill - 330) * b;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 1500)
                        {
                            double sum = (330 * a) + (700 - 330) * b + (bill - 700) * c;
                            tb_sum.Text = sum.ToString();
                        }
                        else
                        {
                            double sum = (330 * a) + (700 - 330) * b + (1500 - 700) * c + (bill - 1500) * d;
                            tb_sum.Text = sum.ToString();
                        }
                    }
                    else
                    {
                        double a = 2.12;
                        double b = 2.91;
                        double c = 3.44;
                        double d = 5.05;
                        if (bill <= 330)
                        {
                            double sum = bill * a;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 700)
                        {
                            double sum = (330 * a) + (bill - 330) * b;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 1500)
                        {
                            double sum = (330 * a) + (700 - 330) * b + (bill - 700) * c;
                            tb_sum.Text = sum.ToString();
                        }
                        else
                        {
                            double sum = (330 * a) + (700 - 330) * b + (1500 - 700) * c + (bill - 1500) * d;
                            tb_sum.Text = sum.ToString();
                        }
                    }

                }
                else
                {
                    if (rdb_summer.Checked == true)
                    {
                        double a = 1.63;
                        double b = 2.38;
                        double c = 3.52;
                        double d = 4.80;
                        double f = 5.66;
                        double g = 6.41;
                        if (bill <= 120)
                        {
                            double sum = bill * a;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 330)
                        {
                            double sum = (120 * a) + (bill - 120) * b;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 500)
                        {
                            double sum = (120 * a) + (330 - 120) * b + (bill - 330) * c;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 700)
                        {
                            double sum = (120 * a) + (330 - 120) * b + (500 - 330) * c + (bill - 500) * d;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 1000)
                        {
                            double sum = (120 * a) + (330 - 120) * b + (500 - 330) * c + (700 - 500) * d + (bill - 700) * f;
                            tb_sum.Text = sum.ToString();
                        }
                        else
                        {
                            double sum = (120 * a) + (330 - 120) * b + (500 - 330) * c + (700 - 500) * d + (1000 - 700) * f + (bill - 1000) * g;
                            tb_sum.Text = sum.ToString();
                        }
                    }
                    else
                    {
                        double a = 1.63;
                        double b = 2.10;
                        double c = 2.89;
                        double d = 3.94;
                        double f = 4.6;
                        double g = 5.03;
                        if (bill <= 120)
                        {
                            double sum = bill * a;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 330)
                        {
                            double sum = (120 * a) + (bill - 120) * b;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 500)
                        {
                            double sum = (120 * a) + (330 - 120) * b + (bill - 330) * c;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 700)
                        {
                            double sum = (120 * a) + (330 - 120) * b + (500 - 330) * c + (bill - 500) * d;
                            tb_sum.Text = sum.ToString();
                        }
                        else if (bill <= 1000)
                        {
                            double sum = (120 * a) + (330 - 120) * b + (500 - 330) * c + (700 - 500) * d + (bill - 700) * f;
                            tb_sum.Text = sum.ToString();
                        }
                        else
                        {
                            double sum = (120 * a) + (330 - 120) * b + (500 - 330) * c + (700 - 500) * d + (1000 - 700) * f + (bill - 1000) * g;
                            tb_sum.Text = sum.ToString();
                        }
                    }
                }
            }
            catch 
            {
                string str = "請輸入數值";
                tb_sum.Text = str;

                MessageBox.Show("請輸入有效數值","錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
