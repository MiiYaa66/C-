﻿namespace MDI_form
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.射龍門ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拉霸機ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搖骰子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.遊戲ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 遊戲ToolStripMenuItem
            // 
            this.遊戲ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.射龍門ToolStripMenuItem,
            this.拉霸機ToolStripMenuItem,
            this.搖骰子ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.結束ToolStripMenuItem});
            this.遊戲ToolStripMenuItem.Name = "遊戲ToolStripMenuItem";
            this.遊戲ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.遊戲ToolStripMenuItem.Text = "遊戲";
            // 
            // 射龍門ToolStripMenuItem
            // 
            this.射龍門ToolStripMenuItem.Name = "射龍門ToolStripMenuItem";
            this.射龍門ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.射龍門ToolStripMenuItem.Text = "射龍門";
            this.射龍門ToolStripMenuItem.Click += new System.EventHandler(this.射龍門ToolStripMenuItem_Click);
            // 
            // 拉霸機ToolStripMenuItem
            // 
            this.拉霸機ToolStripMenuItem.Name = "拉霸機ToolStripMenuItem";
            this.拉霸機ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.拉霸機ToolStripMenuItem.Text = "拉霸機";
            this.拉霸機ToolStripMenuItem.Click += new System.EventHandler(this.拉霸機ToolStripMenuItem_Click);
            // 
            // 搖骰子ToolStripMenuItem
            // 
            this.搖骰子ToolStripMenuItem.Name = "搖骰子ToolStripMenuItem";
            this.搖骰子ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.搖骰子ToolStripMenuItem.Text = "搖骰子";
            this.搖骰子ToolStripMenuItem.Click += new System.EventHandler(this.搖骰子ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 射龍門ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拉霸機ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搖骰子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
    }
}

