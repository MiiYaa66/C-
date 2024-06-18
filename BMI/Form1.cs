using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class BMI_Calculator : Form
    {
        public BMI_Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBTall.Text))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (string.IsNullOrEmpty(TBWeg.Text))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            double v = Convert.ToDouble(TBWeg.Text) / (Convert.ToDouble(TBTall.Text) * Convert.ToDouble(TBTall.Text) / 10000);
            lblBmiNum.Text = v.ToString("#0.00");
        }

        private void TBTall_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblBmiNum_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
