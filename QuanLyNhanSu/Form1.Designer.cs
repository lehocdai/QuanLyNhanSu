namespace QuanLyNhanSu
{
     partial class DangNhap
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
               this.UserName = new System.Windows.Forms.TextBox();
               this.PassWord = new System.Windows.Forms.TextBox();
               this.button1 = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.pictureBox5 = new System.Windows.Forms.PictureBox();
               this.pictureBox4 = new System.Windows.Forms.PictureBox();
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // UserName
               // 
               this.UserName.BackColor = System.Drawing.Color.MediumTurquoise;
               this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.UserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.UserName.ForeColor = System.Drawing.SystemColors.WindowText;
               this.UserName.Location = new System.Drawing.Point(154, 243);
               this.UserName.Name = "UserName";
               this.UserName.Size = new System.Drawing.Size(162, 22);
               this.UserName.TabIndex = 3;
               this.UserName.Text = "UserName";
               this.UserName.Enter += new System.EventHandler(this.UserName_Enter);
               this.UserName.Leave += new System.EventHandler(this.UserName_Leave);
               // 
               // PassWord
               // 
               this.PassWord.BackColor = System.Drawing.Color.MediumTurquoise;
               this.PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.PassWord.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.PassWord.Location = new System.Drawing.Point(154, 300);
               this.PassWord.Name = "PassWord";
               this.PassWord.Size = new System.Drawing.Size(162, 22);
               this.PassWord.TabIndex = 4;
               this.PassWord.Text = "PassWord";
               this.PassWord.Enter += new System.EventHandler(this.PassWord_Enter);
               this.PassWord.Leave += new System.EventHandler(this.PassWord_Leave);
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.DarkCyan;
               this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(98, 352);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(201, 31);
               this.button1.TabIndex = 6;
               this.button1.Text = "Đăng nhập ";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.Red;
               this.label1.Location = new System.Drawing.Point(49, 401);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(291, 19);
               this.label1.TabIndex = 7;
               this.label1.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.Red;
               this.label2.Location = new System.Drawing.Point(151, 435);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(108, 19);
               this.label2.TabIndex = 8;
               this.label2.Text = "Quên mật khẩu?";
               // 
               // label3
               // 
               this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
               this.label3.Location = new System.Drawing.Point(100, 268);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(222, 2);
               this.label3.TabIndex = 9;
               // 
               // label4
               // 
               this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
               this.label4.Location = new System.Drawing.Point(100, 325);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(222, 2);
               this.label4.TabIndex = 10;
               // 
               // pictureBox5
               // 
               this.pictureBox5.Image = global::QuanLyNhanSu.Properties.Resources.pngtree_vector_eye_icon_png_image_925911;
               this.pictureBox5.Location = new System.Drawing.Point(329, 300);
               this.pictureBox5.Name = "pictureBox5";
               this.pictureBox5.Size = new System.Drawing.Size(28, 26);
               this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox5.TabIndex = 11;
               this.pictureBox5.TabStop = false;
               this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
               // 
               // pictureBox4
               // 
               this.pictureBox4.Image = global::QuanLyNhanSu.Properties.Resources.images__2_;
               this.pictureBox4.Location = new System.Drawing.Point(380, 0);
               this.pictureBox4.Name = "pictureBox4";
               this.pictureBox4.Size = new System.Drawing.Size(36, 33);
               this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox4.TabIndex = 5;
               this.pictureBox4.TabStop = false;
               this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
               // 
               // pictureBox3
               // 
               this.pictureBox3.Image = global::QuanLyNhanSu.Properties.Resources.img_234288;
               this.pictureBox3.Location = new System.Drawing.Point(98, 292);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(33, 30);
               this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox3.TabIndex = 2;
               this.pictureBox3.TabStop = false;
               // 
               // pictureBox2
               // 
               this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
               this.pictureBox2.Image = global::QuanLyNhanSu.Properties.Resources._1200px_User_font_awesome_svg;
               this.pictureBox2.Location = new System.Drawing.Point(98, 232);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(33, 33);
               this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox2.TabIndex = 1;
               this.pictureBox2.TabStop = false;
               this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
               this.pictureBox1.Image = global::QuanLyNhanSu.Properties.Resources.user;
               this.pictureBox1.Location = new System.Drawing.Point(134, 60);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(143, 120);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // DangNhap
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.MediumTurquoise;
               this.ClientSize = new System.Drawing.Size(417, 483);
               this.ControlBox = false;
               this.Controls.Add(this.pictureBox5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.pictureBox4);
               this.Controls.Add(this.PassWord);
               this.Controls.Add(this.UserName);
               this.Controls.Add(this.pictureBox3);
               this.Controls.Add(this.pictureBox2);
               this.Controls.Add(this.pictureBox1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "DangNhap";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.PictureBox pictureBox2;
          private System.Windows.Forms.PictureBox pictureBox3;
          private System.Windows.Forms.TextBox UserName;
          private System.Windows.Forms.TextBox PassWord;
          private System.Windows.Forms.PictureBox pictureBox4;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.PictureBox pictureBox5;
     }
}

