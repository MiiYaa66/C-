namespace Test
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdb_big = new System.Windows.Forms.RadioButton();
            this.rdb_small = new System.Windows.Forms.RadioButton();
            this.rb_max = new System.Windows.Forms.RadioButton();
            this.rb_middle = new System.Windows.Forms.RadioButton();
            this.rb_min = new System.Windows.Forms.RadioButton();
            this.cb_drink = new System.Windows.Forms.CheckBox();
            this.cb_egg = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.lbl_me = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "份量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "附餐";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(13, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "湯汁濃度";
            // 
            // rdb_big
            // 
            this.rdb_big.AutoSize = true;
            this.rdb_big.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_big.Location = new System.Drawing.Point(22, 24);
            this.rdb_big.Name = "rdb_big";
            this.rdb_big.Size = new System.Drawing.Size(140, 24);
            this.rdb_big.TabIndex = 3;
            this.rdb_big.TabStop = true;
            this.rdb_big.Text = "大碗(150元)\r\n";
            this.rdb_big.UseVisualStyleBackColor = true;
            // 
            // rdb_small
            // 
            this.rdb_small.AutoSize = true;
            this.rdb_small.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_small.Location = new System.Drawing.Point(189, 24);
            this.rdb_small.Name = "rdb_small";
            this.rdb_small.Size = new System.Drawing.Size(140, 24);
            this.rdb_small.TabIndex = 4;
            this.rdb_small.TabStop = true;
            this.rdb_small.Text = "小碗(100元)\r\n";
            this.rdb_small.UseVisualStyleBackColor = true;
            // 
            // rb_max
            // 
            this.rb_max.AutoSize = true;
            this.rb_max.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_max.Location = new System.Drawing.Point(22, 21);
            this.rb_max.Name = "rb_max";
            this.rb_max.Size = new System.Drawing.Size(50, 24);
            this.rb_max.TabIndex = 5;
            this.rb_max.TabStop = true;
            this.rb_max.Text = "濃";
            this.rb_max.UseVisualStyleBackColor = true;
            // 
            // rb_middle
            // 
            this.rb_middle.AutoSize = true;
            this.rb_middle.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_middle.Location = new System.Drawing.Point(139, 21);
            this.rb_middle.Name = "rb_middle";
            this.rb_middle.Size = new System.Drawing.Size(50, 24);
            this.rb_middle.TabIndex = 6;
            this.rb_middle.TabStop = true;
            this.rb_middle.Text = "中";
            this.rb_middle.UseVisualStyleBackColor = true;
            // 
            // rb_min
            // 
            this.rb_min.AutoSize = true;
            this.rb_min.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb_min.Location = new System.Drawing.Point(260, 21);
            this.rb_min.Name = "rb_min";
            this.rb_min.Size = new System.Drawing.Size(50, 24);
            this.rb_min.TabIndex = 7;
            this.rb_min.TabStop = true;
            this.rb_min.Text = "淡";
            this.rb_min.UseVisualStyleBackColor = true;
            // 
            // cb_drink
            // 
            this.cb_drink.AutoSize = true;
            this.cb_drink.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_drink.Location = new System.Drawing.Point(22, 24);
            this.cb_drink.Name = "cb_drink";
            this.cb_drink.Size = new System.Drawing.Size(131, 24);
            this.cb_drink.TabIndex = 8;
            this.cb_drink.Text = "飲料(20元)";
            this.cb_drink.UseVisualStyleBackColor = true;
            // 
            // cb_egg
            // 
            this.cb_egg.AutoSize = true;
            this.cb_egg.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_egg.Location = new System.Drawing.Point(189, 24);
            this.cb_egg.Name = "cb_egg";
            this.cb_egg.Size = new System.Drawing.Size(151, 24);
            this.cb_egg.TabIndex = 9;
            this.cb_egg.Text = "溏心蛋(20元)";
            this.cb_egg.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_drink);
            this.groupBox2.Controls.Add(this.cb_egg);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 62);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_big);
            this.groupBox1.Controls.Add(this.rdb_small);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 60);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_min);
            this.groupBox3.Controls.Add(this.rb_middle);
            this.groupBox3.Controls.Add(this.rb_max);
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 58);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_start.Location = new System.Drawing.Point(118, 346);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(130, 90);
            this.btn_start.TabIndex = 14;
            this.btn_start.Text = "確定";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_menu.Location = new System.Drawing.Point(411, 16);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(151, 33);
            this.lbl_menu.TabIndex = 15;
            this.lbl_menu.Text = "尚未點餐";
            // 
            // lbl_me
            // 
            this.lbl_me.AutoSize = true;
            this.lbl_me.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_me.Location = new System.Drawing.Point(414, 81);
            this.lbl_me.Name = "lbl_me";
            this.lbl_me.Size = new System.Drawing.Size(0, 28);
            this.lbl_me.TabIndex = 16;
            this.lbl_me.Click += new System.EventHandler(this.lbl_me_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            this.imageList1.Images.SetKeyName(7, "7.png");
            this.imageList1.Images.SetKeyName(8, "8.png");
            this.imageList1.Images.SetKeyName(9, "9.png");
            this.imageList1.Images.SetKeyName(10, "10.png");
            this.imageList1.Images.SetKeyName(11, "11.png");
            this.imageList1.Images.SetKeyName(12, "12.png");
            this.imageList1.Images.SetKeyName(13, "13.png");
            this.imageList1.Images.SetKeyName(14, "14.png");
            this.imageList1.Images.SetKeyName(15, "15.png");
            this.imageList1.Images.SetKeyName(16, "16.png");
            this.imageList1.Images.SetKeyName(17, "15.png");
            this.imageList1.Images.SetKeyName(18, "14.png");
            this.imageList1.Images.SetKeyName(19, "13.png");
            this.imageList1.Images.SetKeyName(20, "12.png");
            this.imageList1.Images.SetKeyName(21, "11.png");
            this.imageList1.Images.SetKeyName(22, "10.png");
            this.imageList1.Images.SetKeyName(23, "9.png");
            this.imageList1.Images.SetKeyName(24, "8.png");
            this.imageList1.Images.SetKeyName(25, "7.png");
            this.imageList1.Images.SetKeyName(26, "6.png");
            this.imageList1.Images.SetKeyName(27, "5.png");
            this.imageList1.Images.SetKeyName(28, "4.png");
            this.imageList1.Images.SetKeyName(29, "3.png");
            this.imageList1.Images.SetKeyName(30, "2.png");
            this.imageList1.Images.SetKeyName(31, "1.png");
            // 
            // pb6
            // 
            this.pb6.Image = global::Test.Properties.Resources.小拉麵;
            this.pb6.Location = new System.Drawing.Point(390, 236);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(208, 200);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 22;
            this.pb6.TabStop = false;
            this.pb6.Visible = false;
            // 
            // pb5
            // 
            this.pb5.Image = global::Test.Properties.Resources._0;
            this.pb5.Location = new System.Drawing.Point(760, 16);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(150, 150);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 21;
            this.pb5.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::Test.Properties.Resources.汽水;
            this.pb4.Location = new System.Drawing.Point(604, 236);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(77, 200);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 20;
            this.pb4.TabStop = false;
            this.pb4.Visible = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::Test.Properties.Resources.糖心蛋;
            this.pb2.Location = new System.Drawing.Point(604, 236);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(150, 200);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 19;
            this.pb2.TabStop = false;
            this.pb2.Visible = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::Test.Properties.Resources.汽水;
            this.pb3.Location = new System.Drawing.Point(760, 236);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(77, 200);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 18;
            this.pb3.TabStop = false;
            this.pb3.Visible = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::Test.Properties.Resources.大拉麵;
            this.pb1.Location = new System.Drawing.Point(390, 236);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(208, 200);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 17;
            this.pb1.TabStop = false;
            this.pb1.Visible = false;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_send.Location = new System.Drawing.Point(639, 164);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(96, 66);
            this.btn_send.TabIndex = 23;
            this.btn_send.Text = "送出";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Visible = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(935, 488);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbl_me);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小販拉麵";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdb_big;
        private System.Windows.Forms.RadioButton rdb_small;
        private System.Windows.Forms.RadioButton rb_max;
        private System.Windows.Forms.RadioButton rb_middle;
        private System.Windows.Forms.RadioButton rb_min;
        private System.Windows.Forms.CheckBox cb_drink;
        private System.Windows.Forms.CheckBox cb_egg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Label lbl_me;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.Button btn_send;
    }
}

