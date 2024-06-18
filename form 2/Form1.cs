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

namespace form_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            richTextBox1.Visible = false;
            前景顏色ToolStripMenuItem.Enabled= false;
            另存新檔ToolStripMenuItem.Enabled = false;
            存檔ToolStripMenuItem.Enabled = false;
            openFileDialog1.Filter = "文書檔(*.rtf)|*.txt|所有檔案(*.*)|*.*";
            saveFileDialog1.Filter = "文書檔(*.rtf)|*.txt|所有檔案(*.*)|*.*";
            開啟檔案ToolStripMenuItem.Visible = false;
            文字ToolStripMenuItem.Enabled = false;
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            儲存檔案ToolStripMenuItem.Visible = false;
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\movie\IMG_9321.mov";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        string r;
        
        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a == 1 | a == 2)
            {
                DialogResult Result = MessageBox.Show("確認不保留目前檔案並開啟舊檔", "檔案", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Result == DialogResult.Yes)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamReader sr = new StreamReader(openFileDialog1.FileName);
                        richTextBox1.Text = sr.ReadToEnd();
                        r = openFileDialog1.FileName;
                    }
                }
            }
            else
            {
                a = 1;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    r = openFileDialog1.FileName;
                    richTextBox1.Visible = true;
                    前景顏色ToolStripMenuItem.Enabled = true;
                    背景顏色ToolStripMenuItem.Visible = true;
                    存檔ToolStripMenuItem.Enabled = true;
                }
            }
        }
        int a = 0;
        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                存檔ToolStripMenuItem.Enabled = true;
                r = saveFileDialog1.FileName;
            }
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 開啟新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a == 1 | a == 2)
            {
                DialogResult Result = MessageBox.Show("確認不保留目前檔案並開啟新檔", "檔案", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Result == DialogResult.Yes)
                {
                    richTextBox1.Text = "";
                }
            }
            a = 2;
            richTextBox1.Visible = true;
            前景顏色ToolStripMenuItem.Enabled = true;
            背景顏色ToolStripMenuItem.Visible = true;
            另存新檔ToolStripMenuItem.Enabled = true;
            存檔ToolStripMenuItem.Enabled = false;
           


        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int b = 0;
        private void 項目符號ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b++;
            if (b==1)
            {
                richTextBox1.SelectionBullet = true;
            }
            else
            {
                b = 0;
                richTextBox1.SelectionBullet = false;
            }
        }

        private void 前景顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor=colorDialog1.Color;

            }
        }

        private void 背景顏色ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
               Form1.ActiveForm.BackColor= colorDialog1.Color;
            }
        }

        private void 存檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                richTextBox1.SaveFile(r , RichTextBoxStreamType.PlainText);
            }
            if (a == 2)
            {
                richTextBox1.SaveFile(r , RichTextBoxStreamType.PlainText);
            }
        }

        private void 影片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            richTextBox1.Visible = false;
            前景顏色ToolStripMenuItem.Visible = false;

            另存新檔ToolStripMenuItem.Visible = false;
            存檔ToolStripMenuItem.Visible = false;
            openFileDialog1.Filter = "FLAC 音訊檔案(flac)|*.flac|MKA音訊檔案(*.mka)|*.mka|MKV音訊檔案(*.mkv)|*.mkv|MP4音訊檔案(*.m4a)|*.m4a|MP4視訊檔案(*.mp4;*.m4v;*.mp4v;*.3gp;*.3gpp;*.3g2;*.3gp2)|*.mp4;*.m4v;*.mp4v;*.3gp;*.3gpp;*.3g2;*.3gp2|QuickTime 影片檔案(*.mov)|*.mov|所有檔案(*.*)|*.*";
            saveFileDialog1.Filter = "FLAC 音訊檔案(flac)|*.flac|MKA音訊檔案(*.mka)|*.mka|MKV音訊檔案(*.mkv)|*.mkv|MP4音訊檔案(*.m4a)|*.m4a|MP4視訊檔案(*.mp4;*.m4v;*.mp4v;*.3gp;*.3gpp;*.3g2;*.3gp2)|*.mp4;*.m4v;*.mp4v;*.3gp;*.3gpp;*.3g2;*.3gp2|QuickTime 影片檔案(*.mov)|*.mov|所有檔案(*.*)|*.*";
            開啟新檔ToolStripMenuItem.Visible = false;
            開啟舊檔ToolStripMenuItem.Visible = false;
            開啟檔案ToolStripMenuItem.Visible = true;
            儲存檔案ToolStripMenuItem.Visible = true;
            儲存檔案ToolStripMenuItem.Enabled = false;
            文字ToolStripMenuItem.Enabled = true;
            影片ToolStripMenuItem.Enabled = false;
            axWindowsMediaPlayer1.Visible = true;
            編輯ToolStripMenuItem.Enabled = false;
            背景顏色ToolStripMenuItem.Enabled = false;

        }

        private void 撥放ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 文字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            開啟新檔ToolStripMenuItem.Visible = true;
            開啟舊檔ToolStripMenuItem.Visible = true;
            存檔ToolStripMenuItem.Visible = true;
            另存新檔ToolStripMenuItem.Visible = true;
            前景顏色ToolStripMenuItem.Enabled = false;
            另存新檔ToolStripMenuItem.Enabled = false;
            存檔ToolStripMenuItem.Enabled = false;
            openFileDialog1.Filter = "文書檔(*.rtf)|*.txt|所有檔案(*.*)|*.*";
            saveFileDialog1.Filter = "文書檔(*.rtf)|*.txt|所有檔案(*.*)|*.*";
            開啟檔案ToolStripMenuItem.Visible = false;
            文字ToolStripMenuItem.Enabled = false;
            影片ToolStripMenuItem.Enabled = true;
            axWindowsMediaPlayer1.Visible = false;
            編輯ToolStripMenuItem.Enabled = true;
            儲存檔案ToolStripMenuItem.Visible = false;
            背景顏色ToolStripMenuItem.Enabled = true;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void 開啟檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                r = openFileDialog1.FileName;
            }
            儲存檔案ToolStripMenuItem.Enabled = true;
        }

        private void 儲存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                r = openFileDialog1.FileName;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
