namespace piture
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
            this.pb_5 = new System.Windows.Forms.PictureBox();
            this.pb_4 = new System.Windows.Forms.PictureBox();
            this.pb_3 = new System.Windows.Forms.PictureBox();
            this.pb_2 = new System.Windows.Forms.PictureBox();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_5
            // 
            this.pb_5.Location = new System.Drawing.Point(42, 171);
            this.pb_5.Name = "pb_5";
            this.pb_5.Size = new System.Drawing.Size(810, 413);
            this.pb_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_5.TabIndex = 4;
            this.pb_5.TabStop = false;
            // 
            // pb_4
            // 
            this.pb_4.Image = global::piture.Properties.Resources.萊恩;
            this.pb_4.Location = new System.Drawing.Point(717, 12);
            this.pb_4.Name = "pb_4";
            this.pb_4.Size = new System.Drawing.Size(135, 153);
            this.pb_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_4.TabIndex = 3;
            this.pb_4.TabStop = false;
            this.pb_4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pb_3
            // 
            this.pb_3.Image = global::piture.Properties.Resources.皮卡丘1;
            this.pb_3.Location = new System.Drawing.Point(275, 12);
            this.pb_3.Name = "pb_3";
            this.pb_3.Size = new System.Drawing.Size(135, 153);
            this.pb_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_3.TabIndex = 2;
            this.pb_3.TabStop = false;
            this.pb_3.Click += new System.EventHandler(this.pb_3_Click);
            // 
            // pb_2
            // 
            this.pb_2.Image = global::piture.Properties.Resources.史努比;
            this.pb_2.Location = new System.Drawing.Point(493, 12);
            this.pb_2.Name = "pb_2";
            this.pb_2.Size = new System.Drawing.Size(141, 153);
            this.pb_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_2.TabIndex = 1;
            this.pb_2.TabStop = false;
            this.pb_2.Click += new System.EventHandler(this.pb_2_Click);
            // 
            // pb_1
            // 
            this.pb_1.Image = global::piture.Properties.Resources.小新;
            this.pb_1.Location = new System.Drawing.Point(42, 12);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(150, 153);
            this.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_1.TabIndex = 0;
            this.pb_1.TabStop = false;
            this.pb_1.Click += new System.EventHandler(this.pb_1_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "小新.jpg");
            this.imageList.Images.SetKeyName(1, "史努比.jpg");
            this.imageList.Images.SetKeyName(2, "皮卡丘.jpg");
            this.imageList.Images.SetKeyName(3, "萊恩.jpg");
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.pb_5);
            this.Controls.Add(this.pb_4);
            this.Controls.Add(this.pb_3);
            this.Controls.Add(this.pb_2);
            this.Controls.Add(this.pb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_1;
        private System.Windows.Forms.PictureBox pb_2;
        private System.Windows.Forms.PictureBox pb_3;
        private System.Windows.Forms.PictureBox pb_4;
        private System.Windows.Forms.PictureBox pb_5;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timer;
    }
}

