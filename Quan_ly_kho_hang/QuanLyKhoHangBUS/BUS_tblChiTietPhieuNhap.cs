using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using System.Data;

namespace QuanLyKhoHangBUS
{
    public class BUS_tblChiTietPhieuNhap
    {
        SQL_tblChiTietPhieuNhap sql = new SQL_tblChiTietPhieuNhap();
        public DataTable getALLChiTietPhieuNhap()
        {
            return sql.getALLChiTietPhieuNhap();
        }
        public DataTable getChitiet_MaPN(string MaPN)
        {
            return sql.getChitiet_MaPN(MaPN);
        }
        public void Them(EC_tblChiTietPhieuNhap et)
        {
            sql.Them(et);
        }
        public void Sua(EC_tblChiTietPhieuNhap et)
        {
            sql.Sua(et);
        }
        public void Xoa(EC_tblChiTietPhieuNhap et)
        {
            sql.Xoa(et);
        }
        public DataTable getChitiet()
        {
            return sql.getChitiet();
        }
        public DataTable getChitietHH(string value)
        {
            return sql.getChitietHH(value);
        }
        public void Them_TT(EC_tblChiTietPhieuNhap et)
        {
             sql.Them_TT(et);
        }
    }
}

