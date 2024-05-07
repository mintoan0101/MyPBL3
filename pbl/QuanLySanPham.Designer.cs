namespace pbl
{
    partial class QuanLySanPham
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
            this.cb_boloc = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_tentimkiem = new System.Windows.Forms.TextBox();
            this.cb_phanloai = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_chitiet = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_chitiet);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(40, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 428);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.cb_boloc);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 49);
            this.panel2.TabIndex = 3;
            // 
            // cb_boloc
            // 
            this.cb_boloc.DisplayMember = "Sort By";
            this.cb_boloc.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_boloc.FormattingEnabled = true;
            this.cb_boloc.Location = new System.Drawing.Point(544, 11);
            this.cb_boloc.Margin = new System.Windows.Forms.Padding(4);
            this.cb_boloc.Name = "cb_boloc";
            this.cb_boloc.Size = new System.Drawing.Size(140, 28);
            this.cb_boloc.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_timkiem);
            this.panel3.Controls.Add(this.txt_tentimkiem);
            this.panel3.Controls.Add(this.cb_phanloai);
            this.panel3.Location = new System.Drawing.Point(17, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 29);
            this.panel3.TabIndex = 0;
            // 
            // txt_tentimkiem
            // 
            this.txt_tentimkiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tentimkiem.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tentimkiem.Location = new System.Drawing.Point(157, 5);
            this.txt_tentimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tentimkiem.Name = "txt_tentimkiem";
            this.txt_tentimkiem.Size = new System.Drawing.Size(259, 20);
            this.txt_tentimkiem.TabIndex = 1;
            // 
            // cb_phanloai
            // 
            this.cb_phanloai.DisplayMember = "Phân loại";
            this.cb_phanloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_phanloai.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_phanloai.FormattingEnabled = true;
            this.cb_phanloai.Location = new System.Drawing.Point(0, 1);
            this.cb_phanloai.Margin = new System.Windows.Forms.Padding(4);
            this.cb_phanloai.Name = "cb_phanloai";
            this.cb_phanloai.Size = new System.Drawing.Size(147, 27);
            this.cb_phanloai.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(704, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.BackColor = System.Drawing.Color.White;
            this.btn_chitiet.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_chitiet.FlatAppearance.BorderSize = 3;
            this.btn_chitiet.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chitiet.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_chitiet.Image = global::pbl.Properties.Resources.edit;
            this.btn_chitiet.Location = new System.Drawing.Point(555, 366);
            this.btn_chitiet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.Size = new System.Drawing.Size(169, 47);
            this.btn_chitiet.TabIndex = 7;
            this.btn_chitiet.Text = "Xem Chi Tiết";
            this.btn_chitiet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_chitiet.UseVisualStyleBackColor = false;
            this.btn_chitiet.Click += new System.EventHandler(this.btn_chitiet_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_them.FlatAppearance.BorderSize = 3;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Image = global::pbl.Properties.Resources.add3;
            this.btn_them.Location = new System.Drawing.Point(20, 366);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(169, 47);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_xoa.FlatAppearance.BorderSize = 3;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoa.Image = global::pbl.Properties.Resources.delete;
            this.btn_xoa.Location = new System.Drawing.Point(378, 366);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(169, 47);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.White;
            this.btn_sua.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_sua.FlatAppearance.BorderSize = 3;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sua.Image = global::pbl.Properties.Resources.sua2;
            this.btn_sua.Location = new System.Drawing.Point(201, 366);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(169, 47);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_timkiem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiem.Image = global::pbl.Properties.Resources.search44;
            this.btn_timkiem.Location = new System.Drawing.Point(423, -1);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(79, 30);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(824, 498);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sanpham";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_phanloai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_tentimkiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.ComboBox cb_boloc;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_chitiet;
    }
}