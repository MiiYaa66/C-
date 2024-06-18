using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm
{
    public partial class Mac : Form
    {
        public Mac()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GB1.Location = new Point(110, 6);
            GB2.Location = new Point(110, 6);
            GB3.Location = new Point(110, 6);
            listBox1.Location = new Point(110, 6);
            GB1.Visible = true;
            GB2.Visible = false;
            GB3.Visible = false;
            button2.BackColor = Color.LightGoldenrodYellow;
            button2.ForeColor = Color.Tomato;
            listBox1.Visible = false;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            price = 0;
            button16.Enabled = false;
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(7);
            label5.Text = "*最多只能預定到未來7天";

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"D:\sk2_1\user\麥當勞報報鈴聲 高音質版.mp3";
            wplayer.controls.play();
       

        }
        int price;
        private void button2_Click(object sender, EventArgs e)
        {
            GB1.Visible = true;
            GB2.Visible = false;
            GB3.Visible = false;
            listBox1.Visible = false;
            button2.BackColor = Color.LightGoldenrodYellow;
            button2.ForeColor = Color.Tomato;
            button3.BackColor = Color.Tomato;
            button3.ForeColor = Color.Snow;
            button4.BackColor = Color.Tomato;
            button4.ForeColor = Color.Snow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GB1.Visible = false;
            GB2.Visible = true;
            GB3.Visible = false;
            listBox1.Visible = false;
            button3.BackColor = Color.LightGoldenrodYellow;
            button2.BackColor = Color.Tomato; button4.BackColor = Color.Tomato;
            button2.ForeColor = Color.Snow; button4.ForeColor = Color.Snow;
            button3.ForeColor = Color.Tomato;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GB1.Visible = false;
            GB2.Visible = false;
            GB3.Visible = true;
            listBox1.Visible = false;
            button4.BackColor = Color.LightGoldenrodYellow;
            button3.BackColor = Color.Tomato;
            button2.BackColor = Color.Tomato;
            button2.ForeColor = Color.Snow;
            button3.ForeColor = Color.Snow;
            button4.ForeColor = Color.Tomato;
        }

        private void GB1_Enter(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            GB1.Visible = false;
            GB2.Visible = false;
            GB3.Visible = false;
            listBox1.Visible =  true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (comboBox1.SelectedIndex==0)
            {
                price +=  79;
                listBox1.Items.Add("大麥克 單點  $79");
            }
            else if(comboBox1.SelectedIndex==1)
            {
                price += 129;
                listBox1.Items.Add("大麥克 套餐A  $129");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                price += 139;
                listBox1.Items.Add("大麥克 套餐B  $139");
            }
            else 
            {
                price += 149;
                listBox1.Items.Add("大麥克 套餐C  $149");
            }
            button1.Text = "$" + Convert.ToString(price);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (comboBox2.SelectedIndex == 0)
            {
                price += 69;
                listBox1.Items.Add("雙層牛肉吉士堡 單點  $69");
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                price += 119;
                listBox1.Items.Add("雙層牛肉吉士堡 套餐A  $119");
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                price += 129;
                listBox1.Items.Add("雙層牛肉吉士堡 套餐B  $129"); ;
            }
            else
            {
                price += 139;
                listBox1.Items.Add("雙層牛肉吉士堡 套餐C  $139");
            }
            button1.Text = "$" + Convert.ToString(price);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (comboBox3.SelectedIndex == 0)
            {
                price += 89;
                listBox1.Items.Add("麥脆雞 單點  $89");
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                price += 139;
                listBox1.Items.Add("麥脆雞 套餐A  $139");
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                price += 149;
                listBox1.Items.Add("麥脆雞 套餐B  $149");
            }
            else
            {
                price += 159;
                listBox1.Items.Add("麥脆雞 套餐C  $159");
            }
            button1.Text = "$" + Convert.ToString(price);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (comboBox4.SelectedIndex == 0)
            {
                price += 99;
                listBox1.Items.Add("凱薩脆雞沙拉 單點  $99");
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                price += 149;
                listBox1.Items.Add("凱薩脆雞沙拉 套餐A  $149");
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                price += 159;
                listBox1.Items.Add("凱薩脆雞沙拉 套餐B  $159");
            }
            else
            {
                price += 169;
                listBox1.Items.Add("凱薩脆雞沙拉 套餐C  $169");
            }
            button1.Text = "$" + Convert.ToString(price);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;

            price += 49;
            listBox1.Items.Add("4塊麥克雞塊  $49");
            button1.Text = "$" + Convert.ToString(price);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            listBox1.Items.Add("蘋果派  $28");
            price += 28;

            button1.Text = "$" + Convert.ToString(price);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            listBox1.Items.Add("蛋捲冰淇淋  $18");
            price += 18;

            button1.Text = "$" + Convert.ToString(price);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            listBox1.Items.Add("冰炫風  $55");
            price += 55;

            button1.Text = "$" + Convert.ToString(price);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (comboBox5.SelectedIndex == 0)
            {
                price += 25;
                listBox1.Items.Add("可樂 小杯  $25");
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                price += 33;
                listBox1.Items.Add("可樂 中杯  $33");
            }
            else
            {
                price += 40;
                listBox1.Items.Add("可樂 大杯  $40");
            }
            button1.Text = "$" + Convert.ToString(price);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (comboBox6.SelectedIndex == 0)
            {
                price += 25;
                listBox1.Items.Add("雪碧 小杯  $25");
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                price += 33;
                listBox1.Items.Add("雪碧 中杯  $33");
            }
            else
            {
                price += 40;
                listBox1.Items.Add("雪碧 大杯  $40");
            }
            button1.Text = "$" + Convert.ToString(price);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (comboBox7.SelectedIndex == 0)
            {
                price += 25;
                listBox1.Items.Add("檸檬紅茶 小杯  $25");
            }
            else if (comboBox7.SelectedIndex == 1)
            {
                price += 33;
                listBox1.Items.Add("檸檬紅茶 中杯  $33");
            }
            else
            {
                listBox1.Items.Add("檸檬紅茶 大杯  $40");
                price += 40;
            }
            button1.Text = "$" + Convert.ToString(price);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = ""; 
            int[] R1 = new int[8];
            int seed = (int)DateTime.Now.Ticks;
            Random ran = new Random(seed);
            for (int x = 1; x <= 8; x++)
            {
                R1[x - 1] = ran.Next(1, 9);
                label1.Text+= Convert.ToString(R1[x - 1]);
            }
            if (price == 0)
            {
                MessageBox.Show("尚未點選餐點", "提醒!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult Result = MessageBox.Show("總共為$" + price + "\n" + "\n" + "取餐時間:\n" + dateTimePicker1.Text + "\n" + numericUpDown1.Value + "時" + numericUpDown2.Value + "分" + "\n" + " 取餐序號: " + label1.Text, "確定付款", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                if( Result == DialogResult.OK)
                {
                    MessageBox.Show("已完成訂單", "已完成", MessageBoxButtons.OK);
                    price = 0;

                    button1.Text = "尚未點餐";
                    listBox1.Items.Clear();
                    button16.Enabled = false;
                    WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                    wplayer.URL = @"D:\sk2_1\user\麥當勞報報鈴聲 高音質版.mp3";
                    wplayer.controls.play();


                }
            }
           
                
                    
        }

        private void button16_Click(object sender, EventArgs e)
        {
            price = 0;
            button1.Text = "尚未點餐";
            listBox1.Items.Clear();
            button16.Enabled = false;
        }

        private void GB2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
