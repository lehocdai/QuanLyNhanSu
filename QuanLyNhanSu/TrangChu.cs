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
        private string link = @"Data Source=NOKIA-E490\SQLExpress;Initial Catalog=QuanlyNhansu;Integrated Security=True";
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
            // TODO: This line of code loads data into the 'nhanSuDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.nhanSuDataSet.NHANVIEN);
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
        private void TrangChu_Load_Nhanvien(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanSuDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.nhanSuDataSet.NHANVIEN);
        }
        private void duan_btn_Click(object sender, EventArgs e)
        {
            pn_bp.Visible = false;
            pn_nv.Visible = false;
            pn_bp.Dock = DockStyle.None;
            pn_nv.Dock = DockStyle.None;
            pn_duan.Visible = true;
            pn_duan.Dock = DockStyle.Fill;
            TrangChu_Load_Duan(sender, e);
        }

        private void bp_btn_Click(object sender, EventArgs e)
        {
            pn_duan.Visible = false;
            pn_nv.Visible = false;
            pn_duan.Dock = DockStyle.None;
            pn_nv.Dock = DockStyle.None;
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
            pn_nv.Dock = DockStyle.Fill;
            pn_nv.Visible = true;
        }

        private void btn_ADD_NV_Click(object sender, EventArgs e)
        {
            pn_them_NV.Visible = true;
        }

        private void btn_Huy_Them_NV_Click(object sender, EventArgs e)
        {
            pn_them_NV.Visible = false;
        }

        private void btn_Huy_Sua_NV_Click(object sender, EventArgs e)
        {
            pn_sua_Nv.Visible = false;
        }

        private void table_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                pn_sua_Nv.Visible = true;
                txt_Sua_Ma_nv.Text = table_nv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_Sua_Ten_NV.Text= table_nv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_Sua_maBP_NV.Text = table_nv.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_Sua_MaDA_NV.Text = table_nv.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_Sua_Ngaysinh_NV.Text = table_nv.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_Sua_Sdt_NV.Text = table_nv.Rows[e.RowIndex].Cells[7].Value.ToString();
                if(table_nv.Rows[e.RowIndex].Cells[5].Value.ToString()== check_Nam_Sua_NV.Text)
                {
                    check_Nam_Sua_NV.Checked = true;
                    check_Nu_Sua_Nv.Checked = false;
                }
                else
                {
                    check_Nu_Sua_Nv.Checked = true;
                    check_Nam_Sua_NV.Checked = false;
                }
                txt_Sua_Diachi_Nv.Text = table_nv.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_Sua_Luong_NV.Text = table_nv.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            else
            {
                if (e.ColumnIndex == 10)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (connect = new SqlConnection(link))
                        {
                            connect.Open();
                            command = new SqlCommand("delete from NHANVIEN where MANV = '" + table_nv.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", connect);
                            command.ExecuteNonQuery();
                        }
                    }
                    TrangChu_Load_Nhanvien(sender, e);
                }
            }
        }

        private void btn_Xacnhan_Sua_NV_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                string str = "update NHANVIEN set TENNV=N'"+txt_Sua_Ten_NV.Text+"',DIACHI=N'"+txt_Sua_Diachi_Nv.Text+"',LUONG='"+txt_Sua_Luong_NV.Text+"',SDT='"+txt_Sua_Sdt_NV.Text+"',MABP='"+txt_Sua_maBP_NV.Text+"',NGAYSINH='"+ txt_Sua_Ngaysinh_NV.Value.ToString("yyyy/MM/dd") + "',MADA='"+txt_Sua_MaDA_NV.Text+"' where MANV='"+txt_Sua_Ma_nv.Text+"'";
                if (check_Nam_Sua_NV.Checked == true)
                {
                    str += "UPDATE NHANVIEN set GIOITINH=N'" + check_Nam_Sua_NV.Text + "' WHERE MANV='" + txt_Sua_Ma_nv.Text + "'";
                }
                if (check_Nu_Sua_Nv.Checked == true)
                {
                    str += "UPDATE NHANVIEN set GIOITINH=N'" + check_Nu_Sua_Nv.Text + "' WHERE MANV='" + txt_Sua_Ma_nv.Text + "'";
                }
                command = new SqlCommand(str,connect);
                command.ExecuteNonQuery();
            }
            pn_sua_Nv.Visible = false;
            TrangChu_Load_Nhanvien(sender, e);
        }

        private void btn_Xacnhan_Them_NV_Click(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(link))
            {
                connect.Open();
                string str="";
                if(check_Nam_Them_NV.Checked==true)
                {
                    str = "INSERT NHANVIEN ([MANV], [TENNV], [DIACHI], [SDT], [GIOITINH], [MABP], [NGAYSINH], [LUONG], [MADA]) VALUES" +
                        " ('" + txt_Them_Ma_NV.Text + "',N'" + txt_Them_Ten_NV.Text + "',N'" + txt_Them_diachi_nhanvien.Text + "','" + txt_Them_sdt_NV.Text + "'," +
                         "N'" +check_Nam_Them_NV.Text + "','" + txt_Them_MaBP_NV.Text + "','" + date_Ngaysinh_Them_NV.Value.ToString("yyyy/MM/dd") + "'," + Convert.ToInt32(txt_Luong_Them_NV.Text) + ",'" + txt_MaDA_Them_NV.Text + "')";
                }
                if(check_Nu_Them_Nu.Checked==true)
                {
                    str = "INSERT NHANVIEN ([MANV], [TENNV], [DIACHI], [SDT], [GIOITINH], [MABP], [NGAYSINH], [LUONG], [MADA]) VALUES " +
                        "('" + txt_Them_Ma_NV.Text + "',N'" + txt_Them_Ten_NV.Text + "',N'" + txt_Them_diachi_nhanvien.Text + "','" + txt_Them_sdt_NV.Text + "'," +
                         "N'"+check_Nu_Them_Nu.Text+"','"+txt_Them_MaBP_NV.Text+"','"+date_Ngaysinh_Them_NV.Value.ToString("yyyy/MM/dd")+"',"+Convert.ToInt32(txt_Luong_Them_NV.Text)+",'"+txt_MaDA_Them_NV.Text+"')";
                }
                command = new SqlCommand(str, connect);
                command.ExecuteNonQuery();
            }
            pn_them_NV.Visible = false;
            TrangChu_Load_Nhanvien(sender, e);
        }
    }//676, 456
}
