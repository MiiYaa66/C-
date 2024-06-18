using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專案
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] num = new int[5];
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            button6.Size = new Size(80, 80);
            System.Drawing.Drawing2D.GraphicsPath aCircle = new System.Drawing.Drawing2D.GraphicsPath();
            aCircle.AddEllipse(new Rectangle(0, 0, 80, 80));
            button6.Region = new Region(aCircle);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            if (num > 1)
                num -= 1;
            else
                num = 1;
            textBox1.Text = Convert.ToString(num);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            if (num < 20)
                num += 1;
            else
                num = 20;
            textBox1.Text = Convert.ToString(num);
        }

        private void all_in_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(label4.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox1.Enabled = true;
            textBox1.ReadOnly = false;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
        }

        bool MoveFlag = false;
        int yPos;

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFlag = true;//已經按下.
            yPos = e.Y;//當前y座標.
        }
        private void pic_click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveFlag)
                if(button6.Location.Y < 160&& button6.Location.Y > 38)
                {
                    int h = button7.Size.Height;
                    button6.Top += Convert.ToInt16(e.Y - yPos);//設定y座標
                    button7.Top += Convert.ToInt16(e.Y - yPos);
                    h -= Convert.ToInt16(e.Y - yPos);
                    button7.Size = new Size(button7.Size.Width, h);
                }
        }
        int num1, num2, num3;
        Random ran = new Random();
        private void start(object sender, MouseEventArgs e)
        {
            if (administrator)
            {
                MoveFlag = false;
                timer2.Enabled = true;
                textBox1.Enabled = false;
                num1 = ran.Next(4);
                num2 = ran.Next(4);
                num3 = ran.Next(4);
                timer1.Enabled = true;
            }
            else
            {
                MoveFlag = false;
                timer2.Enabled = true;
                if (button6.Location.Y > 150)
                    if (Convert.ToInt32(textBox1.Text) > 0 && Convert.ToInt32(textBox1.Text) <= Convert.ToInt32(label4.Text))
                    {
                        textBox1.Enabled = false;
                        num1 = ran.Next(4);
                        num2 = ran.Next(4);
                        num3 = ran.Next(4);
                        timer1.Enabled = true;
                    }
                    else if (Convert.ToInt32(textBox1.Text) < 0)
                        MessageBox.Show("請輸入投注金額!!", "投注錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(label4.Text) && Convert.ToInt32(label4.Text) != 0)
                        MessageBox.Show("錢不夠哦!!", "投注錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (button6.Location.Y > 39)
            {
                button6.Top -= 2;
                button7.Top -= 2;
                button7.Size = new Size(button7.Size.Width, button7.Size.Height + 2);
            }
            else if (button6.Location.Y < 39)
            {
                button6.Top = 39;
                button7.Top = 79;
            }
            else if (button6.Location.Y == 39)
                timer2.Enabled = false;
        }
        bool administrator = false;
        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12 && administrator)
            {
                label4.Visible = true;
                label2.Text = "持有金額：";
                administrator = false;
            }
            else if (e.KeyCode == Keys.F12)
            {
                label4.Visible = false;
                label2.Text = "管理員模式";
                administrator = true;
            }
        }
        bool three = false;

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                three = true;
            }
        }

        int t = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            int a = 0, b = 0, c = 0;
            do
            {
                a = ran.Next(4); b = ran.Next(4); c = ran.Next(4);
                pictureBox3.Image = imageList1.Images[a];
                pictureBox4.Image = imageList1.Images[b];
                pictureBox5.Image = imageList1.Images[c];
            } while (a == b && b == c);

            if (t == 20)
            {
                timer1.Enabled = false;
                textBox1.Enabled = true;
                if (three)
                {
                    pictureBox3.Image = imageList1.Images[num1];
                    pictureBox4.Image = imageList1.Images[num1];
                    pictureBox5.Image = imageList1.Images[num1];
                    int score = Convert.ToInt32(textBox1.Text) * 10;
                    label4.Text = Convert.ToString(score + Convert.ToInt32(label4.Text));
                    textBox2.Text = Convert.ToString(score);
                    three = false;
                }
                else if (num1 == num2 && num2 == num3)
                {
                    pictureBox3.Image = imageList1.Images[num1];
                    pictureBox4.Image = imageList1.Images[num1];
                    pictureBox5.Image = imageList1.Images[num1];
                    int score = Convert.ToInt32(textBox1.Text) * 10;
                    label4.Text = Convert.ToString(score + Convert.ToInt32(label4.Text));
                    textBox2.Text = Convert.ToString(score);
                }
                else
                {
                    if (administrator != true)
                        label4.Text = Convert.ToString(Convert.ToInt32(label4.Text) - Convert.ToInt32(textBox1.Text));
                    textBox2.Text = "0";
                    if (Convert.ToInt32(label4.Text) == 0 && administrator != true)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(Application.StartupPath + "\\GAME_OVER.png");
                        pic.Size = new Size(592, 404);
                        pic.Location = new Point(0, 0);
                        pic.SizeMode = PictureBoxSizeMode.CenterImage;
                        pic.Click += new System.EventHandler(pic_click);
                        this.Controls.Add(pic);
                        pic.BringToFront();
                    }
                }
                t = 0;
            }
        }
    }
}
