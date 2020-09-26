using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
     public partial class DangNhap : Form
     {
          public DangNhap()
          {
               InitializeComponent();
               label1.Visible = false;
          }

          private void pictureBox2_Click(object sender, EventArgs e)
          {

          }

          private void pictureBox4_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void PassWord_Leave(object sender, EventArgs e)
          {
               if (PassWord.Text == "")
               {
                    PassWord.Text = "PassWord";
                    PassWord.PasswordChar = (char)0;
               }
          }

          private void PassWord_Enter(object sender, EventArgs e)
          {
               if (PassWord.Text == "PassWord")
               {
                    PassWord.Text = "";
                    PassWord.PasswordChar = '*';
               }
          }

          private void UserName_Leave(object sender, EventArgs e)
          {
               if (UserName.Text == "")
               {
                    UserName.Text = "UserName";

               }
          }

          private void UserName_Enter(object sender, EventArgs e)
          {
               if (UserName.Text == "UserName")
                    UserName.Text = "";
          }

          private void button1_Click(object sender, EventArgs e)
          {
               if(UserName.Text == "Admin" && PassWord.Text == "123456")
                    {
                    TrangChu tc = new TrangChu();
                    tc.Visible = true;
               }
               else
               {
                    label1.Visible = true;
               }     
          }

          private void pictureBox5_Click(object sender, EventArgs e)
          {
               if (PassWord.PasswordChar == '*')
               {
                    PassWord.PasswordChar = (char)0;
               }
               else PassWord.PasswordChar = '*';
          }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanSuDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.nhanSuDataSet.NHANVIEN);

        }
    }
}
