using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BAL;
using DAL;
using System.Configuration;

namespace GUI
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string Conn;
        GetTaiKhoan taikhoan = new GetTaiKhoan();
        PhanQuyenBAL PhanQuyenBAL;
        
        
        public Form1()     
        {
            InitializeComponent();
            Loadform();
        }
        public Form1(string conn)
        {
            Conn = conn;
            PhanQuyenBAL = new PhanQuyenBAL(Conn);
            InitializeComponent();
            Loadform();
        }
        /* void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
         {
             navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
         }
         void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
             navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
         }*/
        public void Loadform()
        {
            

            btnDangXuat.Enabled = false;
            btnThongTin.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            btnPhanQuyen.Enabled = false;
            btnDanhSachNhanVien.Enabled = false;
            btnDanhSachKhachHang.Enabled = false;
            btnNhapHang.Enabled = false;
            btnKiemKho.Enabled = false;
            btnBanHang.Enabled = false;
            btnHoaDonNhap.Enabled = false;
            btnHoaDonXuat.Enabled = false;
            btnChatLan.Enabled = false;
            

        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            
            frmDangNhap frm = new frmDangNhap(Conn);
            frm.ShowDialog();
            taikhoan = frm.Taikhoan;
            if (taikhoan != null)
            {
                QuyenSuDung();
            }
            
           
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Loadform();
            taikhoan = null;
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            btnDangNhap.Enabled = true;
        }

        private void btnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinNguoiDung frm = new frmThongTinNguoiDung(PhanQuyenBAL.LayThongTinTaiKhoan(taikhoan.ID),Conn);  
            frm.ShowDialog();
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau(taikhoan.ID,taikhoan.PassWord,Conn);
            frm.ShowDialog();
            taikhoan.PassWord = frm.PW1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmPhanQuyen frm = new frmPhanQuyen();
            //frm.ShowDialog();
            Form frm = KiemTraTonTai(typeof(frmPhanQuyen));
            if(frm!=null)
            {
                frm.Activate();
            }
            else
            {
                frmPhanQuyen f = new frmPhanQuyen(Conn);
                f.MdiParent = this;
                f.Show();
                if(taikhoan!=f.TaiKhoan && f.TaiKhoan!=null)
                    taikhoan = f.TaiKhoan;
            }
        }
        public void QuyenSuDung()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnThongTin.Enabled = true;
            btnChatLan.Enabled = true;
            if (taikhoan.PQuyen == true)
                btnPhanQuyen.Enabled = true;
            if(taikhoan.QLNS==true)
            {
                btnDanhSachNhanVien.Enabled = true;
                btnTinhLuong.Enabled = true;
                btnDanhSachKhachHang.Enabled = true;
                btnTienvaDiemThuong.Enabled = true;
            }
            if(taikhoan.QLNK==true)
            {
                btnNhapHang.Enabled = true;
                btnKiemKho.Enabled = true;
                btnHoaDonNhap.Enabled = true;
                btnHoaDonXuat.Enabled = true;
            }
            if(taikhoan.QLBH==true)
            {
                btnBanHang.Enabled = true;
               
                btnTimSanPham.Enabled = true;
                btnDanhSachBaoHanh.Enabled = true;
            }
        }
        public Form KiemTraTonTai(Type ftype)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                    return f;
            }
            return null;
        }

        private void btnDanhSachNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmNhanVien));
            if(frm !=null)
            {
                frm.Activate();
            }
            else
            {
                frmNhanVien f = new frmNhanVien(Conn);
                f.MdiParent = this;
                f.Show();
              
            }
            
        }

        private void btnDanhSachKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmKhachHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKhachHang f = new frmKhachHang(Conn);
                f.MdiParent = this;
                f.Show();
                
            }
        }

        private void btnHoaDonXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmHoaDonXuat));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHoaDonXuat f = new frmHoaDonXuat(Conn);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHoaDonNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmHoaDonNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHoaDonNhap f = new frmHoaDonNhap(Conn);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmNhapHang));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNhapHang f = new frmNhapHang(taikhoan,Conn);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKiemKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmHangTrongKho));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHangTrongKho f = new frmHangTrongKho(Conn);
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void btnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmBanHang));
            if (frm != null)
                frm.Activate();
            else
            {
                frmBanHang f = new frmBanHang(taikhoan,Conn);
                f.MdiParent = this;
                f.Show();
            }
        }

       

     

      

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnChatLan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChatLan frm = new frmChatLan(Conn,taikhoan);
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

       
    }
}