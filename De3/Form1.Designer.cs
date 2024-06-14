namespace De3
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chuongTrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cau1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cau2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chuongTrinhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chuongTrinhToolStripMenuItem
            // 
            this.chuongTrinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cau1ToolStripMenuItem,
            this.cau2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.thoatToolStripMenuItem});
            this.chuongTrinhToolStripMenuItem.Name = "chuongTrinhToolStripMenuItem";
            this.chuongTrinhToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.chuongTrinhToolStripMenuItem.Text = "Chuong trinh";
            // 
            // cau1ToolStripMenuItem
            // 
            this.cau1ToolStripMenuItem.Name = "cau1ToolStripMenuItem";
            this.cau1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cau1ToolStripMenuItem.Text = "Cau 2";
            this.cau1ToolStripMenuItem.Click += new System.EventHandler(this.cau1ToolStripMenuItem_Click);
            // 
            // cau2ToolStripMenuItem
            // 
            this.cau2ToolStripMenuItem.Name = "cau2ToolStripMenuItem";
            this.cau2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cau2ToolStripMenuItem.Text = "Cau 3";
            this.cau2ToolStripMenuItem.Click += new System.EventHandler(this.cau2ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoatToolStripMenuItem.Text = "Thoat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chuongTrinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cau1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cau2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
    }
}

