﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangEntity;
using System.Data;

namespace QuanLyKhoHangDAL
{
    public class SQL_tblChiNhanh
    {
        KetNoiData cn = new KetNoiData();
        public DataTable getAllChiNhanh()
        {
            return cn.GetDataTable(@"SELECT * from tblChiNhanh");
        }
        public DataTable getChiNhanh(string dk)
        {
            return cn.GetDataTable(@"SELECT * from tblChiNhanh " + dk);
        }
        public int ThemDuLieu(EC_tblChiNhanh et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO tblChiNhanh (MaCN,TenCN,DiaChi,SDT) 
            VALUES('" + et.MaCN + "', N'" + et.TenCN + "',N'" + et.DiaChi + "', " + et.SDT + ")");
        }
        public int SuaDuLieu(EC_tblChiNhanh et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE tblChiNhanh SET TenCN =N'" + et.TenCN + "', DiaChi =N'" + et.DiaChi + "', SDT ='" + et.SDT + "' where MaCN= '" + et.MaCN + "'");
        }
        public int XoaDuLieu(EC_tblChiNhanh et)
        {
            return cn.ThucThiCauLenhSQL(@"DELETE FROM tblChiNhanh where MaCN=N'" + et.MaCN + "'");
        }
        public DataTable LayRaMaCN()//lấy ra top 1 mã thiết bị có tên mã thiết bị là gì đó
        {
            return cn.GetDataTable("select top 1  MaCN from tblChiNhanh order by MaCN desc ");
        }
        //    }
        //
        ////    KetNoiData cn = new KetNoiData();
        //    public DataTable TaoBang(string DieuKien)// ham nay = hàm getChiNhanh(dk)
        //    {
        //        return cn.GetDataTable("SELECT * from tblChiNhanh " + DieuKien);
        //    }
        //public int ThemDuLieu(EC_tblChiNhanh et)
        //{
        //    return cn.ThucThiCauLenhSQL(@"INSERT INTO tblChiNhanh (MaCN,TenCN,DiaChi,SDT) 
        //        VALUES('" + et.MaCN + "', N'" + et.TenCN + "',N'" + et.DiaChi + "', " + et.SDT + ")");
        //}
        //public int SuaDuLieu1(EC_tblChiNhanh et)
        //{
        //    return cn.ThucThiCauLenhSQL(@"UPDATE tblChiNhanh SET TenCN =N'" + et.MaCN + "', DiaChi =N'" + et.DiaChi + "', SDT ='" + et.SDT + "' where MaNC= '" + et.MaCN + "'");
        //}
        //public int XoaDuLieu(EC_tblChiNhanh et)
        //{
        //    return cn.ThucThiCauLenhSQL(@"DELETE FROM tblChiNhanh where MaCN=N'" + et.MaCN + "'");
        //}

        public DataTable getField(string field, string table, string dk)
        {
            return cn.GetDataTable(@"Select distinct " + field + " from " + table + " " + dk);
        }
    }
}
