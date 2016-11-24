using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using QuanLyKhoHangBUS;

namespace Quan_ly_kho_hang
{
    public partial class frm_PhieuNhap : Form
    {

        SQL_tblChiTietPhieuNhap sql_ctpn = new SQL_tblChiTietPhieuNhap();
        SQL_tblPhieuNhap sql_pn = new SQL_tblPhieuNhap();
      
        SQL_tblHangHoa sql_hh = new SQL_tblHangHoa();
        EC_tblChiTietPhieuNhap ec_ctpn = new EC_tblChiTietPhieuNhap();
        EC_tblPhieuNhap ec_pn = new EC_tblPhieuNhap();
        EC_tblHangHoa ec_hh = new EC_tblHangHoa();
        BUS_tblPhieuNhap bus_pn = new BUS_tblPhieuNhap();
        BUS_tblChiTietPhieuNhap bus_ctpn = new BUS_tblChiTietPhieuNhap();
        BUS_tblHangHoa bus_hh = new BUS_tblHangHoa();

        bool themmoi = false;
        bool themmoiCTPN = false;


        private void HienThi(string where)
        {
            dgv_PhieuNhap.DataSource = bus_pn.getPN("");
            dgvCTPhieuNhap.DataSource = bus_ctpn.getALLChiTietPhieuNhap();
            dgvHangHoa.DataSource = bus_hh.TaoBang("");
        }
        void SetNull_PN()
        {
            txtMaPH.Text = "";
            txtMaNCC.Text = "";
            txtNgayNhap.Text = "";
            txtTongTien.Text = "";
        }
        void SetNull_CTPN()
        {
            txtMaPH.Text = "";
            txtMaHH.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtTenHH.Text = "";
        }

        //Khóa, Mở điều khiển
        private void KhoaDieuKhien_PN()
        {
            txtMaPH.ReadOnly = true;
            txtMaNCC.ReadOnly = true;
            txtNgayNhap.ReadOnly = true;
            txtTongTien.ReadOnly = true;        

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

        }
        private void KhoaDieuKhien_CTPN()
        {

            txtCTMaPH.ReadOnly = true;
            txtMaHH.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtTenHH.ReadOnly = true;

            btnThemCTPN.Enabled = true;
            btnSuaCTPN.Enabled = true;
            btnXoaCTPN.Enabled = true;
            btnLuuCTPN.Enabled = false;

        }
        private void MoDieuKhien_PN()
        {
            txtMaPH.ReadOnly = false;
            txtMaNCC.ReadOnly = false;
            txtNgayNhap.ReadOnly = false;
            txtTongTien.ReadOnly = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

        }
        private void MoDieuKhien_CTPN()
        {
            txtCTMaPH.ReadOnly = false;
            txtMaHH.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtTenHH.ReadOnly = false;

            btnThemCTPN.Enabled = false;
            btnSuaCTPN.Enabled = false;
            btnXoaCTPN.Enabled = false;
            btnLuuCTPN.Enabled = true;

        }
        //
        public frm_PhieuNhap()
        {
            InitializeComponent();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        //phần này khoan đã
        public void LoadPN()
        {
            DataTable dt = new DataTable();
            dt = sql_pn.getPN(txtCTMaPH.Text);
            txtMaNCC.Text = dt.Rows[0][0].ToString();
            txtNgayNhap.Text = dt.Rows[0][1].ToString();
            txtTongTien.Text = dt.Rows[0][2].ToString();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            txtMaPH.Text = txtCTMaPH.Text;
            LoadPN();
            dgvCTPhieuNhap.DataSource = sql_ctpn.getChitietHH(txtMaPH.Text);// show hàng hóa trong chi tiêt phiếu nhâp
        }
        /////

        //  databiding PhieuNhap
        private void dgv_PhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
                txtMaPH.Text = dgv_PhieuNhap.Rows[dong].Cells[0].Value.ToString();
                txtMaNCC.Text = dgv_PhieuNhap.Rows[dong].Cells[1].Value.ToString();
                txtNgayNhap.Text = dgv_PhieuNhap.Rows[dong].Cells[2].Value.ToString();
                txtTongTien.Text = dgv_PhieuNhap.Rows[dong].Cells[3].Value.ToString();
                dgvCTPhieuNhap.DataSource = bus_ctpn.getChitiet_MaPN(dgv_PhieuNhap.Rows[dong].Cells[0].Value.ToString());
       //         MoDieuKhien_CTPN();
        //        MoDieuKhien_PN();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
            }
            catch
            {

            }
            
        }
        //  databiding ChiTiet PhieuNhap
        private void dgvCTPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
            txtMaPH.Text = dgvCTPhieuNhap.Rows[dong].Cells[0].Value.ToString();
            txtMaHH.Text = dgvCTPhieuNhap.Rows[dong].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvCTPhieuNhap.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dgvCTPhieuNhap.Rows[dong].Cells[3].Value.ToString();
        }

        private void frm_PhieuNhap_Load(object sender, EventArgs e)
        {

            KhoaDieuKhien_PN();
            KhoaDieuKhien_CTPN();
            dgv_PhieuNhap.DataSource = bus_pn.getPhieuNhap();
            dgvCTPhieuNhap.DataSource = bus_ctpn.getALLChiTietPhieuNhap();
            dgvHangHoa.DataSource = bus_hh.TaoBang1("");


        }
        void TuDanhMaPN()//ham này dùng trong trường hợp thêm tb thì nếu chỉ nhập tên tb thì sẽ tự động đánh MaTB
        {
            DataTable MaPN;
            MaPN = bus_pn.LayRaMaPN();
            txtMaPH.DataBindings.Clear();
            txtMaPH.DataBindings.Add("Text", MaPN, "MaPN", true);
            string MP = txtMaPH.Text;
            int stt = int.Parse(MP.Substring(2, MP.Length - 2)) + 1;
            if (stt < 10) { txtMaPH.Text = MP.Substring(0, 2) + "0" + stt.ToString(); }
            else txtMaPH.Text = MP.Substring(0, 2) + stt.ToString();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            MoDieuKhien_PN();
            SetNull_PN();
            SetNull_CTPN();
            TuDanhMaPN();

            txtTenHH.ReadOnly = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnLamMoi.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e) // Phiếu nhập
        {
            if (themmoi == false)      //đang ở trạng thái sửa phiếu nhập
            {
                ec_pn.MaPN = txtMaPH.Text;
                ec_pn.MaNCC = txtMaNCC.Text;
                ec_pn.NgayNhap = txtNgayNhap.Text;
      //          ec_pn.TongTien = int.Parse(txtTongTien.Text);
                bus_pn.Sua(ec_pn);
                

                btnThem.Enabled = true;               
                btnXoa.Enabled = true;
                MessageBox.Show("Bạn đã sửa phiếu nhập thành cônng", "Thông Báo", MessageBoxButtons.OK);
                dgv_PhieuNhap.DataSource = bus_pn.getPhieuNhap();
            }
            else                         // đang ở trạng thái thêm phiếu nhập
            {
                ec_pn.MaPN = txtMaPH.Text;
                ec_pn.MaNCC = txtMaNCC.Text;
                ec_pn.NgayNhap = txtNgayNhap.Text;
          //      ec_pn.TongTien = int.Parse(txtTongTien.Text);
                bus_pn.Them(ec_pn);               
                
                MessageBox.Show("Bạn đã thêm vào phiếu nhập thành cônng", "Thông Báo", MessageBoxButtons.OK);
                dgv_PhieuNhap.DataSource = bus_pn.getPhieuNhap();
                
            }
            MoDieuKhien_PN();
            
        }

        private void btnSua_Click(object sender, EventArgs e)// Phieu nhap
        {
            themmoi = false;
            MoDieuKhien_PN();
            btnLuu.Enabled = true;
            btnLamMoi.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)// Phiếu nhập
        {
            KhoaDieuKhien_PN();
            SetNull_PN();
            SetNull_CTPN();
            dgv_PhieuNhap.DataSource = bus_pn.getPhieuNhap();
       //     bus_pn.CapNhatTongTien();


        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            themmoiCTPN = true;
            MoDieuKhien_CTPN();
            SetNull_PN();
            SetNull_CTPN();
            

            txtTenHH.ReadOnly = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnLamMoi.Enabled = true;
        }

        private void btnLuuCTPN_Click(object sender, EventArgs e)
        {
           
            if (themmoi == false)      //đang ở trạng thái sửa CT phiếu nhập
            {
                ec_ctpn.MaPN = txtCTMaPH.Text;
                ec_ctpn.MaHH = txtMaHH.Text;
                ec_ctpn.SoLuong =int.Parse(txtSoLuong.Text);
                ec_ctpn.DonGia = int.Parse(txtDonGia.Text);
          //      ec_ctpn.ThanhTien = ec_ctpn.SoLuong * ec_ctpn.DonGia;
                //          ec_pn.TongTien = int.Parse(txtTongTien.Text);
               bus_ctpn.Sua(ec_ctpn);
                


                btnThemCTPN.Enabled = true;
                btnXoaCTPN.Enabled = true;
                MessageBox.Show("Bạn đã sửa chi tiết phiếu nhập thành công", "Thông Báo", MessageBoxButtons.OK);
                dgvCTPhieuNhap.DataSource = bus_ctpn.getChitiet_MaPN(ec_ctpn.MaPN);
            }
            else                         // đang ở trạng thái thêm phiếu nhập
            {
                ec_ctpn.MaPN = txtCTMaPH.Text;
                ec_ctpn.MaHH = txtMaHH.Text;
                ec_ctpn.SoLuong = int.Parse(txtSoLuong.Text);
                ec_ctpn.DonGia = int.Parse(txtDonGia.Text);
          //      ec_ctpn.ThanhTien = ec_ctpn.SoLuong * ec_ctpn.DonGia;
                bus_ctpn.Them_TT(ec_ctpn);

                MessageBox.Show("Bạn đã thêm vào phiếu nhập thành cônng", "Thông Báo", MessageBoxButtons.OK);
                dgv_PhieuNhap.DataSource = bus_pn.getPhieuNhap();

            }
            MoDieuKhien_CTPN();

        }

        private void btnLamMoiCTPN_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien_CTPN();
            SetNull_PN();
            SetNull_CTPN();
            dgvCTPhieuNhap.DataSource = bus_ctpn.getChitiet();
       //     sql_pn.CapNhatTongTien();
        }

        private void btnSuaCTPN_Click(object sender, EventArgs e)
        {
            themmoiCTPN = false;
            MoDieuKhien_CTPN();
            btnLuuCTPN.Enabled = true;
            btnLamMoiCTPN.Enabled = true;
            btnThemCTPN.Enabled = false;
            btnXoaCTPN.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e) // xóa phieu nhap
        {
            DialogResult xacnhan;
            xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.OK)
            {
                ec_pn.MaPN = txtMaPH.Text;
                bus_pn.Xoa(ec_pn);
                MessageBox.Show("Đã xóa thành công!");
                btnLamMoi_Click(sender, e);
                SetNull_PN();

                }
            }

        private void btnXoaCTPN_Click(object sender, EventArgs e)// xóa CTPN
        {
            DialogResult xacnhan;
            xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.OK)
            {
                ec_ctpn.MaPN = txtCTMaPH.Text;
                bus_ctpn.Xoa(ec_ctpn);
                MessageBox.Show("Đã xóa thành công!");
                btnLamMoiCTPN_Click(sender, e);
                SetNull_CTPN();

            }
        }
    }
   
}
