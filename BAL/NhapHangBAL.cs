using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DAL;
namespace BAL
{
    public class NhapHangBAL
    {
        DataQLCHDTDataContext dbs;
        public  NhapHangBAL(string conn)
        {
            dbs = new DataQLCHDTDataContext(conn);
        }
        public ISingleResult<TimNhaCungCapResult> LayThongTinNhaCungCap(string ma)
        {
            return dbs.TimNhaCungCap(ma);
        }
        public bool CheckMaNCC(string ma)
        {
            bool? check = dbs.CheckNhaCC(ma);
            if (check == true)
                return true;
            return false;
        }
        public List<GetNhaCungCap> LayDanhSachNhaCungCap()
        {
            return dbs.GetNhaCungCaps.ToList();
        }
        public void ThemNhaCungCap(string ma, string ten, string diachi, string sdt)
        {
            dbs.ThemNhaCungCap(ma, ten, diachi, sdt);
        }
        public int SoLuongHoaDon()
        {
            return (int)dbs.DemSoLuongHoaDon();
        }
        public string LayMaHang(string tenHang)
        {
            return dbs.LayMaHang(tenHang);
        }
        public void ThucHienGiaoDich(string maHD, string maHang, string mancc, int soLuong, string idNV, DateTime ngayLap)
        {
            dbs.GiaoDichNhapHang(maHD, maHang, mancc, soLuong, idNV, ngayLap);
        }


    }
}
