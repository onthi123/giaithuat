using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace De3
{
    public partial class fromthem : Form
    {
        SqlConnection conn;
        public fromthem(SqlConnection c)
        {
            InitializeComponent();
            conn = c;
        }
        SqlCommand cmd;
        private void button1_Click(object sender, EventArgs e)
        {
            Cau3 c3 =new Cau3();
            c3.ktnoi();
            String q = "INSERT INTO ct(ma,ten,ngaysinh,quequan) VALUES ('" + txtma.Text + "','" + txtten.Text + "','" + txtngaysinh.Text + "','" + cbqq.Text+ "')";
            cmd = new SqlCommand(q,conn);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void fromthem_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtma.Clear();
            txtten.Clear();
            txtngaysinh.Clear();
            cbqq.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
