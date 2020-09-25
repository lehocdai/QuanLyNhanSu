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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_duan = new System.Windows.Forms.Panel();
            this.table_duan = new System.Windows.Forms.DataGridView();
            this.dUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanSuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanSuDataSet = new QuanLyNhanSu.NhanSuDataSet();
            this.dUANTableAdapter = new QuanLyNhanSu.NhanSuDataSetTableAdapters.DUANTableAdapter();
            this.mADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mABPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIADIEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYTHICONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sửa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.pn_sua = new System.Windows.Forms.Panel();
            this.tb_tenDA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mapb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_dd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ngaytc = new System.Windows.Forms.TextBox();
            this.sua_confirm = new System.Windows.Forms.Button();
            this.sua_cancel = new System.Windows.Forms.Button();
            this.tb_mada = new System.Windows.Forms.TextBox();
            this.pn_them = new System.Windows.Forms.Panel();
            this.tb_mada_add = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.add_confirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ngaytc_add = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_dd_add = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_mapb_add = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_tenda_add = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pn_duan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_duan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanSuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanSuDataSet)).BeginInit();
            this.pn_sua.SuspendLayout();
            this.pn_them.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
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
            this.button5.Location = new System.Drawing.Point(-1, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "THOÁT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Info;
            this.button7.Location = new System.Drawing.Point(-1, 251);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 50);
            this.button7.TabIndex = 8;
            this.button7.Text = "DỰ ÁN";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Green;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Info;
            this.button8.Location = new System.Drawing.Point(-1, 153);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 50);
            this.button8.TabIndex = 9;
            this.button8.Text = "PHÒNG BAN";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(-1, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "NHÂN VIÊN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.tuyen_dung_doanhnhansaigon_1508451442;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pn_duan);
            this.panel1.Location = new System.Drawing.Point(117, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 446);
            this.panel1.TabIndex = 1;
            // 
            // pn_duan
            // 
            this.pn_duan.Controls.Add(this.pn_them);
            this.pn_duan.Controls.Add(this.pn_sua);
            this.pn_duan.Controls.Add(this.button2);
            this.pn_duan.Controls.Add(this.table_duan);
            this.pn_duan.Location = new System.Drawing.Point(0, 3);
            this.pn_duan.Name = "pn_duan";
            this.pn_duan.Size = new System.Drawing.Size(81, 62);
            this.pn_duan.TabIndex = 0;
            this.pn_duan.Visible = false;
            this.pn_duan.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_duan_Paint);
            // 
            // table_duan
            // 
            this.table_duan.AllowUserToAddRows = false;
            this.table_duan.AutoGenerateColumns = false;
            this.table_duan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.table_duan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.table_duan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_duan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mADADataGridViewTextBoxColumn,
            this.tENDADataGridViewTextBoxColumn,
            this.mABPDataGridViewTextBoxColumn,
            this.dIADIEMDataGridViewTextBoxColumn,
            this.nGAYTHICONGDataGridViewTextBoxColumn,
            this.Sửa,
            this.Xóa});
            this.table_duan.DataSource = this.dUANBindingSource;
            this.table_duan.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.table_duan.Location = new System.Drawing.Point(0, 54);
            this.table_duan.Name = "table_duan";
            this.table_duan.ReadOnly = true;
            this.table_duan.Size = new System.Drawing.Size(823, 308);
            this.table_duan.TabIndex = 0;
            this.table_duan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dUANBindingSource
            // 
            this.dUANBindingSource.DataMember = "DUAN";
            this.dUANBindingSource.DataSource = this.nhanSuDataSetBindingSource;
            // 
            // nhanSuDataSetBindingSource
            // 
            this.nhanSuDataSetBindingSource.DataSource = this.nhanSuDataSet;
            this.nhanSuDataSetBindingSource.Position = 0;
            // 
            // nhanSuDataSet
            // 
            this.nhanSuDataSet.DataSetName = "NhanSuDataSet";
            this.nhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dUANTableAdapter
            // 
            this.dUANTableAdapter.ClearBeforeFill = true;
            // 
            // mADADataGridViewTextBoxColumn
            // 
            this.mADADataGridViewTextBoxColumn.DataPropertyName = "MADA";
            this.mADADataGridViewTextBoxColumn.HeaderText = "MADA";
            this.mADADataGridViewTextBoxColumn.Name = "mADADataGridViewTextBoxColumn";
            this.mADADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENDADataGridViewTextBoxColumn
            // 
            this.tENDADataGridViewTextBoxColumn.DataPropertyName = "TENDA";
            this.tENDADataGridViewTextBoxColumn.HeaderText = "TENDA";
            this.tENDADataGridViewTextBoxColumn.Name = "tENDADataGridViewTextBoxColumn";
            this.tENDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mABPDataGridViewTextBoxColumn
            // 
            this.mABPDataGridViewTextBoxColumn.DataPropertyName = "MABP";
            this.mABPDataGridViewTextBoxColumn.HeaderText = "MABP";
            this.mABPDataGridViewTextBoxColumn.Name = "mABPDataGridViewTextBoxColumn";
            this.mABPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIADIEMDataGridViewTextBoxColumn
            // 
            this.dIADIEMDataGridViewTextBoxColumn.DataPropertyName = "DIADIEM";
            this.dIADIEMDataGridViewTextBoxColumn.HeaderText = "DIADIEM";
            this.dIADIEMDataGridViewTextBoxColumn.Name = "dIADIEMDataGridViewTextBoxColumn";
            this.dIADIEMDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIADIEMDataGridViewTextBoxColumn.Width = 180;
            // 
            // nGAYTHICONGDataGridViewTextBoxColumn
            // 
            this.nGAYTHICONGDataGridViewTextBoxColumn.DataPropertyName = "NGAYTHICONG";
            this.nGAYTHICONGDataGridViewTextBoxColumn.HeaderText = "NGAYTHICONG";
            this.nGAYTHICONGDataGridViewTextBoxColumn.Name = "nGAYTHICONGDataGridViewTextBoxColumn";
            this.nGAYTHICONGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Sửa
            // 
            this.Sửa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sửa.HeaderText = "";
            this.Sửa.Name = "Sửa";
            this.Sửa.ReadOnly = true;
            this.Sửa.Text = "Sửa";
            this.Sửa.UseColumnTextForButtonValue = true;
            // 
            // Xóa
            // 
            this.Xóa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xóa.HeaderText = "";
            this.Xóa.Name = "Xóa";
            this.Xóa.ReadOnly = true;
            this.Xóa.Text = "Xóa";
            this.Xóa.UseColumnTextForButtonValue = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(711, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "THÊM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pn_sua
            // 
            this.pn_sua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_sua.Controls.Add(this.tb_mada);
            this.pn_sua.Controls.Add(this.sua_cancel);
            this.pn_sua.Controls.Add(this.sua_confirm);
            this.pn_sua.Controls.Add(this.label5);
            this.pn_sua.Controls.Add(this.tb_ngaytc);
            this.pn_sua.Controls.Add(this.label4);
            this.pn_sua.Controls.Add(this.tb_dd);
            this.pn_sua.Controls.Add(this.label3);
            this.pn_sua.Controls.Add(this.tb_mapb);
            this.pn_sua.Controls.Add(this.label2);
            this.pn_sua.Controls.Add(this.tb_tenDA);
            this.pn_sua.Location = new System.Drawing.Point(164, 19);
            this.pn_sua.Name = "pn_sua";
            this.pn_sua.Size = new System.Drawing.Size(451, 286);
            this.pn_sua.TabIndex = 2;
            this.pn_sua.Visible = false;
            // 
            // tb_tenDA
            // 
            this.tb_tenDA.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tb_tenDA.Location = new System.Drawing.Point(121, 31);
            this.tb_tenDA.Name = "tb_tenDA";
            this.tb_tenDA.Size = new System.Drawing.Size(236, 25);
            this.tb_tenDA.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dự án:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phòng ban:";
            // 
            // tb_mapb
            // 
            this.tb_mapb.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tb_mapb.Location = new System.Drawing.Point(121, 79);
            this.tb_mapb.Name = "tb_mapb";
            this.tb_mapb.Size = new System.Drawing.Size(236, 25);
            this.tb_mapb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa điểm:";
            // 
            // tb_dd
            // 
            this.tb_dd.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tb_dd.Location = new System.Drawing.Point(121, 127);
            this.tb_dd.Name = "tb_dd";
            this.tb_dd.Size = new System.Drawing.Size(236, 25);
            this.tb_dd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày thi công:";
            // 
            // tb_ngaytc
            // 
            this.tb_ngaytc.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tb_ngaytc.Location = new System.Drawing.Point(121, 178);
            this.tb_ngaytc.Name = "tb_ngaytc";
            this.tb_ngaytc.Size = new System.Drawing.Size(236, 25);
            this.tb_ngaytc.TabIndex = 6;
            // 
            // sua_confirm
            // 
            this.sua_confirm.BackColor = System.Drawing.Color.Green;
            this.sua_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sua_confirm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_confirm.Location = new System.Drawing.Point(85, 229);
            this.sua_confirm.Name = "sua_confirm";
            this.sua_confirm.Size = new System.Drawing.Size(115, 40);
            this.sua_confirm.TabIndex = 3;
            this.sua_confirm.Text = "XÁC NHẬN";
            this.sua_confirm.UseVisualStyleBackColor = false;
            this.sua_confirm.Click += new System.EventHandler(this.button3_Click);
            // 
            // sua_cancel
            // 
            this.sua_cancel.BackColor = System.Drawing.Color.Green;
            this.sua_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sua_cancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_cancel.Location = new System.Drawing.Point(248, 229);
            this.sua_cancel.Name = "sua_cancel";
            this.sua_cancel.Size = new System.Drawing.Size(109, 40);
            this.sua_cancel.TabIndex = 8;
            this.sua_cancel.Text = "CANCEL";
            this.sua_cancel.UseVisualStyleBackColor = false;
            this.sua_cancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_mada
            // 
            this.tb_mada.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tb_mada.Location = new System.Drawing.Point(363, 106);
            this.tb_mada.Name = "tb_mada";
            this.tb_mada.Size = new System.Drawing.Size(87, 25);
            this.tb_mada.TabIndex = 9;
            this.tb_mada.Visible = false;
            // 
            // pn_them
            // 
            this.pn_them.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_them.Controls.Add(this.label10);
            this.pn_them.Controls.Add(this.tb_mada_add);
            this.pn_them.Controls.Add(this.button3);
            this.pn_them.Controls.Add(this.add_confirm);
            this.pn_them.Controls.Add(this.label6);
            this.pn_them.Controls.Add(this.tb_ngaytc_add);
            this.pn_them.Controls.Add(this.label7);
            this.pn_them.Controls.Add(this.tb_dd_add);
            this.pn_them.Controls.Add(this.label8);
            this.pn_them.Controls.Add(this.tb_mapb_add);
            this.pn_them.Controls.Add(this.label9);
            this.pn_them.Controls.Add(this.tb_tenda_add);
            this.pn_them.Location = new System.Drawing.Point(164, 8);
            this.pn_them.Name = "pn_them";
            this.pn_them.Size = new System.Drawing.Size(451, 328);
            this.pn_them.TabIndex = 10;
            this.pn_them.Visible = false;
            // 
            // tb_mada_add
            // 
            this.tb_mada_add.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tb_mada_add.Location = new System.Drawing.Point(152, 30);
            this.tb_mada_add.Name = "tb_mada_add";
            this.tb_mada_add.Size = new System.Drawing.Size(236, 25);
            this.tb_mada_add.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(261, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "CANCEL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // add_confirm
            // 
            this.add_confirm.BackColor = System.Drawing.Color.Green;
            this.add_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_confirm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_confirm.Location = new System.Drawing.Point(98, 269);
            this.add_confirm.Name = "add_confirm";
            this.add_confirm.Size = new System.Drawing.Size(115, 40);
            this.add_confirm.TabIndex = 3;
            this.add_confirm.Text = "XÁC NHẬN";
            this.add_confirm.UseVisualStyleBackColor = false;
            this.add_confirm.Click += new System.EventHandler(this.add_confirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày thi công:";
            // 
            // tb_ngaytc_add
            // 
            this.tb_ngaytc_add.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tb_ngaytc_add.Location = new System.Drawing.Point(152, 220);
            this.tb_ngaytc_add.Name = "tb_ngaytc_add";
            this.tb_ngaytc_add.Size = new System.Drawing.Size(236, 25);
            this.tb_ngaytc_add.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa điểm:";
            // 
            // tb_dd_add
            // 
            this.tb_dd_add.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tb_dd_add.Location = new System.Drawing.Point(152, 169);
            this.tb_dd_add.Name = "tb_dd_add";
            this.tb_dd_add.Size = new System.Drawing.Size(236, 25);
            this.tb_dd_add.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã phòng ban:";
            // 
            // tb_mapb_add
            // 
            this.tb_mapb_add.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tb_mapb_add.Location = new System.Drawing.Point(152, 121);
            this.tb_mapb_add.Name = "tb_mapb_add";
            this.tb_mapb_add.Size = new System.Drawing.Size(236, 25);
            this.tb_mapb_add.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên dự án:";
            // 
            // tb_tenda_add
            // 
            this.tb_tenda_add.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tb_tenda_add.Location = new System.Drawing.Point(152, 73);
            this.tb_tenda_add.Name = "tb_tenda_add";
            this.tb_tenda_add.Size = new System.Drawing.Size(236, 25);
            this.tb_tenda_add.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(75, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mã dự án:";
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 411);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.pn_duan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_duan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanSuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanSuDataSet)).EndInit();
            this.pn_sua.ResumeLayout(false);
            this.pn_sua.PerformLayout();
            this.pn_them.ResumeLayout(false);
            this.pn_them.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button5;
          private System.Windows.Forms.Button button7;
          private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel pn_duan;
        private System.Windows.Forms.DataGridView table_duan;
        private System.Windows.Forms.BindingSource nhanSuDataSetBindingSource;
        private NhanSuDataSet nhanSuDataSet;
        private System.Windows.Forms.BindingSource dUANBindingSource;
        private NhanSuDataSetTableAdapters.DUANTableAdapter dUANTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mABPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIADIEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYTHICONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Sửa;
        private System.Windows.Forms.DataGridViewButtonColumn Xóa;
        private System.Windows.Forms.Panel pn_sua;
        private System.Windows.Forms.Button sua_confirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ngaytc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_dd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mapb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tenDA;
        private System.Windows.Forms.Button sua_cancel;
        private System.Windows.Forms.TextBox tb_mada;
        private System.Windows.Forms.Panel pn_them;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_mada_add;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button add_confirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ngaytc_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_dd_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_mapb_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_tenda_add;
    }
}