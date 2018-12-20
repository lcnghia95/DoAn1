using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class DonHangBAL
    {
        private string tenHang;
        private string donGia;
        private int soLuong;
        private string thanhTien;


        public string TenHang { get => tenHang; set => tenHang = value; }
        public string DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string ThanhTien { get => thanhTien; set => thanhTien = value; }

        public DonHangBAL()
        {

        }
        
         public DonHangBAL( string tenHang, string donGia, int soLuong, string thanhTien)
        {

            this.TenHang = tenHang;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;

        }
    }
}
