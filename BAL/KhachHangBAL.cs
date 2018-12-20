using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
    public class KhachHangBAL
    {
        DataQLCHDTDataContext dbs;
        public KhachHangBAL(string conn)
        {
            dbs = new DataQLCHDTDataContext(conn);
        }
        public List<GetKhachHang> LayKhachHang()
        {
            return dbs.GetKhachHangs.ToList();
        }
        public List<NGUOI> LayMaMoi()
        {
            return dbs.NGUOIs.ToList();
        }
        public void ThemKhachHang(string ID, string hoten, string gioitinh, DateTime ngaysinh, string email, string cmnd, string diachi)
        {
            dbs.ThemKhacHang(ID, hoten, gioitinh, ngaysinh, email, Int32.Parse(cmnd), diachi);
        }
        public void UpdateKhachHang(string ID, string hoten, string gioitinh, DateTime ngaysinh, string email, string cmnd, string diachi)
        {
            dbs.UpdateKhachHang(ID, hoten, gioitinh, ngaysinh, email, Int32.Parse(cmnd), diachi);
        }
     
        public bool CheckKhachHang(string ID)
        {
            bool? check = dbs.CheckNhanVien(ID);
            if (check == true)
                return true;
            return false;
        }

    }
}
