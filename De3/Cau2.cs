using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace De3
{
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fdl = new FontDialog();
            if(fdl.ShowDialog() == DialogResult.OK )
            {
                rtb.Font = fdl.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cdl = new ColorDialog();
            if(cdl.ShowDialog() == DialogResult.OK)
            {
                rtb.ForeColor = cdl.Color;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Clear();
            rtb.Focus();
        }
    }
}
