using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using System.Data;

namespace QuanLyKhoHangBUS
{
    public class BUS_tblPhieuNhap
    {
        SQL_tblPhieuNhap sql = new SQL_tblPhieuNhap();
        
        public DataTable getPhieuNhap()
        {
            return sql.getPhieuNhap();
        }
        public void Them(EC_tblPhieuNhap et)
        {
            sql.Them(et);
        }
        public void Sua(EC_tblPhieuNhap et)
        {
            sql.Sua(et);
        }
        public void Xoa(EC_tblPhieuNhap et)
        {
            sql.Xoa(et);
        }
        public DataTable getPN(string value)
        {
            return sql.getPN(value);
        }
        public void CapNhatTongTien()
        {
            sql.CapNhatTongTien();
        }
        public DataTable LayRaMaPN()
        {
            return sql.LayRaMaPN();
        }

    }
}
