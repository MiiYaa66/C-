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
using System.Windows.Forms.VisualStyles;

namespace MidPrj
{
    public partial class Form2 : Form
    {
        int myMoney = 500;  //資本額
        int bet;            //下注金額
        int pool;           //底池
        int a, b, c, cMod;
        string cost;
        int min;
        //float percent1, percent2, percent3; //機率



        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = imageList1.Images[52];
            pictureBox2.Image = imageList1.Images[52];
            pictureBox3.Image = imageList1.Images[52];

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            //string cost = Microsoft.VisualBasic.Interaction.InputBox("投注彩券", "龍門下注");
            //label1.Text = Convert.ToString(Int32.Parse(cost) * 2);
            if(radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("請先選擇最低賭注！");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    min = 10;
                    if(pool == 0)
                    {
                        pool = 20;
                        myMoney -= 10;
                        label1.Text = Convert.ToString(pool);
                        label5.Text = Convert.ToString(myMoney);
                    }
                    else
                    {
                        pool += 10;
                        myMoney -= 10;
                        label1.Text = Convert.ToString(pool);
                        label5.Text = Convert.ToString(myMoney);
                    } 
                }
                if (radioButton2.Checked)
                {
                    min = 50;
                    if (pool == 0)
                    {
                        pool = 100;
                        myMoney -= 50;
                        label1.Text = Convert.ToString(pool);
                        label5.Text = Convert.ToString(myMoney);
                    }
                    else
                    {
                        pool += 50;
                        myMoney -= 50;
                        label1.Text = Convert.ToString(pool);
                        label5.Text = Convert.ToString(myMoney);
                    }
                }
                if (radioButton3.Checked)
                {
                    min = 100;
                    if (pool == 0)
                    {
                        pool = 200;
                        myMoney -= 100;
                        label1.Text = Convert.ToString(pool);
                        label5.Text = Convert.ToString(myMoney);
                    }
                    else
                    {
                        pool += 100;
                        myMoney -= 100;
                        label1.Text = Convert.ToString(pool);
                        label5.Text = Convert.ToString(myMoney);
                    }
                }


                a = rnd.Next(51);
                while (true)
                {
                    b = rnd.Next(51);
                    if (a == b) { continue; }
                    else { break; }
                }
                pictureBox1.Image = imageList1.Images[a];
                pictureBox3.Image = imageList1.Images[b];

                float t1 = a % 13;
                float t2 = b % 13;

                if (t1 > t2)
                {
                    Console.WriteLine(t1);
                    Console.WriteLine(t2);
                    Console.WriteLine("Here");

                    float percent1 = ((((t1) - (t2)) - 1) * 4) / 52 * 100;
                    float percent2 = (float)6 / 52*100;
                    Console.WriteLine(percent2);
                    float percent3 = 100 - percent1 - percent2;
                    label2.Text = percent1.ToString("f2") + "\t%";
                    label3.Text = percent2.ToString("f2") + "\t%";
                    label4.Text = percent3.ToString("f2") + "\t%";

                }
                else if (t1 < t2)
                {
                    Console.WriteLine(t1);
                    Console.WriteLine(t2);
                    Console.WriteLine("There");
                    float percent1 = ((((t2) - (t1)) - 1) * 4) / 52 * 100;
                    float percent2 = (float)6 / 52 * 100;
                    Console.WriteLine(percent2);
                    float percent3 = 100 - percent1 - percent2;
                    label2.Text = percent1.ToString("f2") + "\t%";
                    label3.Text = percent2.ToString("f2") + "\t%";
                    label4.Text = percent3.ToString("f2") + "\t%";
                }
                else
                {
                    Console.WriteLine(t1);
                    Console.WriteLine(t2);
                    float percent2 = (2 / 52) * 100;
                    label2.Text = "不好說";
                    label3.Text = percent2.ToString("f2") + "\t%";
                    label4.Text = "不好說";
                }


                DialogResult betOrNot = MessageBox.Show("勝敗一線間，決定棄牌將損失已投入底池金額\n*左側有參考機率*\n是：賭下去\n否：我放棄", "考慮階段", MessageBoxButtons.YesNo);
                if (betOrNot == DialogResult.Yes)
                {
                    while (true)
                    {
                        try
                        {
                            cost = Microsoft.VisualBasic.Interaction.InputBox("請輸入要下注金額\n最高：" + Convert.ToString(pool) + "\n最低："+ Convert.ToString(min)+"\n取消或輸入錯誤格式視為下注最高金額", "龍門下注");
                            bet = Int32.Parse(cost);
                            if (bet < min) { bet = min; }
                        }
                        catch
                        {
                            bet = pool;
                        }
                        if (bet > pool) { continue; }
                        else {
                            break;
                        }
                    }

                    myMoney -= bet;
                    pool += bet;
                    label1.Text = Convert.ToString(pool);
                    label5.Text = Convert.ToString(myMoney);




                    while (true)
                    {
                        c = rnd.Next(51);
                        if (c == b || c == a) { continue; }
                        else { break; }
                    }


                    a = a % 13;
                    b = b % 13;
                    cMod = c % 13;

                    if (a == b)
                    {



                        DialogResult bigOrSmall = MessageBox.Show("請選擇大或小", "考慮階段\n是：大\n否：小", MessageBoxButtons.YesNo);
                        pictureBox2.Image = imageList1.Images[c];
                        if (bigOrSmall == DialogResult.Yes)
                        {
                            if (cMod > a)
                            {
                                MessageBox.Show("贏啦", "結果");
                                myMoney += bet * 2;
                                pool -= bet * 2;
                                label1.Text = Convert.ToString(pool);
                                label5.Text = Convert.ToString(myMoney);
                            }
                            else if (cMod < a)
                            {
                                MessageBox.Show("輸啦", "結果");
                            }
                            else
                            {
                                MessageBox.Show("撞柱啦！\n賠三倍！！！", "結果");
                                myMoney -= bet * 2;
                                pool += bet * 2;
                                label1.Text = Convert.ToString(pool);
                                label5.Text = Convert.ToString(myMoney);
                            }
                        }
                        if (bigOrSmall == DialogResult.No)
                        {
                            if (cMod < a)
                            {
                                MessageBox.Show("贏啦", "結果");
                                myMoney += bet * 2;
                                pool -= bet * 2;
                                label1.Text = Convert.ToString(pool);
                                label5.Text = Convert.ToString(myMoney);
                            }
                            else if (cMod > a)
                            {
                                MessageBox.Show("輸啦", "結果");

                            }
                            else
                            {
                                MessageBox.Show("撞柱啦！\n賠三倍", "結果");
                                myMoney -= bet * 2;
                                pool += bet * 2;
                                label1.Text = Convert.ToString(pool);
                                label5.Text = Convert.ToString(myMoney);
                            }
                        }


                    }
                    else
                    {
                        pictureBox2.Image = imageList1.Images[c];
                        if (a == b || b == cMod || cMod == a)
                        {
                            MessageBox.Show("撞柱啦！\n賠兩倍！！！", "結果");
                            myMoney -= bet;
                            pool += bet;
                            label1.Text = Convert.ToString(pool);
                            label5.Text = Convert.ToString(myMoney);
                        }
                        else if ((cMod < a && cMod > b) || (cMod > a && cMod < b))
                        {
                            MessageBox.Show("贏啦", "結果");
                            myMoney += bet * 2;
                            pool -= bet * 2;
                            label1.Text = Convert.ToString(pool);
                            label5.Text = Convert.ToString(myMoney);
                        }
                        else
                        {
                            MessageBox.Show("輸啦", "結果");
                            
                        }
                    }

                }
                else if (betOrNot == DialogResult.No)
                {
                    MessageBox.Show("想要繼續玩，選好金額按下下注即可", "結果");
                }
                pictureBox1.Image = imageList1.Images[52];
                pictureBox2.Image = imageList1.Images[52];
                pictureBox3.Image = imageList1.Images[52];
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome", "https://reurl.cc/9XLAOj");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(myMoney);
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = imageList1.Images[10];\

            label1.Text = "請先下注";

        }
    }
}
