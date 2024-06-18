namespace mid
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
            this.dicecup = new System.Windows.Forms.PictureBox();
            this.cupshake = new System.Timers.Timer();
            this.cupshakestop = new System.Timers.Timer();
            this.GAMBLE = new System.Windows.Forms.Button();
            this.chipgamble = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chipnumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chip1 = new System.Windows.Forms.PictureBox();
            this.chip2 = new System.Windows.Forms.PictureBox();
            this.chip3 = new System.Windows.Forms.PictureBox();
            this.chip4 = new System.Windows.Forms.PictureBox();
            this.chip5 = new System.Windows.Forms.PictureBox();
            this.chip6 = new System.Windows.Forms.PictureBox();
            this.chip7 = new System.Windows.Forms.PictureBox();
            this.chip8 = new System.Windows.Forms.PictureBox();
            this.chip9 = new System.Windows.Forms.PictureBox();
            this.chip10 = new System.Windows.Forms.PictureBox();
            this.bigger = new System.Windows.Forms.RadioButton();
            this.smaller = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dicecup2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dicecup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupshake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupshakestop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip10)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicecup2)).BeginInit();
            this.SuspendLayout();
            // 
            // dicecup
            // 
            this.dicecup.BackColor = System.Drawing.Color.Transparent;
            this.dicecup.Location = new System.Drawing.Point(430, 140);
            this.dicecup.Name = "dicecup";
            this.dicecup.Size = new System.Drawing.Size(119, 187);
            this.dicecup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dicecup.TabIndex = 0;
            this.dicecup.TabStop = false;
            // 
            // cupshake
            // 
            this.cupshake.Interval = 50D;
            this.cupshake.SynchronizingObject = this;
            this.cupshake.Elapsed += new System.Timers.ElapsedEventHandler(this.cupshake_Elapsed);
            // 
            // cupshakestop
            // 
            this.cupshakestop.Interval = 1800D;
            this.cupshakestop.SynchronizingObject = this;
            this.cupshakestop.Elapsed += new System.Timers.ElapsedEventHandler(this.cupshakestop_Elapsed);
            // 
            // GAMBLE
            // 
            this.GAMBLE.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GAMBLE.Location = new System.Drawing.Point(615, 329);
            this.GAMBLE.Name = "GAMBLE";
            this.GAMBLE.Size = new System.Drawing.Size(133, 49);
            this.GAMBLE.TabIndex = 1;
            this.GAMBLE.Text = "GAMBLE!!";
            this.GAMBLE.UseVisualStyleBackColor = true;
            this.GAMBLE.Click += new System.EventHandler(this.GAMBLE_Click);
            // 
            // chipgamble
            // 
            this.chipgamble.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chipgamble.Location = new System.Drawing.Point(247, 360);
            this.chipgamble.Name = "chipgamble";
            this.chipgamble.Size = new System.Drawing.Size(239, 36);
            this.chipgamble.TabIndex = 2;
            this.chipgamble.TextChanged += new System.EventHandler(this.chipgamble_TextChanged);
            this.chipgamble.Enter += new System.EventHandler(this.chipgamble_Enter);
            this.chipgamble.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chipgamble_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(66, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // chipnumber
            // 
            this.chipnumber.AutoSize = true;
            this.chipnumber.BackColor = System.Drawing.Color.Transparent;
            this.chipnumber.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chipnumber.Location = new System.Drawing.Point(95, 367);
            this.chipnumber.Name = "chipnumber";
            this.chipnumber.Size = new System.Drawing.Size(49, 24);
            this.chipnumber.TabIndex = 4;
            this.chipnumber.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(187, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "下注";
            // 
            // chip1
            // 
            this.chip1.BackColor = System.Drawing.Color.Transparent;
            this.chip1.Location = new System.Drawing.Point(24, 246);
            this.chip1.Name = "chip1";
            this.chip1.Size = new System.Drawing.Size(42, 64);
            this.chip1.TabIndex = 6;
            this.chip1.TabStop = false;
            // 
            // chip2
            // 
            this.chip2.BackColor = System.Drawing.Color.Transparent;
            this.chip2.Location = new System.Drawing.Point(64, 246);
            this.chip2.Name = "chip2";
            this.chip2.Size = new System.Drawing.Size(42, 64);
            this.chip2.TabIndex = 7;
            this.chip2.TabStop = false;
            // 
            // chip3
            // 
            this.chip3.BackColor = System.Drawing.Color.Transparent;
            this.chip3.Location = new System.Drawing.Point(101, 246);
            this.chip3.Name = "chip3";
            this.chip3.Size = new System.Drawing.Size(42, 64);
            this.chip3.TabIndex = 8;
            this.chip3.TabStop = false;
            // 
            // chip4
            // 
            this.chip4.BackColor = System.Drawing.Color.Transparent;
            this.chip4.Location = new System.Drawing.Point(140, 246);
            this.chip4.Name = "chip4";
            this.chip4.Size = new System.Drawing.Size(42, 64);
            this.chip4.TabIndex = 9;
            this.chip4.TabStop = false;
            // 
            // chip5
            // 
            this.chip5.BackColor = System.Drawing.Color.Transparent;
            this.chip5.Location = new System.Drawing.Point(182, 246);
            this.chip5.Name = "chip5";
            this.chip5.Size = new System.Drawing.Size(42, 64);
            this.chip5.TabIndex = 10;
            this.chip5.TabStop = false;
            // 
            // chip6
            // 
            this.chip6.BackColor = System.Drawing.Color.Transparent;
            this.chip6.Location = new System.Drawing.Point(219, 246);
            this.chip6.Name = "chip6";
            this.chip6.Size = new System.Drawing.Size(42, 64);
            this.chip6.TabIndex = 11;
            this.chip6.TabStop = false;
            // 
            // chip7
            // 
            this.chip7.BackColor = System.Drawing.Color.Transparent;
            this.chip7.Location = new System.Drawing.Point(260, 246);
            this.chip7.Name = "chip7";
            this.chip7.Size = new System.Drawing.Size(42, 64);
            this.chip7.TabIndex = 12;
            this.chip7.TabStop = false;
            // 
            // chip8
            // 
            this.chip8.BackColor = System.Drawing.Color.Transparent;
            this.chip8.Location = new System.Drawing.Point(295, 246);
            this.chip8.Name = "chip8";
            this.chip8.Size = new System.Drawing.Size(42, 64);
            this.chip8.TabIndex = 13;
            this.chip8.TabStop = false;
            // 
            // chip9
            // 
            this.chip9.BackColor = System.Drawing.Color.Transparent;
            this.chip9.Location = new System.Drawing.Point(331, 246);
            this.chip9.Name = "chip9";
            this.chip9.Size = new System.Drawing.Size(42, 64);
            this.chip9.TabIndex = 14;
            this.chip9.TabStop = false;
            // 
            // chip10
            // 
            this.chip10.BackColor = System.Drawing.Color.Transparent;
            this.chip10.Location = new System.Drawing.Point(373, 246);
            this.chip10.Name = "chip10";
            this.chip10.Size = new System.Drawing.Size(42, 64);
            this.chip10.TabIndex = 15;
            this.chip10.TabStop = false;
            // 
            // bigger
            // 
            this.bigger.AutoSize = true;
            this.bigger.BackColor = System.Drawing.Color.Transparent;
            this.bigger.Checked = true;
            this.bigger.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bigger.Location = new System.Drawing.Point(24, 21);
            this.bigger.Name = "bigger";
            this.bigger.Size = new System.Drawing.Size(74, 25);
            this.bigger.TabIndex = 16;
            this.bigger.TabStop = true;
            this.bigger.Text = "比大";
            this.bigger.UseVisualStyleBackColor = false;
            // 
            // smaller
            // 
            this.smaller.AutoSize = true;
            this.smaller.BackColor = System.Drawing.Color.Transparent;
            this.smaller.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.smaller.Location = new System.Drawing.Point(24, 57);
            this.smaller.Name = "smaller";
            this.smaller.Size = new System.Drawing.Size(74, 25);
            this.smaller.TabIndex = 17;
            this.smaller.TabStop = true;
            this.smaller.Text = "比小";
            this.smaller.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bigger);
            this.groupBox1.Controls.Add(this.smaller);
            this.groupBox1.Location = new System.Drawing.Point(597, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 94);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // dicecup2
            // 
            this.dicecup2.BackColor = System.Drawing.Color.Transparent;
            this.dicecup2.Location = new System.Drawing.Point(270, 120);
            this.dicecup2.Name = "dicecup2";
            this.dicecup2.Size = new System.Drawing.Size(64, 100);
            this.dicecup2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dicecup2.TabIndex = 19;
            this.dicecup2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.dicecup2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chip10);
            this.Controls.Add(this.chip9);
            this.Controls.Add(this.chip8);
            this.Controls.Add(this.chip7);
            this.Controls.Add(this.chip6);
            this.Controls.Add(this.chip5);
            this.Controls.Add(this.chip4);
            this.Controls.Add(this.chip3);
            this.Controls.Add(this.chip2);
            this.Controls.Add(this.chip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chipnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chipgamble);
            this.Controls.Add(this.GAMBLE);
            this.Controls.Add(this.dicecup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dicecup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupshake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupshakestop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chip10)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicecup2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dicecup;
        private System.Timers.Timer cupshake;
        private System.Timers.Timer cupshakestop;
        private System.Windows.Forms.Button GAMBLE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label chipnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chipgamble;
        private System.Windows.Forms.PictureBox chip10;
        private System.Windows.Forms.PictureBox chip9;
        private System.Windows.Forms.PictureBox chip8;
        private System.Windows.Forms.PictureBox chip7;
        private System.Windows.Forms.PictureBox chip6;
        private System.Windows.Forms.PictureBox chip5;
        private System.Windows.Forms.PictureBox chip4;
        private System.Windows.Forms.PictureBox chip3;
        private System.Windows.Forms.PictureBox chip2;
        private System.Windows.Forms.PictureBox chip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bigger;
        private System.Windows.Forms.RadioButton smaller;
        private System.Windows.Forms.PictureBox dicecup2;
    }
}

