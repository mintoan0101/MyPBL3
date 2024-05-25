namespace pbl
{
    partial class ThemHoadon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.cbb_PhanLoai = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_Tong = new System.Windows.Forms.Label();
            this.lb_GiamGia = new System.Windows.Forms.Label();
            this.lb_ThanhTien = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_DateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.bt_DoiDiem = new System.Windows.Forms.Button();
            this.lb_DiemThuong = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lb_TenKhachHang = new System.Windows.Forms.Label();
            this.lb_IDKhachHang = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_STDKhachHang = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.bt_ThanhToan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 363);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 49);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bt_TimKiem);
            this.panel3.Controls.Add(this.txt_TimKiem);
            this.panel3.Controls.Add(this.cbb_PhanLoai);
            this.panel3.Location = new System.Drawing.Point(17, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 29);
            this.panel3.TabIndex = 0;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_TimKiem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_TimKiem.Image = global::pbl.Properties.Resources.search44;
            this.bt_TimKiem.Location = new System.Drawing.Point(507, -2);
            this.bt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(97, 30);
            this.bt_TimKiem.TabIndex = 2;
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(157, 5);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(347, 20);
            this.txt_TimKiem.TabIndex = 1;
            // 
            // cbb_PhanLoai
            // 
            this.cbb_PhanLoai.DisplayMember = "Phân loại";
            this.cbb_PhanLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_PhanLoai.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_PhanLoai.FormattingEnabled = true;
            this.cbb_PhanLoai.Items.AddRange(new object[] {
            "ID Chi Tiết",
            "Tên Sản Phẩm"});
            this.cbb_PhanLoai.Location = new System.Drawing.Point(0, 1);
            this.cbb_PhanLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_PhanLoai.Name = "cbb_PhanLoai";
            this.cbb_PhanLoai.Size = new System.Drawing.Size(147, 27);
            this.cbb_PhanLoai.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(648, 257);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lb_ID);
            this.panel4.Controls.Add(this.lb_Tong);
            this.panel4.Controls.Add(this.lb_GiamGia);
            this.panel4.Controls.Add(this.lb_ThanhTien);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lb_DateTime);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(707, 28);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 496);
            this.panel4.TabIndex = 3;
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_ID.Location = new System.Drawing.Point(51, 78);
            this.lb_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(0, 23);
            this.lb_ID.TabIndex = 12;
            // 
            // lb_Tong
            // 
            this.lb_Tong.AutoSize = true;
            this.lb_Tong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tong.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_Tong.Location = new System.Drawing.Point(301, 442);
            this.lb_Tong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Tong.Name = "lb_Tong";
            this.lb_Tong.Size = new System.Drawing.Size(19, 23);
            this.lb_Tong.TabIndex = 11;
            this.lb_Tong.Text = "0";
            this.lb_Tong.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_GiamGia
            // 
            this.lb_GiamGia.AutoSize = true;
            this.lb_GiamGia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GiamGia.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_GiamGia.Location = new System.Drawing.Point(301, 402);
            this.lb_GiamGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_GiamGia.Name = "lb_GiamGia";
            this.lb_GiamGia.Size = new System.Drawing.Size(19, 23);
            this.lb_GiamGia.TabIndex = 10;
            this.lb_GiamGia.Text = "0";
            this.lb_GiamGia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lb_GiamGia.Click += new System.EventHandler(this.label9_Click);
            // 
            // lb_ThanhTien
            // 
            this.lb_ThanhTien.AutoSize = true;
            this.lb_ThanhTien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhTien.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_ThanhTien.Location = new System.Drawing.Point(301, 363);
            this.lb_ThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ThanhTien.Name = "lb_ThanhTien";
            this.lb_ThanhTien.Size = new System.Drawing.Size(19, 23);
            this.lb_ThanhTien.TabIndex = 9;
            this.lb_ThanhTien.Text = "0";
            this.lb_ThanhTien.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Location = new System.Drawing.Point(24, 478);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 2);
            this.panel7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(20, 442);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng thanh toán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(20, 402);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giảm giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(20, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thành tiền:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Location = new System.Drawing.Point(24, 345);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 2);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(24, 119);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 2);
            this.panel5.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(24, 143);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(300, 176);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // lb_DateTime
            // 
            this.lb_DateTime.AutoSize = true;
            this.lb_DateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DateTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_DateTime.Location = new System.Drawing.Point(155, 78);
            this.lb_DateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DateTime.Name = "lb_DateTime";
            this.lb_DateTime.Size = new System.Drawing.Size(0, 23);
            this.lb_DateTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(81, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOÁ ĐƠN";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.txt_STDKhachHang);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(17, 399);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(541, 126);
            this.panel8.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.bt_DoiDiem);
            this.panel11.Controls.Add(this.lb_DiemThuong);
            this.panel11.Location = new System.Drawing.Point(352, 27);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(176, 88);
            this.panel11.TabIndex = 11;
            // 
            // bt_DoiDiem
            // 
            this.bt_DoiDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.bt_DoiDiem.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bt_DoiDiem.FlatAppearance.BorderSize = 3;
            this.bt_DoiDiem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DoiDiem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_DoiDiem.Image = global::pbl.Properties.Resources.changr;
            this.bt_DoiDiem.Location = new System.Drawing.Point(2, 43);
            this.bt_DoiDiem.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DoiDiem.Name = "bt_DoiDiem";
            this.bt_DoiDiem.Size = new System.Drawing.Size(125, 43);
            this.bt_DoiDiem.TabIndex = 7;
            this.bt_DoiDiem.Text = "Đổi điểm";
            this.bt_DoiDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_DoiDiem.UseVisualStyleBackColor = false;
            this.bt_DoiDiem.Click += new System.EventHandler(this.bt_DoiDiem_Click);
            // 
            // lb_DiemThuong
            // 
            this.lb_DiemThuong.AutoSize = true;
            this.lb_DiemThuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiemThuong.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_DiemThuong.Location = new System.Drawing.Point(4, 7);
            this.lb_DiemThuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DiemThuong.Name = "lb_DiemThuong";
            this.lb_DiemThuong.Size = new System.Drawing.Size(121, 23);
            this.lb_DiemThuong.TabIndex = 13;
            this.lb_DiemThuong.Text = "Điểm thưởng: ";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lb_TenKhachHang);
            this.panel10.Controls.Add(this.lb_IDKhachHang);
            this.panel10.Location = new System.Drawing.Point(3, 79);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(319, 36);
            this.panel10.TabIndex = 10;
            // 
            // lb_TenKhachHang
            // 
            this.lb_TenKhachHang.AutoSize = true;
            this.lb_TenKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_TenKhachHang.Location = new System.Drawing.Point(135, 7);
            this.lb_TenKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TenKhachHang.Name = "lb_TenKhachHang";
            this.lb_TenKhachHang.Size = new System.Drawing.Size(45, 23);
            this.lb_TenKhachHang.TabIndex = 12;
            this.lb_TenKhachHang.Text = "Tên: ";
            // 
            // lb_IDKhachHang
            // 
            this.lb_IDKhachHang.AutoSize = true;
            this.lb_IDKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IDKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_IDKhachHang.Location = new System.Drawing.Point(12, 7);
            this.lb_IDKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_IDKhachHang.Name = "lb_IDKhachHang";
            this.lb_IDKhachHang.Size = new System.Drawing.Size(31, 23);
            this.lb_IDKhachHang.TabIndex = 11;
            this.lb_IDKhachHang.Text = "ID:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::pbl.Properties.Resources.search44;
            this.button2.Location = new System.Drawing.Point(252, 38);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 30);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_STDKhachHang
            // 
            this.txt_STDKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_STDKhachHang.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_STDKhachHang.Location = new System.Drawing.Point(69, 41);
            this.txt_STDKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_STDKhachHang.Name = "txt_STDKhachHang";
            this.txt_STDKhachHang.Size = new System.Drawing.Size(175, 20);
            this.txt_STDKhachHang.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Location = new System.Drawing.Point(70, 61);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(175, 1);
            this.panel9.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(16, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "SĐT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(113, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // bt_Huy
            // 
            this.bt_Huy.BackColor = System.Drawing.Color.White;
            this.bt_Huy.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bt_Huy.FlatAppearance.BorderSize = 3;
            this.bt_Huy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Huy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Huy.Image = global::pbl.Properties.Resources.huy;
            this.bt_Huy.Location = new System.Drawing.Point(566, 466);
            this.bt_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(131, 60);
            this.bt_Huy.TabIndex = 6;
            this.bt_Huy.Text = "Huỷ";
            this.bt_Huy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Huy.UseVisualStyleBackColor = false;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // bt_ThanhToan
            // 
            this.bt_ThanhToan.BackColor = System.Drawing.Color.White;
            this.bt_ThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bt_ThanhToan.FlatAppearance.BorderSize = 3;
            this.bt_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThanhToan.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_ThanhToan.Image = global::pbl.Properties.Resources.thanhtoan;
            this.bt_ThanhToan.Location = new System.Drawing.Point(566, 399);
            this.bt_ThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ThanhToan.Name = "bt_ThanhToan";
            this.bt_ThanhToan.Size = new System.Drawing.Size(131, 57);
            this.bt_ThanhToan.TabIndex = 5;
            this.bt_ThanhToan.Text = "Thanh toán";
            this.bt_ThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_ThanhToan.UseVisualStyleBackColor = false;
            this.bt_ThanhToan.Click += new System.EventHandler(this.bt_ThanhToan_Click);
            // 
            // ThemHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.bt_ThanhToan);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemHoadon";
            this.Load += new System.EventHandler(this.ThemHoadon_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.ComboBox cbb_PhanLoai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_DateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_STDKhachHang;
        private System.Windows.Forms.Button bt_ThanhToan;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Label lb_ThanhTien;
        private System.Windows.Forms.Label lb_GiamGia;
        private System.Windows.Forms.Label lb_Tong;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lb_DiemThuong;
        private System.Windows.Forms.Label lb_TenKhachHang;
        private System.Windows.Forms.Label lb_IDKhachHang;
        private System.Windows.Forms.Button bt_DoiDiem;
    }
}