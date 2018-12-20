using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Linq;
using DAL;

namespace BAL
{  
    public class PhanQuyenBAL
    {
        DataQLCHDTDataContext dbs;
        public PhanQuyenBAL(string conn)
        {
            dbs = new DataQLCHDTDataContext(conn);
        }
        public List<GetTaiKhoan>  LayUser()
        {
            return dbs.GetTaiKhoans.ToList();
        }
        public bool UpdateTaiKhoan(string id ,string pw, bool a , bool b, bool c, bool d, bool e)
        {
            dbs.updateTaiKhoan(id, pw, a, b, c, d, e);
            return true;
        }
        public void UpdatePassWord(string id, string PW)
        {
            dbs.UpdatePassWord(id, PW);
        }
        public LayThongTinTaiKhoanResult LayThongTinTaiKhoan(string id)
        {
            ISingleResult<LayThongTinTaiKhoanResult> query =  dbs.LayThongTinTaiKhoan(id);
            LayThongTinTaiKhoanResult x = new LayThongTinTaiKhoanResult();
            foreach (LayThongTinTaiKhoanResult item in query)
            {
                x.NguoiID = item.NguoiID;
                x.hoTen = item.hoTen;
                x.gioiTinh = item.gioiTinh;
                x.chucVu = item.chucVu;
                x.ngaySinh = item.ngaySinh;
                x.email = item.email;
                x.cmnd = item.cmnd;
                x.diaChi = item.diaChi;
            }
            return x;
        }
        public void UpdateThongTinTaiKhoan(string id, string hoten, string gioitinh, string email, string diachi, DateTime ngaysinh, string cmnd)
        {
            dbs.CapNhapThongTinTaiKhoan(id, hoten, gioitinh, ngaysinh, email, diachi, Int32.Parse(cmnd));
        }
        

    }
}
