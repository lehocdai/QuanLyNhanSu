using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{

    public partial class TrangChu : Form
    {
        private SqlConnection connect;
        private string link = @"Data Source=NAM\SQLDEV2019;Initial Catalog=NhanSu;Integrated Security=True";
        private SqlCommand command;
        public TrangChu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanSuDataSet.DUAN' table. You can move, or remove it, as needed.
            this.dUANTableAdapter.Fill(this.nhanSuDataSet.DUAN);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pn_duan.Visible = true;
            pn_duan.Dock = DockStyle.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                pn_sua.Visible = true;
                tb_mada.Text = table_duan.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_tenDA.Text = table_duan.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_mapb.Text = table_duan.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_dd.Text = table_duan.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_ngaytc.Text = table_duan.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (connect = new SqlConnection(link))
                        {
                            connect.Open();
                            //command = new SqlCommand("update NHANVIEN set MADA = '' where MADA = '" + table_duan.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connect);
                            //command.ExecuteNonQuery();
                            command = new SqlCommand("delete from DUAN where MADA = '" + table_duan.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connect);
                            command.ExecuteNonQuery();
                        }
                        TrangChu_Load(sender, e);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pn_sua.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("update DUAN set TENDA = '" + tb_tenDA.Text + "', MABP = '" + tb_mapb.Text + "', " +
                    "DIADIEM = '" + tb_dd.Text + "', NGAYTHICONG = '" + tb_ngaytc.Text + "' where MADA = '" + tb_mada.Text + "'", connect);
                command.ExecuteNonQuery();
            }
            pn_sua.Visible = false;
            TrangChu_Load(sender, e);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pn_them.Visible = false;
        }

        private void add_confirm_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("insert DUAN values('"+tb_mada_add.Text+"', N'" + tb_tenda_add.Text + "', '" + tb_mapb_add.Text + "', " +
                    "N'" + tb_dd_add.Text + "', '" + tb_ngaytc_add.Text + "') ", connect);
                command.ExecuteNonQuery();
            }
            pn_them.Visible = false;
            TrangChu_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pn_them.Visible = true;
        }

        private void pn_duan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pn_duan.Visible = false;
            pn_duan.Dock = DockStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pn_duan.Visible = false;
            pn_duan.Dock = DockStyle.None;
        }
    }
}
