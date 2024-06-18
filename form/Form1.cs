using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle=FormBorderStyle.FixedSingle;
            openFileDialog1.Filter = "圖檔(*.jpg)|*.jpg";
            saveFileDialog1.Filter = "圖檔(*.jpg)|*.jpg";
            pictureBox1.Size = new Size(420, 248);
            pictureBox1.Location = new Point(92, 79);
          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (p > 0 && p<=o)
            {
                p--;
                pictureBox1.Image = imageList1.Images[p];
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        PictureBox[] pic = new PictureBox[30];
        int p = -1;
        int o = -1;
        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imageList1.Images.Add(pictureBox1.Image);
                o++;
                p++;
                str[p] = openFileDialog1.SafeFileName;

                pictureBox1.Image.Save(Application.StartupPath +@"\pic\" + openFileDialog1.SafeFileName);

                
            }
           
            
        }
        string[] str = new string[30];
        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
             pictureBox1.Image.Save(saveFileDialog1.FileName);

            }
           
        }
        int x;
   
        int r=0;
        private void 大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(420,248);
            if (r==1)
            {
                pictureBox1.Location = new Point(10, 79);
            }
            if (r==2 | r == 0)
            {
                pictureBox1.Location = new Point(92, 79);
            }
            if (r == 3)
            {
                pictureBox1.Location = new Point(170, 79);
            }


        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(210, 124);
            if (r == 1)
            {
                pictureBox1.Location = new Point(10,141);
            }
            if (r == 2|r==0)
            {
                pictureBox1.Location = new Point(197,141);
            }
            if (r == 3)
            {
                pictureBox1.Location = new Point(380,141);
            }

        }

        private void 小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(105, 62);
            if (r == 1)
            {
                pictureBox1.Location = new Point(10, 172);
            }
            if (r == 2 | r == 0)
            {
                pictureBox1.Location = new Point(250, 141);
            }
            if (r == 3)
            {
                pictureBox1.Location = new Point(480, 141);
            }

        }

        private void 置左ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r = 1;
            x = 10;
            if (pictureBox1.Size == new Size(105, 62))
            {
                pictureBox1.Location = new Point(x, 172);
            }
            if (pictureBox1.Size == new Size(210, 124))
            {
                pictureBox1.Location = new Point(x, 141);
            }
            if (pictureBox1.Size == new Size(420, 248))
            {
                pictureBox1.Location = new Point(x, 79);
            }
        }

        private void 置中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r = 2;
            if (pictureBox1.Size==new Size(105,62))
            {
                pictureBox1.Location = new Point(250, 172);
            }
            if (pictureBox1.Size == new Size(210, 124))
            {
                pictureBox1.Location = new Point(197, 141);
            }
            if (pictureBox1.Size == new Size(420, 248))
            {
                pictureBox1.Location = new Point(92, 79);
            }
        }

        private void 置右ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r = 3;
            if (pictureBox1.Size == new Size(105, 62))
            {
                pictureBox1.Location = new Point(480, 172);
            }
            if (pictureBox1.Size == new Size(210, 124))
            {
                pictureBox1.Location = new Point(380, 141);
            }
            if (pictureBox1.Size == new Size(420, 248))
            {
                pictureBox1.Location = new Point(170, 79);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (p < o && p>-1)
            {
                p++;
                pictureBox1.Image = imageList1.Images[p];
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void toolStripTextBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void toolStripTextBox2_TextBoxTextAlignChanged(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int i=0;i<o;i++)
            {
                if (str[i] == toolStripTextBox2.Text + ".jpg")
                {
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\pic\" + toolStripTextBox2.Text + ".jpg");
                }
            }

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            toolStripTextBox2.Text = "";
        }
    }
}
