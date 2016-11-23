using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_ly_kho_hang
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            

        }

        private void lblThongTinHH_Click(object sender, EventArgs e)
        {
            
        }

        private void lblNhapHang_Click(object sender, EventArgs e)
        {
            
        }

        private void lbTimHang_Click(object sender, EventArgs e)
        {
            
        }

        private void lblNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap timhh = new frmNhaCungCap();
            timhh.Show();
        }

        private void đốiTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHangHoa _frmHangHoa = new frmHangHoa();
            _frmHangHoa.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPhieuNhap phieunhap = new frmPhieuNhap();
            phieunhap.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmXuathang frmXuat = new frmXuathang();
            frmXuat.Show();
        }

        private void lblThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHangHoa _frmHangHoa = new frmHangHoa();
            _frmHangHoa.Show();
        }

        private void btn_NhapHH_Click(object sender, EventArgs e)
        {
            frmPhieuNhap phieunhap = new frmPhieuNhap();
            phieunhap.Show();
        }

        private void btn_XuatHH_Click(object sender, EventArgs e)
        {
            frmXuathang frmXuat = new frmXuathang();
            frmXuat.Show();
        }

        private void btn_Nhacungcap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap timhh = new frmNhaCungCap();
            timhh.Show();
        }

        private void btn_TimHH_Click(object sender, EventArgs e)
        {
            frmTimHang timhh = new frmTimHang();
            timhh.Show();
        }

        private void btn_ChiNhanh_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            
        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            frmThongKe fr = new frmThongKe();
            fr.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
