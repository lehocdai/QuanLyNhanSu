namespace QuanLyNhanSu
{
     partial class TrangChu
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
               this.label1 = new System.Windows.Forms.Label();
               this.button5 = new System.Windows.Forms.Button();
               this.button6 = new System.Windows.Forms.Button();
               this.button7 = new System.Windows.Forms.Button();
               this.button8 = new System.Windows.Forms.Button();
               this.button1 = new System.Windows.Forms.Button();
               this.panel1 = new System.Windows.Forms.Panel();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(274, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(265, 40);
               this.label1.TabIndex = 0;
               this.label1.Text = "Quản lý nhân sự";
               // 
               // button5
               // 
               this.button5.BackColor = System.Drawing.Color.Red;
               this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button5.ForeColor = System.Drawing.SystemColors.Info;
               this.button5.Location = new System.Drawing.Point(0, 407);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(119, 50);
               this.button5.TabIndex = 6;
               this.button5.Text = "THOÁT";
               this.button5.UseVisualStyleBackColor = false;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // button6
               // 
               this.button6.BackColor = System.Drawing.Color.Green;
               this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button6.ForeColor = System.Drawing.SystemColors.Info;
               this.button6.Location = new System.Drawing.Point(0, 318);
               this.button6.Name = "button6";
               this.button6.Size = new System.Drawing.Size(119, 50);
               this.button6.TabIndex = 7;
               this.button6.Text = "PHÂN CÔNG";
               this.button6.UseVisualStyleBackColor = false;
               // 
               // button7
               // 
               this.button7.BackColor = System.Drawing.Color.Green;
               this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button7.ForeColor = System.Drawing.SystemColors.Info;
               this.button7.Location = new System.Drawing.Point(0, 225);
               this.button7.Name = "button7";
               this.button7.Size = new System.Drawing.Size(119, 50);
               this.button7.TabIndex = 8;
               this.button7.Text = "DỰ ÁN";
               this.button7.UseVisualStyleBackColor = false;
               // 
               // button8
               // 
               this.button8.BackColor = System.Drawing.Color.Green;
               this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button8.ForeColor = System.Drawing.SystemColors.Info;
               this.button8.Location = new System.Drawing.Point(0, 137);
               this.button8.Name = "button8";
               this.button8.Size = new System.Drawing.Size(119, 50);
               this.button8.TabIndex = 9;
               this.button8.Text = "PHÒNG BAN";
               this.button8.UseVisualStyleBackColor = false;
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.Green;
               this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.ForeColor = System.Drawing.SystemColors.Info;
               this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
               this.button1.Location = new System.Drawing.Point(0, 52);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(119, 50);
               this.button1.TabIndex = 2;
               this.button1.Text = "NHÂN VIÊN";
               this.button1.UseVisualStyleBackColor = false;
               // 
               // panel1
               // 
               this.panel1.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.tuyen_dung_doanhnhansaigon_1508451442;
               this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel1.Location = new System.Drawing.Point(117, 52);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(718, 446);
               this.panel1.TabIndex = 1;
               // 
               // TrangChu
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.ClientSize = new System.Drawing.Size(837, 496);
               this.Controls.Add(this.button8);
               this.Controls.Add(this.button7);
               this.Controls.Add(this.button6);
               this.Controls.Add(this.button5);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.label1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "TrangChu";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "TrangChu";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button5;
          private System.Windows.Forms.Button button6;
          private System.Windows.Forms.Button button7;
          private System.Windows.Forms.Button button8;
     }
}