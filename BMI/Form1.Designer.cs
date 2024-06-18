namespace BMI
{
    partial class BMI_Calculator
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
            this.lblTall = new System.Windows.Forms.Label();
            this.lblWeg = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.TBTall = new System.Windows.Forms.TextBox();
            this.TBWeg = new System.Windows.Forms.TextBox();
            this.lblBmiNum = new System.Windows.Forms.Label();
            this.btnOpt = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.BB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTall
            // 
            this.lblTall.AutoSize = true;
            this.lblTall.Font = new System.Drawing.Font("標楷體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTall.Location = new System.Drawing.Point(38, 51);
            this.lblTall.Name = "lblTall";
            this.lblTall.Size = new System.Drawing.Size(212, 48);
            this.lblTall.TabIndex = 0;
            this.lblTall.Text = "身高(cm)";
            // 
            // lblWeg
            // 
            this.lblWeg.AutoSize = true;
            this.lblWeg.Font = new System.Drawing.Font("標楷體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWeg.Location = new System.Drawing.Point(38, 200);
            this.lblWeg.Name = "lblWeg";
            this.lblWeg.Size = new System.Drawing.Size(212, 48);
            this.lblWeg.TabIndex = 1;
            this.lblWeg.Text = "體重(kg)";
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmi.Location = new System.Drawing.Point(38, 349);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(114, 55);
            this.lblBmi.TabIndex = 2;
            this.lblBmi.Text = "BMI";
            // 
            // TBTall
            // 
            this.TBTall.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTall.Location = new System.Drawing.Point(250, 51);
            this.TBTall.Name = "TBTall";
            this.TBTall.Size = new System.Drawing.Size(152, 45);
            this.TBTall.TabIndex = 3;
            this.TBTall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBTall.TextChanged += new System.EventHandler(this.TBTall_TextChanged);
            // 
            // TBWeg
            // 
            this.TBWeg.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBWeg.Location = new System.Drawing.Point(250, 200);
            this.TBWeg.Name = "TBWeg";
            this.TBWeg.Size = new System.Drawing.Size(152, 45);
            this.TBWeg.TabIndex = 4;
            this.TBWeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBmiNum
            // 
            this.lblBmiNum.AutoSize = true;
            this.lblBmiNum.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmiNum.Location = new System.Drawing.Point(250, 360);
            this.lblBmiNum.Name = "lblBmiNum";
            this.lblBmiNum.Size = new System.Drawing.Size(147, 37);
            this.lblBmiNum.TabIndex = 5;
            this.lblBmiNum.Text = "your BMI";
            this.lblBmiNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBmiNum.Click += new System.EventHandler(this.lblBmiNum_Click);
            // 
            // btnOpt
            // 
            this.btnOpt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOpt.Font = new System.Drawing.Font("標楷體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpt.ForeColor = System.Drawing.Color.Black;
            this.btnOpt.ImageKey = "(無)";
            this.btnOpt.Location = new System.Drawing.Point(600, 181);
            this.btnOpt.Name = "btnOpt";
            this.btnOpt.Size = new System.Drawing.Size(134, 64);
            this.btnOpt.TabIndex = 6;
            this.btnOpt.Text = "計算";
            this.btnOpt.UseVisualStyleBackColor = false;
            this.btnOpt.Click += new System.EventHandler(this.btnOpt_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEnd.Font = new System.Drawing.Font("標楷體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEnd.ForeColor = System.Drawing.Color.Crimson;
            this.btnEnd.ImageKey = "(無)";
            this.btnEnd.Location = new System.Drawing.Point(600, 324);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(134, 64);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // BB
            // 
            this.BB.AutoSize = true;
            this.BB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BB.Location = new System.Drawing.Point(722, 424);
            this.BB.Name = "BB";
            this.BB.Size = new System.Drawing.Size(66, 17);
            this.BB.TabIndex = 8;
            this.BB.Text = "B0621104";
            this.BB.Click += new System.EventHandler(this.label1_Click);
            // 
            // BMI_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BB);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnOpt);
            this.Controls.Add(this.lblBmiNum);
            this.Controls.Add(this.TBWeg);
            this.Controls.Add(this.TBTall);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.lblWeg);
            this.Controls.Add(this.lblTall);
            this.Name = "BMI_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTall;
        private System.Windows.Forms.Label lblWeg;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.TextBox TBTall;
        private System.Windows.Forms.TextBox TBWeg;
        private System.Windows.Forms.Label lblBmiNum;
        private System.Windows.Forms.Button btnOpt;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label BB;
    }
}

