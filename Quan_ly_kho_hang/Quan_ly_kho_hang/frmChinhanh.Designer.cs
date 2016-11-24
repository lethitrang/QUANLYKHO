namespace Quan_ly_kho_hang
{
    partial class frmChinhanh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT_CN = new System.Windows.Forms.TextBox();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.txtDiaChi_CN = new System.Windows.Forms.TextBox();
            this.lblSDT_CN = new System.Windows.Forms.Label();
            this.lblDiaChi_CN = new System.Windows.Forms.Label();
            this.lblTenCN = new System.Windows.Forms.Label();
            this.lblMaCN = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvChiNhanh = new System.Windows.Forms.DataGridView();
            this.MaCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 80);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtSDT_CN);
            this.groupBox1.Controls.Add(this.txtTenCN);
            this.groupBox1.Controls.Add(this.txtMaCN);
            this.groupBox1.Controls.Add(this.txtDiaChi_CN);
            this.groupBox1.Controls.Add(this.lblSDT_CN);
            this.groupBox1.Controls.Add(this.lblDiaChi_CN);
            this.groupBox1.Controls.Add(this.lblTenCN);
            this.groupBox1.Controls.Add(this.lblMaCN);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txtSDT_CN
            // 
            this.txtSDT_CN.Location = new System.Drawing.Point(456, 24);
            this.txtSDT_CN.Name = "txtSDT_CN";
            this.txtSDT_CN.Size = new System.Drawing.Size(82, 20);
            this.txtSDT_CN.TabIndex = 7;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(197, 24);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(79, 20);
            this.txtTenCN.TabIndex = 5;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(53, 24);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(81, 20);
            this.txtMaCN.TabIndex = 4;
            // 
            // txtDiaChi_CN
            // 
            this.txtDiaChi_CN.Location = new System.Drawing.Point(328, 24);
            this.txtDiaChi_CN.Name = "txtDiaChi_CN";
            this.txtDiaChi_CN.Size = new System.Drawing.Size(76, 20);
            this.txtDiaChi_CN.TabIndex = 6;
            // 
            // lblSDT_CN
            // 
            this.lblSDT_CN.AutoSize = true;
            this.lblSDT_CN.Location = new System.Drawing.Point(410, 31);
            this.lblSDT_CN.Name = "lblSDT_CN";
            this.lblSDT_CN.Size = new System.Drawing.Size(29, 13);
            this.lblSDT_CN.TabIndex = 3;
            this.lblSDT_CN.Text = "SDT";
            // 
            // lblDiaChi_CN
            // 
            this.lblDiaChi_CN.AutoSize = true;
            this.lblDiaChi_CN.Location = new System.Drawing.Point(282, 31);
            this.lblDiaChi_CN.Name = "lblDiaChi_CN";
            this.lblDiaChi_CN.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi_CN.TabIndex = 2;
            this.lblDiaChi_CN.Text = "Địa chỉ";
            // 
            // lblTenCN
            // 
            this.lblTenCN.AutoSize = true;
            this.lblTenCN.Location = new System.Drawing.Point(140, 31);
            this.lblTenCN.Name = "lblTenCN";
            this.lblTenCN.Size = new System.Drawing.Size(44, 13);
            this.lblTenCN.TabIndex = 1;
            this.lblTenCN.Text = "Tên CN";
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Location = new System.Drawing.Point(0, 31);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(40, 13);
            this.lblMaCN.TabIndex = 0;
            this.lblMaCN.Text = "Mã CN";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(417, 108);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 36);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(336, 108);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 36);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới DL";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(255, 108);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 36);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(174, 108);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(93, 108);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 108);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm CN";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvChiNhanh
            // 
            this.dgvChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCN,
            this.TenCN,
            this.DiaChi,
            this.SDT});
            this.dgvChiNhanh.Location = new System.Drawing.Point(14, 159);
            this.dgvChiNhanh.Name = "dgvChiNhanh";
            this.dgvChiNhanh.Size = new System.Drawing.Size(550, 258);
            this.dgvChiNhanh.TabIndex = 13;
            this.dgvChiNhanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiNhanh_CellClick);
            this.dgvChiNhanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiNhanh_CellContentClick);
            // 
            // MaCN
            // 
            this.MaCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCN.DataPropertyName = "MaCN";
            this.MaCN.HeaderText = "Mã chi nhánh";
            this.MaCN.Name = "MaCN";
            // 
            // TenCN
            // 
            this.TenCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCN.DataPropertyName = "TenCN";
            this.TenCN.HeaderText = "Tên chi nhánh";
            this.TenCN.Name = "TenCN";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // Chinhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 417);
            this.Controls.Add(this.dgvChiNhanh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Name = "Chinhanh";
            this.Text = "Chinhanh";
            this.Load += new System.EventHandler(this.Chinhanh_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT_CN;
        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.TextBox txtDiaChi_CN;
        private System.Windows.Forms.Label lblSDT_CN;
        private System.Windows.Forms.Label lblDiaChi_CN;
        private System.Windows.Forms.Label lblTenCN;
        private System.Windows.Forms.Label lblMaCN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}