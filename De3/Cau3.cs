using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace De3
{
    public partial class Cau3 : Form
    {
        public Cau3()
        {
            InitializeComponent();
        }
        SqlDataAdapter adt;
        SqlCommand cmd;
        private SqlConnection conn;
        public void ktnoi()
        {
            String q = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{Application.StartupPath}\qlcauthu.mdf"";Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(q);
            conn.Open();
        }
        public void show_data()
        {
            ktnoi();
            String q = "SELECT * FROM ct";
            adt = new SqlDataAdapter(q, conn);
            DataSet dataSet = new DataSet();
            adt.Fill(dataSet);
            dgv.DataSource = dataSet.Tables[0];
            
        }

        private void Cau3_Load(object sender, EventArgs e)
        {
            show_data();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fromthem ft = new fromthem(conn);
            ft.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentRow.Index;
            if (dgv.CurrentRow.Index == 0)
            {
                MessageBox.Show("Bạn đang ở đầu bảng");
            }
            else
            {
                dgv.CurrentCell = dgv.Rows[index - 1].Cells[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentRow.Index;
            if (index == dgv.RowCount - 1)
            {
                MessageBox.Show("Bạn đang ở cuối bảng");
            }
            else
            {
                dgv.CurrentCell = dgv.Rows[index + 1].Cells[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv.CurrentCell = dgv.Rows[0].Cells[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentRow.Index;
            if (index == dgv.RowCount - 1)
            {
                MessageBox.Show("Bạn đang ở đầu bảng");
            }
            else
            {
                dgv.CurrentCell = dgv.Rows[dgv.RowCount - 1].Cells[0];
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
