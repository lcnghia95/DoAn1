using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
   
    public class NhanVienBAL
    {
        DataQLCHDTDataContext dbs;
        public NhanVienBAL(string conn)
        {
            dbs = new DataQLCHDTDataContext(conn);
        }
        public List<GetNhanVien> LayNhanVien()
        {
            return dbs.GetNhanViens.ToList();
        }
        public List<GetNhanVien1> LayNhanVien1()
        {
            return dbs.GetNhanVien1s.ToList();
        }
        public void ThemNhanVien(string ID ,string hoten,string gioitinh, DateTime ngaysinh,string email,string cmnd,string diachi,string chucvu)
        {
            dbs.ThemNhanVien(ID, hoten, gioitinh, ngaysinh, email, Int32.Parse(cmnd), diachi, chucvu);
        }
        public void UpdateNhanVien(string ID, string hoten, string gioitinh, DateTime ngaysinh, string email, string cmnd, string diachi, string chucvu)
        {
            dbs.UpdateNhanVien(ID, hoten, gioitinh, ngaysinh, email, Int32.Parse(cmnd), diachi, chucvu);
        }
        public void KhoiPhucNhanVien(string id)
        {
            dbs.KhoiPhucNhanVien(id);
        }
        public void XoaNhanVien(string ID)
        {
            dbs.XoaNhanVien(ID);
        }
        public bool CheckNhanVien(string ID)
        {
            bool? check = dbs.CheckNhanVien(ID);
            if (check == true)
                return true;
            return false;
        }
    }
}
