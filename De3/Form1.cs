using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace De3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cau1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau2 c2 = new Cau2();
            c2.Show();
        }

        private void cau2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cau3 c3 = new Cau3();
            c3.Show();
        }
    }
}
