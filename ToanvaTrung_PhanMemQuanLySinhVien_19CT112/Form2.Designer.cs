namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.butXem = new Guna.UI2.WinForms.Guna2Button();
            this.butClear = new Guna.UI2.WinForms.Guna2Button();
            this.butXoa = new Guna.UI2.WinForms.Guna2Button();
            this.butSua = new Guna.UI2.WinForms.Guna2Button();
            this.butThem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 517);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1229, 162);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1229, 52);
            this.label1.TabIndex = 34;
            this.label1.Text = "Quản Lý Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.butXem);
            this.guna2GroupBox3.Controls.Add(this.butClear);
            this.guna2GroupBox3.Controls.Add(this.butXoa);
            this.guna2GroupBox3.Controls.Add(this.butSua);
            this.guna2GroupBox3.Controls.Add(this.butThem);
            this.guna2GroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 300);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(1229, 175);
            this.guna2GroupBox3.TabIndex = 60;
            this.guna2GroupBox3.Text = "Công Cụ";
            // 
            // butXem
            // 
            this.butXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butXem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butXem.ForeColor = System.Drawing.Color.White;
            this.butXem.Location = new System.Drawing.Point(993, 59);
            this.butXem.Name = "butXem";
            this.butXem.Size = new System.Drawing.Size(180, 45);
            this.butXem.TabIndex = 4;
            this.butXem.Text = "Xem";
            this.butXem.Click += new System.EventHandler(this.butXem_Click);
            // 
            // butClear
            // 
            this.butClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butClear.ForeColor = System.Drawing.Color.White;
            this.butClear.Location = new System.Drawing.Point(774, 59);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(180, 45);
            this.butClear.TabIndex = 3;
            this.butClear.Text = "Clear";
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butXoa
            // 
            this.butXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butXoa.ForeColor = System.Drawing.Color.White;
            this.butXoa.Location = new System.Drawing.Point(555, 59);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(180, 45);
            this.butXoa.TabIndex = 2;
            this.butXoa.Text = "Xóa";
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butSua
            // 
            this.butSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butSua.ForeColor = System.Drawing.Color.White;
            this.butSua.Location = new System.Drawing.Point(336, 59);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(180, 45);
            this.butSua.TabIndex = 1;
            this.butSua.Text = "Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butThem
            // 
            this.butThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butThem.ForeColor = System.Drawing.Color.White;
            this.butThem.Location = new System.Drawing.Point(117, 56);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(180, 45);
            this.butThem.TabIndex = 0;
            this.butThem.Text = "Thêm";
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cmbGioiTinh);
            this.guna2GroupBox1.Controls.Add(this.txtMaLop);
            this.guna2GroupBox1.Controls.Add(this.txtDiaChi);
            this.guna2GroupBox1.Controls.Add(this.txtHoTen);
            this.guna2GroupBox1.Controls.Add(this.txtNgaySinh);
            this.guna2GroupBox1.Controls.Add(this.txtMaSV);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 52);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1229, 248);
            this.guna2GroupBox1.TabIndex = 59;
            this.guna2GroupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(576, 74);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(266, 39);
            this.cmbGioiTinh.TabIndex = 96;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(1013, 130);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(191, 38);
            this.txtMaLop.TabIndex = 95;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(1013, 74);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(191, 38);
            this.txtDiaChi.TabIndex = 94;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(203, 130);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(186, 38);
            this.txtHoTen.TabIndex = 93;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Location = new System.Drawing.Point(576, 137);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(266, 38);
            this.txtNgaySinh.TabIndex = 92;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(203, 77);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(186, 38);
            this.txtMaSV.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(868, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 31);
            this.label7.TabIndex = 90;
            this.label7.Text = "Mã Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(866, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 31);
            this.label6.TabIndex = 89;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(429, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 31);
            this.label5.TabIndex = 88;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(429, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 87;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 86;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 31);
            this.label2.TabIndex = 85;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 679);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2Button butXem;
        private Guna.UI2.WinForms.Guna2Button butClear;
        private Guna.UI2.WinForms.Guna2Button butXoa;
        private Guna.UI2.WinForms.Guna2Button butSua;
        private Guna.UI2.WinForms.Guna2Button butThem;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}