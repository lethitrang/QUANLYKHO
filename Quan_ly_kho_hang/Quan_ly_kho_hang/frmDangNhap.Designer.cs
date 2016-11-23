namespace Quan_ly_kho_hang
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.DangNhap = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.chkHienThi = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(206, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin mời đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(273, 81);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(155, 20);
            this.txtTenDN.TabIndex = 3;
            this.txtTenDN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(273, 129);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(155, 20);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DangNhap
            // 
            this.DangNhap.Location = new System.Drawing.Point(178, 217);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(75, 23);
            this.DangNhap.TabIndex = 5;
            this.DangNhap.Text = "Đăng nhập";
            this.DangNhap.UseVisualStyleBackColor = true;
            this.DangNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(290, 217);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 23);
            this.Thoat.TabIndex = 6;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // chkHienThi
            // 
            this.chkHienThi.AutoSize = true;
            this.chkHienThi.Location = new System.Drawing.Point(273, 172);
            this.chkHienThi.Name = "chkHienThi";
            this.chkHienThi.Size = new System.Drawing.Size(109, 17);
            this.chkHienThi.TabIndex = 7;
            this.chkHienThi.Text = "Hiển thị mật khẩu";
            this.chkHienThi.UseVisualStyleBackColor = true;
            this.chkHienThi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "~Exit.png");
            this.imageList1.Images.SetKeyName(1, "add.png");
            this.imageList1.Images.SetKeyName(2, "add1.png");
            this.imageList1.Images.SetKeyName(3, "addIcon.png");
            this.imageList1.Images.SetKeyName(4, "AIM 6.png");
            this.imageList1.Images.SetKeyName(5, "AIM AQUA.png");
            this.imageList1.Images.SetKeyName(6, "AOL Instant Messenger.png");
            this.imageList1.Images.SetKeyName(7, "AQUA ICONS SYSTEM KEYS.png");
            this.imageList1.Images.SetKeyName(8, "b_drop.png");
            this.imageList1.Images.SetKeyName(9, "Background.jpg");
            this.imageList1.Images.SetKeyName(10, "cancel.png");
            this.imageList1.Images.SetKeyName(11, "cancel_f2.png");
            this.imageList1.Images.SetKeyName(12, "cancel1.png");
            this.imageList1.Images.SetKeyName(13, "cancel2.png");
            this.imageList1.Images.SetKeyName(14, "clock1.png");
            this.imageList1.Images.SetKeyName(15, "Collap.png");
            this.imageList1.Images.SetKeyName(16, "computer.png");
            this.imageList1.Images.SetKeyName(17, "conference-icon.png");
            this.imageList1.Images.SetKeyName(18, "DB_reload.ico");
            this.imageList1.Images.SetKeyName(19, "DB_reload1.ico");
            this.imageList1.Images.SetKeyName(20, "delete.png");
            this.imageList1.Images.SetKeyName(21, "delete1.png");
            this.imageList1.Images.SetKeyName(22, "DuyetGiaoDich.png");
            this.imageList1.Images.SetKeyName(23, "edit.png");
            this.imageList1.Images.SetKeyName(24, "Exit.png");
            this.imageList1.Images.SetKeyName(25, "Expand.png");
            this.imageList1.Images.SetKeyName(26, "go_first.png");
            this.imageList1.Images.SetKeyName(27, "go_last.png");
            this.imageList1.Images.SetKeyName(28, "groups_f2.png");
            this.imageList1.Images.SetKeyName(29, "groups_f21.png");
            this.imageList1.Images.SetKeyName(30, "huy bo.jpg");
            this.imageList1.Images.SetKeyName(31, "IcoFormDangNhap.ICO");
            this.imageList1.Images.SetKeyName(32, "IcoFrmDN.ico");
            this.imageList1.Images.SetKeyName(33, "icon_about.png");
            this.imageList1.Images.SetKeyName(34, "icon_datetime.png");
            this.imageList1.Images.SetKeyName(35, "icon_pagesetup.png");
            this.imageList1.Images.SetKeyName(36, "icon_print.png");
            this.imageList1.Images.SetKeyName(37, "icon_printpreview.png");
            this.imageList1.Images.SetKeyName(38, "image003.jpg");
            this.imageList1.Images.SetKeyName(39, "images1.jpg");
            this.imageList1.Images.SetKeyName(40, "langmanager.png");
            this.imageList1.Images.SetKeyName(41, "MayTinh1.png");
            this.imageList1.Images.SetKeyName(42, "MayTinh2.png");
            this.imageList1.Images.SetKeyName(43, "message_f2.png");
            this.imageList1.Images.SetKeyName(44, "new.png");
            this.imageList1.Images.SetKeyName(45, "no.png");
            this.imageList1.Images.SetKeyName(46, "open.png");
            this.imageList1.Images.SetKeyName(47, "person2_f2.png");
            this.imageList1.Images.SetKeyName(48, "PNGThoat.png");
            this.imageList1.Images.SetKeyName(49, "print.gif");
            this.imageList1.Images.SetKeyName(50, "print2.gif");
            this.imageList1.Images.SetKeyName(51, "properties_f2.png");
            this.imageList1.Images.SetKeyName(52, "reload_f2.png");
            this.imageList1.Images.SetKeyName(53, "remove.png");
            this.imageList1.Images.SetKeyName(54, "restore.png");
            this.imageList1.Images.SetKeyName(55, "restore_f2.png");
            this.imageList1.Images.SetKeyName(56, "restore1.png");
            this.imageList1.Images.SetKeyName(57, "save.png");
            this.imageList1.Images.SetKeyName(58, "save_icon.gif");
            this.imageList1.Images.SetKeyName(59, "save_icon20.gif");
            this.imageList1.Images.SetKeyName(60, "security.png");
            this.imageList1.Images.SetKeyName(61, "security_f2.png");
            this.imageList1.Images.SetKeyName(62, "stop_f2.png");
            this.imageList1.Images.SetKeyName(63, "switch_f2.png");
            this.imageList1.Images.SetKeyName(64, "Thoat.png");
            this.imageList1.Images.SetKeyName(65, "tick.png");
            this.imageList1.Images.SetKeyName(66, "windowlist.png");
            this.imageList1.Images.SetKeyName(67, "windows.png");
            this.imageList1.Images.SetKeyName(68, "xem.bmp");
            this.imageList1.Images.SetKeyName(69, "XọaPG.jpg");
            this.imageList1.Images.SetKeyName(70, "~Exit.png");
            // 
            // label4
            // 
            this.label4.ImageIndex = 31;
            this.label4.ImageList = this.imageList1;
            this.label4.Location = new System.Drawing.Point(23, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 153);
            this.label4.TabIndex = 8;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(440, 256);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkHienThi);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.DangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button DangNhap;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.CheckBox chkHienThi;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label4;
    }
}

