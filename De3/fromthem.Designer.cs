namespace De3
{
    partial class fromthem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbqq = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ma";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(108, 37);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(243, 22);
            this.txtma.TabIndex = 2;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(108, 79);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(243, 22);
            this.txtten.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ten";
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(108, 122);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(243, 22);
            this.txtngaysinh.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "ngay sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Que quan";
            // 
            // cbqq
            // 
            this.cbqq.FormattingEnabled = true;
            this.cbqq.Items.AddRange(new object[] {
            "Ha Noi",
            "Thanh hoa",
            "HCM",
            "Hai phong"});
            this.cbqq.Location = new System.Drawing.Point(123, 178);
            this.cbqq.Name = "cbqq";
            this.cbqq.Size = new System.Drawing.Size(195, 24);
            this.cbqq.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "luu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "thoat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 60);
            this.button3.TabIndex = 11;
            this.button3.Text = "nhap lai";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fromthem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 371);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbqq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fromthem";
            this.Text = "fromthem";
            this.Load += new System.EventHandler(this.fromthem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbqq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}