using mid.Properties;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace mid
{
    public partial class Form1 : Form
    {
        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        //Random()以時間值為種子跑亂數，短時間重複執行高機率出現11134之類數字重複的情況
        //改以Guid.NewGuid()為種子產生不重複結果再進行雜湊產生亂數可以改善上述情況

        ResourceManager rm = new ResourceManager(typeof(Resources));      //宣告ResourceManger rm以取用Resources之資源
        Boolean bet = false;                                              //判斷是否下注;
        int move = 5;                                                     //骰盅動畫移動速度
        long chip;                                                        //賭金
        DialogResult call = DialogResult.OK;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            this.BackgroundImage = Resources.賭桌;   //載入時圖片顯示
            dicecup.Image = Resources.骰盅;             
            dicecup2.Image = Resources.骰盅2;

            chipgamble.Text = "單次下注上限100籌碼";       //下注提示文字
            chipgamble.ForeColor = Color.LightGray;

            chip = 100;                                    //持有籌碼(chip)初始化 預設100枚籌碼
            chipnumber.Text = Convert.ToString(chip);
        }

        private void GAMBLE_Click(object sender, EventArgs e)
        { 
            if (chipgamble.Text == "" || chipgamble.Text == "0" || !bet)
            {
                this.BackgroundImage = Resources.賭桌聳肩;
                DialogResult call = MessageBox.Show("沒下注就賭是想賭空氣嗎༼ っ ಠ‸ಠ ༽っ");
                ok();
            }
            else
            {
                cupshake.Enabled = true;
                cupshakestop.Enabled = true;
            }
        }

        private void cupshake_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            dicecup.Left += move;                                                           //骰盅動畫
            dicecup2.Left += move;
            if (dicecup.Left == 470 || dicecup.Left == 430)
                move = -move;
        }

        private void cupshakestop_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            cupshake.Enabled = false;
            cupshakestop.Enabled = false;

            int banker = rnd.Next(0, 6);
            int player = rnd.Next(0, 6);

            dicecup.Image = rm.GetObject("骰子點數" + Convert.ToString(player + 1)) as Image;
            dicecup2.Image = rm.GetObject("骰子點數" + Convert.ToString(banker + 1) + "2") as Image;

            if (smaller.Checked)                                                //比小
            {
                if (player < banker)
                {
                    chip += Convert.ToInt64(chipgamble.Text);
                    chipnumber.Text = Convert.ToString(chip);
                    this.BackgroundImage = Resources.賭桌鼓掌 ;
                    DialogResult call = MessageBox.Show("你贏了 " + chipgamble.Text + "籌碼 薛海");
                    ok();
                }
                else if (player > banker)
                {
                    chip -= Convert.ToInt64(chipgamble.Text);
                    chipnumber.Text = Convert.ToString(chip);
                    this.BackgroundImage = Resources.賭桌聳肩;
                    DialogResult call = MessageBox.Show("你輸了 " + chipgamble.Text + "籌碼 丟水溝啦");
                    ok();
                }
                else
                {
                    
                    this.BackgroundImage = Resources.賭桌流汗;
                    DialogResult call = MessageBox.Show("平手 再...再一把");
                    ok();
                }
            }
            else                                                                //比大
            {
                if (player > banker)
                {
                    chip += Convert.ToInt64(chipgamble.Text);
                    chipnumber.Text = Convert.ToString(chip);
                    this.BackgroundImage = Resources.賭桌鼓掌;
                    DialogResult call = MessageBox.Show("你贏了 " + chipgamble.Text + "籌碼 薛海");
                    ok();
                }
                else if (player < banker)
                {
                    chip -= Convert.ToInt64(chipgamble.Text);
                    chipnumber.Text = Convert.ToString(chip);
                    this.BackgroundImage = Resources.賭桌聳肩;
                    DialogResult call = MessageBox.Show("你輸了 " + chipgamble.Text + "籌碼 丟水溝啦");
                    ok();
                }
                else
                {
                    this.BackgroundImage = Resources.賭桌流汗;
                    DialogResult call = MessageBox.Show("平手 再...再一把");
                    ok();
                }
            }

            if (Convert.ToInt64(chipgamble.Text) > chip)                            //若持有金<上次下注 則下注=chip
            {
                chipgamble.Text = Convert.ToString(chip);
            }

            if (chip <= 0)                                                          //若持有金(chip)<=0 結束程式
            {
                
                this.BackgroundImage = Resources.賭桌再見;
                MessageBox.Show("你輸光了 回家洗洗睡 ༼ っ ಠ‸ಠ ༽っ");
                Environment.Exit(0);
            }
        }

        private void chipgamble_Enter(object sender, EventArgs e)
        {
            if (bet == false)
            {
                bet = true;
                chipgamble.Text = "";
                chipgamble.ForeColor = Color.Black;
            }
        }

        private void chipgamble_KeyPress(object sender, KeyPressEventArgs e)          //限制textbox1只能輸入數字(注音擋不到)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void chipgamble_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(chipgamble.Text, "[^0-9]") && bet)
            {
                this.BackgroundImage = Resources.賭桌警衛;
                DialogResult call = MessageBox.Show("再輸入非數字字元 我就叫保全把你扛出去");
                ok();

                chipgamble.Text = "";
            }

            try
            {
                if (Convert.ToInt64(chipgamble.Text) > 100 && chip >= 100)        //防止user輸入大於100賭金
                {
                    chipgamble.Text = Convert.ToString(100);
                    
                    this.BackgroundImage = Resources.賭桌食指;
                    DialogResult call = MessageBox.Show("單次下注上限100籌碼");
                    ok();
                }

                if (Convert.ToInt64(chipgamble.Text) > chip && chip < 100)        //防止user輸入大於持有金數目之賭金
                {
                    chipgamble.Text = Convert.ToString(chip);
                    this.BackgroundImage = Resources.賭桌插腰;
                    DialogResult call = MessageBox.Show("沒錢還想賭那麼多是想被剁手嗎༼ っ ಠ‸ಠ ༽っ");
                    ok();


                }
                Showchip(Convert.ToInt32(chipgamble.Text));
            }
            catch { }
        }
        private void Showchip(int chip)
        {
            PictureBox pb;                                                                  //宣告PictureBox pb以調用物件(PictureBox)chip1~10
            for (int i = 1; i <= 10; i++)
            {
                pb = (PictureBox)Controls.Find("chip" + Convert.ToString(i), true)[0];      //pb=chip1~10
                pb.Image = null;                                                            //清空Image
                if (chip / 10 >= i)
                {
                    pb.Image = rm.GetObject("bet10") as Image;
                }
                else if ((chip / 10) + 1 == i)
                {
                    pb.Image = rm.GetObject(Convert.ToString(chip % 10) + "籌碼") as Image;
                }
            }
        }

        private void ok()
        {
            dicecup.Image = Resources.骰盅;
            dicecup2.Image = Resources.骰盅2;

            if (call == DialogResult.OK)
            {
                this.BackgroundImage = Resources.賭桌;
            }
        }
    }
}