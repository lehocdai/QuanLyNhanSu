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
        private string link = @"Data Source=SCORPION;Initial Catalog=NhanSu;Integrated Security=True";
        private SqlCommand command;
        public TrangChu()
        {
            InitializeComponent();
        }

        private void thoat_ct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrangChu_Load_Duan(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanSuDataSet.BOPHAN' table. You can move, or remove it, as needed.
            this.bOPHANTableAdapter1.Fill(this.nhanSuDataSet.BOPHAN);
            // TODO: This line of code loads data into the 'nhanSuDataSet.DUAN' table. You can move, or remove it, as needed.
            this.dUANTableAdapter.Fill(this.nhanSuDataSet.DUAN);
        }

        private void TrangChu_Load_Bophan(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanSuDataSet.BOPHAN' table. You can move, or remove it, as needed.
            this.bOPHANTableAdapter.Fill(this.nhanSuDataSet1.BOPHAN);
        }

        private void duan_btn_Click(object sender, EventArgs e)
        {
            pn_bp.Visible = false;
            pn_bp.Dock = DockStyle.None;
            pn_duan.Visible = true;
            pn_duan.Dock = DockStyle.Fill;
            TrangChu_Load_Duan(sender, e);
        }

        private void bp_btn_Click(object sender, EventArgs e)
        {
            pn_duan.Visible = false;
            pn_duan.Dock = DockStyle.None;
            pn_bp.Visible = true;
            pn_bp.Dock = DockStyle.Fill;
        }

        private void bang_duan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                pn_sua_da.Visible = true;
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
                            command = new SqlCommand("delete from DUAN where MADA = '" + table_duan.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connect);
                            command.ExecuteNonQuery();
                        }
                        TrangChu_Load_Duan(sender, e);
                    }
                }
            }
        }

        private void bang_bophan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                pn_sua_bp.Visible = true;
                sua_bp_mabp_tb.Text = table_bophan.Rows[e.RowIndex].Cells[0].Value.ToString();
                sua_bp_tenbp_tb.Text = table_bophan.Rows[e.RowIndex].Cells[1].Value.ToString();
                sua_bp_matbp_tb.Text = table_bophan.Rows[e.RowIndex].Cells[2].Value.ToString();
                sua_bp_dd_tb.Text = table_bophan.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else
            {
                if (e.ColumnIndex == 5)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (connect = new SqlConnection(link))
                        {
                            connect.Open();
                            command = new SqlCommand("delete from BOPHAN where MABP = '" + table_bophan.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connect);
                            command.ExecuteNonQuery();
                        }
                        TrangChu_Load_Bophan(sender, e);
                    }
                }
            }
        }

        private void sua_da_cancel_Click(object sender, EventArgs e)
        {
            pn_sua_da.Visible = false;
        }

        private void sua_da_confirm_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("update DUAN set TENDA = '" + tb_tenDA.Text + "', MABP = '" + tb_mapb.Text + "', " +
                    "DIADIEM = '" + tb_dd.Text + "', NGAYTHICONG = '" + tb_ngaytc.Text + "' where MADA = '" + tb_mada.Text + "'", connect);
                command.ExecuteNonQuery();
            }
            pn_sua_da.Visible = false;
            TrangChu_Load_Duan(sender, e);
        }

        private void sua_bp_cancel_Click(object sender, EventArgs e)
        {
            pn_sua_bp.Visible = false;
        }

        private void sua_bp_confirm_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("update BOPHAN set TENBP = '" + sua_bp_tenbp_tb.Text + "', MATBP = '" + sua_bp_matbp_tb.Text + "', " +
                    "DIADIEM = '" + sua_bp_dd_tb.Text + "' where MABP = '" + sua_bp_mabp_tb.Text + "'", connect);
                command.ExecuteNonQuery();
            }
            pn_sua_bp.Visible = false;
            TrangChu_Load_Bophan(sender, e);
        }

        private void add_cancel_Click(object sender, EventArgs e)
        {
            pn_them_da.Visible = false;
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
            pn_them_da.Visible = false;
            TrangChu_Load_Duan(sender, e);
        }

        private void add_bp_cancel_btn_Click(object sender, EventArgs e)
        {
            pn_them_bp.Visible = false;
        }

        private void add_bp_confirm_btn_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                command = new SqlCommand("insert BOPHAN values('" + them_bp_mabp_tb.Text + "', N'" + them_bp_tenbp_tb.Text + "', '" + them_bp_matbp_tb.Text + "', " +
                    "N'" + them_bp_dd_tb.Text + "') ", connect);
                command.ExecuteNonQuery();
            }
            pn_them_bp.Visible = false;
            TrangChu_Load_Bophan(sender, e);
        }

        private void them_duan_btn_Click(object sender, EventArgs e)
        {
            pn_them_da.Visible = true;
        }

        private void them_bophan_btn_Click(object sender, EventArgs e)
        {
            pn_them_bp.Visible = true;

        }

        private void nv_btn_Click(object sender, EventArgs e)
        {
            pn_duan.Visible = false;
            pn_bp.Visible = false;
            pn_duan.Dock = DockStyle.None;
            pn_bp.Dock = DockStyle.None;
        }
    }
}
