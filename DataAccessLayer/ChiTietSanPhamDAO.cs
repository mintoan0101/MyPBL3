using Mysqlx.Crud;
using pbl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ChiTietSanPhamDAO
    {
        DBConnection db = new DBConnection();
        public DataTable GetData(string id)
        {
            return db.GetData("select IDChiTiet,TenNhaPhanPhoi,HanSuDung,isDelete from chitietsanpham join nhaphanphoi on chitietsanpham.IDNhaPhanPhoi = nhaphanphoi.IDNhaPhanPhoi where IDSanPham = '"+id+"'");
        }
        public DataTable GetData2(string query)
        {
            return db.GetData(query);
        }
        public int Insert(ChiTietSanPham ctsp)
        {
            return db.ExcuteData("insert into chitietsanpham(IDChiTiet,IDSanPham,IDNhaPhanPhoi,HanSuDung,isDelete) values " +
                "('"+ctsp.IDChiTiet+"','"+ctsp.IDSanPham+"','"+ctsp.IDNhaPhanPhoi+"','"+ctsp.HanSuDung+"',0)"); 
        }
        public int Delete(string id)
        {
            return db.ExcuteData("update chitietsanpham set isDelete = 1 where IDChiTiet ='"+id+"'");
        }
        public int Update(string id, ChiTietSanPham ctsp)
        {
            return db.ExcuteData("update chitietsanpham set IDNhaPhanPhoi = '"+ctsp.IDNhaPhanPhoi+"',HanSuDung = '"+ctsp.HanSuDung+"',isDelete = "+ctsp.isDelete+" where IDChiTiet = '"+id+"'");
        }
        public ChiTietSanPham GetCTSP(string IDChiTiet)
        {
            ChiTietSanPham ct = new ChiTietSanPham();
            DataTable dt = db.GetData("select * from chitietsanpham where IDChiTiet ='"+IDChiTiet+"'");
            ct.IDChiTiet = dt.Rows[0][0].ToString();
            ct.IDSanPham = dt.Rows[0][1].ToString();
            ct.IDNhaPhanPhoi = dt.Rows[0][2].ToString();
            ct.HanSuDung = dt.Rows[0][3].ToString();
            ct.isDelete = (dt.Rows[0][4].ToString() == "0") ? false : true;
            return ct;
        }
        public int CountID()
        {
            return db.CountRows("select * from chitietsanpham");
        }
    }
}
