using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class HoaDonBAL
    {
        DataQLCHDTDataContext dbs;

        public DataQLCHDTDataContext Dbs { get => dbs; set => dbs = value; }

        public HoaDonBAL(string conn)
        {
            Dbs = new DataQLCHDTDataContext(conn);
        }
        public List<HoaDonXuat> LayHoaDonXuat()
        {
            return Dbs.HoaDonXuats.ToList();
        }
        public List<HoaDonNhap> LayHoaDonNhap()
        {
            return Dbs.HoaDonNhaps.ToList();
        }
        public List<HangTrongKho> LayThongTinHangTrongKho()
        {
            return Dbs.HangTrongKhos.ToList();
        }
    }
}
