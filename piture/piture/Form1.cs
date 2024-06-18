using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pb_5.Image = pb_4.Image;
            ss();
        }

        private void pb_1_Click(object sender, EventArgs e)
        {
            pb_5.Image = pb_1.Image;
            ss();
        }

        private void pb_3_Click(object sender, EventArgs e)
        {
            pb_5.Image = pb_3.Image;
            ss();
        }

        private void pb_2_Click(object sender, EventArgs e)
        {
            pb_5.Image = pb_2.Image;
            ss();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void ss()
        {
            int h = 0;
            for (h = 0; h <= 413; h += 30)
            {
                pb_5.Size = new Size(710, h);
                DateTime t = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - t).TotalSeconds <= 0.2);
            }
        }
    }
}
