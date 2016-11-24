using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKhoHangBUS;
using QuanLyKhoHangEntity;
namespace Quan_ly_kho_hang
{
    public partial class frmChinhanh : Form
    {


        EC_tblChiNhanh ec = new EC_tblChiNhanh();
        BUS_tblChiNhanh bus = new BUS_tblChiNhanh();
        private bool themmoi;
        void SetNull()
        {
            txtMaCN.Text = "";
            txtTenCN.Text = "";
            txtDiaChi_CN.Text = "";
            txtSDT_CN.Text = "";
        }
        private void KhoaDieuKhien()
        {
            txtMaCN.ReadOnly = true;
            txtTenCN.ReadOnly = true;
            txtDiaChi_CN.ReadOnly = true;
            txtSDT_CN.ReadOnly = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

        }
        private void MoDieuKhien()
        {
            txtMaCN.ReadOnly = false;
            txtTenCN.ReadOnly = false;
            txtDiaChi_CN.ReadOnly = false;
            txtSDT_CN.ReadOnly = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

        }
        public frmChinhanh()
        {
            InitializeComponent();
        }

        private void HienThi(string where)
        {
            dgvChiNhanh.DataSource = bus.getChiNhanh(where);
        }
        void TuDanhMaCN()//ham này dùng trong trường hợp thêm tb thì nếu chỉ nhập tên tb thì sẽ tự động đánh MaTB
        {
            DataTable MaCN;
            MaCN = bus.LayRaMaCN();
            txtMaCN.DataBindings.Clear();
            txtMaCN.DataBindings.Add("Text", MaCN, "MaCN", true);
            string MP = txtMaCN.Text;
            int stt = int.Parse(MP.Substring(2, MP.Length - 2)) + 1;
            if (stt < 10) { txtMaCN.Text = MP.Substring(0, 2) + "0" + stt.ToString(); }
            else txtMaCN.Text = MP.Substring(0, 2) + stt.ToString();

        }

        private void Chinhanh_Load(object sender, EventArgs e)
        {
            HienThi("");
            KhoaDieuKhien();
        }

        private void dgvChiNhanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvChiNhanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
                txtMaCN.Text = dgvChiNhanh.Rows[dong].Cells[0].Value.ToString();
                txtTenCN.Text = dgvChiNhanh.Rows[dong].Cells[1].Value.ToString();
                txtDiaChi_CN.Text = dgvChiNhanh.Rows[dong].Cells[2].Value.ToString();
                txtSDT_CN.Text = dgvChiNhanh.Rows[dong].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaCN.ReadOnly = true;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan;
            xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.OK)
            {
                ec.MaCN = txtMaCN.Text;
                if (bus.XoaDuLieu(ec) == 0)
                {

                    MessageBox.Show("Không thể xoá!!!", "Thông báo???", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    bus.XoaDuLieu(ec);
                    MessageBox.Show("Đã xóa thành công!");
                    btnLamMoi_Click(sender, e);
                    SetNull();

                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaCN.Text == "" || txtTenCN.Text == "" || txtDiaChi_CN.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ");
                KhoaDieuKhien();
                return;
            }
            else
            {
                if (themmoi == true)/*đang ở trang thái thêm mới*/
                {
                    try
                    {
                        ec.MaCN = txtMaCN.Text;
                        ec.TenCN = txtTenCN.Text;
                        ec.DiaChi = txtDiaChi_CN.Text;
                        ec.SDT = txtSDT_CN.Text;

                        bus.ThemDuLieu(ec);
                        MessageBox.Show("Đã thêm mới thành công");/*dòng thông báo*/
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }

                }
                else
                {
                    try
                    {
                        ec.MaCN = txtMaCN.Text;
                        ec.TenCN = txtTenCN.Text;
                        ec.DiaChi = txtDiaChi_CN.Text;
                        ec.SDT = txtSDT_CN.Text;
                        bus.SuaDuLieu(ec);
                        MessageBox.Show("Đã sửa thành công");

                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                }
                SetNull();
                KhoaDieuKhien();/*không cho thao tác*/
                HienThi("");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kich hoat cac chuc năng
            /*btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;*/

            MoDieuKhien();
            SetNull();
            TuDanhMaCN();
            txtMaCN.ReadOnly = true;
            themmoi = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DataTable tbl = bus.getChiNhanh("");
            dgvChiNhanh.DataSource = tbl;
        }
    }
}
