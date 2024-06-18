using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_selection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //資料//
        string[] grade = {"大一","大二","大三","大四"};
        string[] sort = { "必修","選修" };
        string[] compulsory_grade1= { "工程概論", "計算機程式及實習", "微積分", "靜力學", "工程圖學" };
        string[] compulsory_grade2 = { "工程材料", "工程統計學", "工程數學", "工程數學電腦實習", "水文學", "動力學"};
        string[] compulsory_grade3 = { "工程地質", "地理資訊系統", "流體力學試驗", "基礎工程", "鋼筋混凝土" };
        string[] compulsory_grade4 = { "進階微積分", "耐震設計", "數值分析即無網格法","專題研究" };
        string[] elective_grade1 = { "施工學", "混凝土配比設計", "施工圖" };
        string[] elective_grade2 = { "運輸工程導論", "工程法規", "透水性材料分析" };
        string[] elective_grade3 = { "營建管理", "瀝青混凝土及配比設計", "鋼結構設計" };
        string[] elective_grade4 = { "C#程式設計", "水利工程實務", "衛星測量", "建築資訊模型" };
        string[] tempch2 = { };
        string[] tempch4 = { };
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp0.Items.Clear();
            temp1.Items.Clear();
            temp2.Items.Clear();
            temp3.Items.Clear();
            temp4.Items.Clear();
            temp5.Items.Clear();
            temp6.Items.Clear();
            temp7.Items.Clear();

            foreach (string a in compulsory_grade1)
            {
                temp0.Items.Add(a);
            }
            foreach (string a in compulsory_grade2)
            {
                temp1.Items.Add(a);
            }
            foreach (string a in compulsory_grade3)
            {
                temp2.Items.Add(a);
            }
            foreach (string a in compulsory_grade4)
            {
                temp3.Items.Add(a);
            }
            foreach (string a in elective_grade1)
            {
                temp4.Items.Add(a);
            }
            foreach (string a in elective_grade2)
            {
                temp5.Items.Add(a);
            }
            foreach (string a in elective_grade3)
            {
                temp6.Items.Add(a);
            }
            foreach (string a in elective_grade4)
            {
                temp7.Items.Add(a);
            }

            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            checkedListBox3.Items.Clear();
            checkedListBox4.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    checkedListBox1.Visible = true;
                    checkedListBox3.Visible = false;
                    foreach (string a in temp0.Items)
                    {
                       checkedListBox1.Items.Add(a);
                    }
                }
                else
                {
                    checkedListBox3.Visible = true;
                    checkedListBox1.Visible = false;
                    foreach (string a in temp4.Items)
                    {
                        checkedListBox3.Items.Add(a);
                    }
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    checkedListBox1.Visible = true;
                    checkedListBox3.Visible = false;
                    foreach (string a in temp1.Items)
                    {
                        checkedListBox1.Items.Add(a);
                    }
                }
                else
                {
                    checkedListBox3.Visible = true;
                    checkedListBox1.Visible = false;
                    foreach (string a in temp5.Items)
                    {
                        checkedListBox3.Items.Add(a);
                    }
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    checkedListBox1.Visible = true;
                    checkedListBox3.Visible = false;
                    foreach (string a in temp2.Items)
                    {
                        checkedListBox1.Items.Add(a);
                    }
                }
                else
                {
                    checkedListBox3.Visible = true;
                    checkedListBox1.Visible = false;
                    foreach (string a in temp6.Items)
                    {
                        checkedListBox3.Items.Add(a);
                    }
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    checkedListBox1.Visible = true;
                    checkedListBox3.Visible = false;
                    foreach (string a in temp3.Items)
                    {
                        checkedListBox1.Items.Add(a);
                    }
                }
                else
                {
                    checkedListBox3.Visible = true;
                    checkedListBox1.Visible = false;
                    foreach (string a in temp7.Items)
                    {
                        checkedListBox3.Items.Add(a);
                    }
                }
            }
         
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(grade);
            comboBox2.Items.AddRange(sort);
            checkedListBox1.CheckOnClick = true;
            checkedListBox2.CheckOnClick = true;
            checkedListBox3.CheckOnClick = true;
            checkedListBox4.CheckOnClick = true;
            comboBox1.SelectedIndex = 0;
            temp0.Items.Clear();
            temp1.Items.Clear();
            temp2.Items.Clear();
            temp3.Items.Clear();
            temp4.Items.Clear();
            temp5.Items.Clear();
            temp6.Items.Clear();
            temp7.Items.Clear();
            foreach (string a in compulsory_grade1)
            {
                temp0.Items.Add(a);
            }
            foreach (string a in compulsory_grade2)
            {
                temp1.Items.Add(a);
            }
            foreach (string a in compulsory_grade3)
            {
                temp2.Items.Add(a);
            }
            foreach (string a in compulsory_grade4)
            {
                temp3.Items.Add(a);
            }
            foreach (string a in elective_grade1)
            {
                temp4.Items.Add(a);
            }
            foreach (string a in elective_grade2)
            {
                temp5.Items.Add(a);
            }
            foreach (string a in elective_grade3)
            {
                temp6.Items.Add(a);
            }
            foreach (string a in elective_grade4)
            {
                temp7.Items.Add(a);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            checkedListBox1.Items.Clear();
            checkedListBox3.Items.Clear();

            if (comboBox2.SelectedIndex == 0)
            {
                checkedListBox1.Visible = true;
                checkedListBox3.Visible = false;
                if (comboBox1.SelectedIndex == 0)
                {
                    checkedListBox1.Items.AddRange(temp0.Items);

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkedListBox1.Items.AddRange(temp1.Items);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    checkedListBox1.Items.AddRange(temp2.Items);
                }
                else
                {
                    checkedListBox1.Items.AddRange(temp3.Items);
                }
            }
            else
            {
                checkedListBox1.Visible = false;
                checkedListBox3.Visible = true;
                if (comboBox1.SelectedIndex == 0)
                {
                    checkedListBox3.Items.AddRange(temp4.Items);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkedListBox3.Items.AddRange(temp5.Items);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    checkedListBox3.Items.AddRange(temp6.Items);
                }
                else
                {
                    checkedListBox3.Items.AddRange(temp7.Items);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0 && checkedListBox3.CheckedItems.Count == 0)
            {
                DialogResult result = MessageBox.Show("尚未選擇課程", "提示", MessageBoxButtons.YesNo);
            }
            else
            {
                DialogResult result = MessageBox.Show("確定加選?", "提示", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    checkedListBox2.Items.Clear();
                    checkedListBox4.Items.Clear();
                    foreach (string b in checkedListBox1.CheckedItems)
                    {
                        checkedListBox2.Items.Add(b);
                    }
                    foreach (string b in checkedListBox3.CheckedItems)
                    {
                        checkedListBox4.Items.Add(b);
                    }


                }
                else
                {

                }
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                for (int i = 0; i < checkedListBox3.Items.Count; i++)
                {
                    checkedListBox3.SetItemChecked(i, false);
                }
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetSelected(i, false);
                }
                for (int i = 0; i < checkedListBox3.Items.Count; i++)
                {
                    checkedListBox3.SetSelected(i, false);
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count == 0 && checkedListBox4.CheckedItems.Count == 0)
            {
                DialogResult result = MessageBox.Show("尚未選擇課程", "提示", MessageBoxButtons.YesNo);
            }
            else
            {
                DialogResult result = MessageBox.Show("確定退選?", "提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    foreach (string b in checkedListBox2.CheckedItems)
                    {
                        listBox1.Items.Add(b);
                    }
                    foreach (string b in checkedListBox4.CheckedItems)
                    {
                        listBox2.Items.Add(b);
                    }
                    foreach (string b in listBox1.Items)
                    {
                        checkedListBox2.Items.Remove(b);
                    }
                    foreach (string b in listBox2.Items)
                    {
                        checkedListBox4.Items.Remove(b);
                    }
                }
                else
                {
                }
                for (int i = 0; i < checkedListBox4.Items.Count; i++)
                {
                    checkedListBox4.SetItemChecked(i, false);
                }
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    checkedListBox2.SetItemChecked(i, false);
                }
                for (int i = 0; i < checkedListBox4.Items.Count; i++)
                {
                    checkedListBox4.SetSelected(i, false);
                }
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    checkedListBox2.SetSelected(i, false);
                }
            }
        }

        private void temp5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
 