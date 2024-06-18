namespace electricity_bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_bill = new System.Windows.Forms.Label();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.tb_bill = new System.Windows.Forms.TextBox();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.rdb_summer = new System.Windows.Forms.RadioButton();
            this.rdb_unsummer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_unopen = new System.Windows.Forms.RadioButton();
            this.rdb_open = new System.Windows.Forms.RadioButton();
            this.btn_cul = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_bill
            // 
            this.lbl_bill.AutoSize = true;
            this.lbl_bill.Font = new System.Drawing.Font("標楷體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_bill.Location = new System.Drawing.Point(123, 68);
            this.lbl_bill.Name = "lbl_bill";
            this.lbl_bill.Size = new System.Drawing.Size(129, 43);
            this.lbl_bill.TabIndex = 0;
            this.lbl_bill.Text = "度數:";
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Font = new System.Drawing.Font("標楷體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_sum.Location = new System.Drawing.Point(79, 164);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(173, 43);
            this.lbl_sum.TabIndex = 1;
            this.lbl_sum.Text = "總費用:";
            // 
            // tb_bill
            // 
            this.tb_bill.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_bill.Location = new System.Drawing.Point(259, 72);
            this.tb_bill.Name = "tb_bill";
            this.tb_bill.Size = new System.Drawing.Size(262, 40);
            this.tb_bill.TabIndex = 2;
            this.tb_bill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_sum
            // 
            this.tb_sum.Enabled = false;
            this.tb_sum.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_sum.Location = new System.Drawing.Point(259, 168);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(262, 40);
            this.tb_sum.TabIndex = 3;
            this.tb_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdb_summer
            // 
            this.rdb_summer.AutoSize = true;
            this.rdb_summer.Checked = true;
            this.rdb_summer.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_summer.Location = new System.Drawing.Point(19, 30);
            this.rdb_summer.Name = "rdb_summer";
            this.rdb_summer.Size = new System.Drawing.Size(81, 28);
            this.rdb_summer.TabIndex = 4;
            this.rdb_summer.TabStop = true;
            this.rdb_summer.Text = "夏季";
            this.rdb_summer.UseVisualStyleBackColor = true;
            // 
            // rdb_unsummer
            // 
            this.rdb_unsummer.AutoSize = true;
            this.rdb_unsummer.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_unsummer.Location = new System.Drawing.Point(19, 106);
            this.rdb_unsummer.Name = "rdb_unsummer";
            this.rdb_unsummer.Size = new System.Drawing.Size(106, 28);
            this.rdb_unsummer.TabIndex = 5;
            this.rdb_unsummer.Text = "非夏季";
            this.rdb_unsummer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rdb_unsummer);
            this.groupBox1.Controls.Add(this.rdb_summer);
            this.groupBox1.Location = new System.Drawing.Point(131, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 169);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_unopen);
            this.groupBox2.Controls.Add(this.rdb_open);
            this.groupBox2.Location = new System.Drawing.Point(345, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 169);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // rdb_unopen
            // 
            this.rdb_unopen.AutoSize = true;
            this.rdb_unopen.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_unopen.Location = new System.Drawing.Point(19, 106);
            this.rdb_unopen.Name = "rdb_unopen";
            this.rdb_unopen.Size = new System.Drawing.Size(106, 28);
            this.rdb_unopen.TabIndex = 5;
            this.rdb_unopen.Text = "非營業";
            this.rdb_unopen.UseVisualStyleBackColor = true;
            // 
            // rdb_open
            // 
            this.rdb_open.AutoSize = true;
            this.rdb_open.Checked = true;
            this.rdb_open.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdb_open.Location = new System.Drawing.Point(19, 30);
            this.rdb_open.Name = "rdb_open";
            this.rdb_open.Size = new System.Drawing.Size(81, 28);
            this.rdb_open.TabIndex = 4;
            this.rdb_open.TabStop = true;
            this.rdb_open.Text = "營業";
            this.rdb_open.UseVisualStyleBackColor = true;
            // 
            // btn_cul
            // 
            this.btn_cul.Font = new System.Drawing.Font("標楷體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cul.Location = new System.Drawing.Point(607, 231);
            this.btn_cul.Name = "btn_cul";
            this.btn_cul.Size = new System.Drawing.Size(149, 77);
            this.btn_cul.TabIndex = 10;
            this.btn_cul.Text = "計算";
            this.btn_cul.UseVisualStyleBackColor = true;
            this.btn_cul.Click += new System.EventHandler(this.btn_cul_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Font = new System.Drawing.Font("標楷體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_exit.Location = new System.Drawing.Point(607, 342);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(149, 77);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "離開";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_cul;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cul);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_sum);
            this.Controls.Add(this.tb_bill);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.lbl_bill);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electricity Bill Calculator";
            this.MinimumSizeChanged += new System.EventHandler(this.Form1_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bill;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.TextBox tb_bill;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.RadioButton rdb_summer;
        private System.Windows.Forms.RadioButton rdb_unsummer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_unopen;
        private System.Windows.Forms.RadioButton rdb_open;
        private System.Windows.Forms.Button btn_cul;
        private System.Windows.Forms.Button btn_exit;
    }
}

