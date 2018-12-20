using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DAL;

namespace BAL
{
    public partial class BanHangBAL
    {
        private string conn;
        DataQLCHDTDataContext dbs;

        public string Conn { get => conn; set => conn = value; }
        public DataQLCHDTDataContext Dbs { get => dbs; set => dbs = value; }
        public BanHangBAL(string conn)
        {
            Conn = conn;
            Dbs = new DataQLCHDTDataContext(conn);
        }

        public ISingleResult<TimKhachHangResult> LayThongTinKhachHang(string id)
        {
            return Dbs.TimKhachHang(id);
        }
        public int SoLuongHoaDon()
        {
            return (int)Dbs.DemSoLuongHoaDon();
        }
        public ISingleResult<LayThongTinSanPhamResult> LayMatHang()
        {
            return Dbs.LayThongTinSanPham();
        }
        
        public List<MATHANG> LayThongTinMatHang()
        {
            return Dbs.MATHANGs.ToList();
        }
        public void ThucHienGiaoDich(string maHD,string maHang,string idKhach,int soLuong,string idNV,DateTime ngayLap)
        {
            Dbs.GiaoDichMuaHang(maHD, maHang, idKhach, soLuong, idNV, ngayLap);
        }
        public string LayMaHang(string tenHang)
        {
            return Dbs.LayMaHang(tenHang);
        }
        public void ThemMatHang(string a, string b, string c, string d)
        {
            Dbs.ThemMatHang(a, b, Int32.Parse(c), Int32.Parse(d));
        }
        public int DemSoLuongMatHang()
        {
            return (int)Dbs.DemSoLuongMatHang();
        }
        
    }
}
