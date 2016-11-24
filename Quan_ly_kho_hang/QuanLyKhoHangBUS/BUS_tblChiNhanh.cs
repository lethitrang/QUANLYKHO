using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using System.Data;


namespace QuanLyKhoHangBUS
{
    public class BUS_tblChiNhanh
    {
        SQL_tblChiNhanh sql = new SQL_tblChiNhanh();
        public DataTable getAllChiNhanh()
        {
            return sql.getAllChiNhanh();
        }
        public DataTable getChiNhanh(string dk)
        {
            return sql.getChiNhanh(dk);
        }
        public int ThemDuLieu(EC_tblChiNhanh et)
        {
            return sql.ThemDuLieu(et);
        }
        public int SuaDuLieu(EC_tblChiNhanh et)
        {
            return sql.SuaDuLieu(et);
        }
        public int XoaDuLieu(EC_tblChiNhanh et)
        {
            return sql.XoaDuLieu(et);
        }
        public DataTable LayRaMaCN()
        {
            return sql.LayRaMaCN();
        }
        /////sử dụng lại hàm getField 
        public DataTable getField(string field, string table, string dk)
        {
            return getField(field, table, dk);
        }




    }
}
