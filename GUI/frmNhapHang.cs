using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using DAL;
using BAL;
namespace GUI
{
    public partial class frmNhapHang : Form
    {
        string Conn;
        private GetTaiKhoan _taiKhoan;
        NhapHangBAL NhapHangBAL;
        string maNCC;
        string tenNCC;
        frmDonHang frm;
        List<DonHangBAL> lDanhSachDonhang = new List<DonHangBAL>();
        public GetTaiKhoan TaiKhoan { get => _taiKhoan; set => _taiKhoan = value; }

        
        public frmNhapHang(GetTaiKhoan taikhoan,string conn) 
        {
            Conn = conn;
            NhapHangBAL = new NhapHangBAL(Conn);
            this.TaiKhoan = taikhoan;
            frm = new frmDonHang(Conn,"NhapHang");
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmThongTinNhaCungCap frm = new frmThongTinNhaCungCap(Conn);
            frm.ShowDialog();
            maNCC = frm.MaNCC;
            tenNCC = frm.TenNCC;
            if (maNCC != null)
            {
                txtNhaCC.ResetText();
                txtNhaCC.Text = maNCC;
                btnLoadThongTinKhachHang_Click(sender, e);
                txtNhaCC.ResetText();
            }
        }

        private void btnLoadThongTinKhachHang_Click(object sender, EventArgs e)
        {
            ISingleResult<TimNhaCungCapResult> x = NhapHangBAL.LayThongTinNhaCungCap(txtNhaCC.Text);
            gridNhapHang.DataSource = x;
            if (gridView1.RowCount > 0)
            {
                btnDone.Enabled = true;

            }

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
              txtMaHD.ResetText();
            txtNhanVien.ResetText();
            txtKhachHang.ResetText();
            int n = NhapHangBAL.SoLuongHoaDon() + 1;
            if (n < 99)
                txtMaHD.Text = "HDN0" + n.ToString();
            else
                txtMaHD.Text = "HDN" + n.ToString();
            txtMaHD.Text = "HDN0" + n.ToString();
            dNgayLap.Text = DateTime.Now.ToString("MM/dd/yyyy");
            txtNhanVien.Text = TaiKhoan.hoTen;

            btnThietLapDonHang.Enabled = true;

          
            maNCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colmaNhaCC).ToString();
            tenNCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, coltenNhaCC).ToString();
            txtKhachHang.Text = tenNCC;
        }

        private void btnThietLapDonHang_Click(object sender, EventArgs e)
        {
            if (btnThietLapDonHang.Text == "Thiết Lập Đơn Hàng")
            {

                frm.ShowDialog();
                btnThietLapDonHang.Text = "Xem Lại Đơn Hàng";
                btnDone1.Enabled = true;
            }
            else
            {
                frm.Show();
            }
        }

        private void btnDone1_Click(object sender, EventArgs e)
        {
            uint tongtien = 0;
            lDanhSachDonhang = frm.DanhSachDonHang1;
            for (int i = 0; i < lDanhSachDonhang.Count; i++)
            {
                tongtien += UInt32.Parse(ChuyenVeChuoiThuong(lDanhSachDonhang[i].ThanhTien));

            }
            txtTongTien.ResetText();
            txtTongTien.Text = ChuyenVeChuoiTien(tongtien.ToString());
            gcThanhToan.Enabled = true;
        }
        public string ChuyenVeChuoiTien(string x)
        {
            int n = x.Length;
            if (n % 3 == 0 && n > 3)
            {
                for (int i = n / 3 - 1; i > 0; i--)
                {
                    x = x.Insert(i * 3, " ");
                }
            }
            else
            {
                if (n % 3 == 1 && n > 3)
                {
                    for (int i = n / 3; i > 0; i--)
                    {
                        x = x.Insert(i * 3 - (n / 3), " ");
                    }
                }
                else
                {
                    if (n > 3)
                    {
                        for (int i = n / 3; i > 0; i--)
                        {
                            x = x.Insert(i * 3 - 1, " ");
                        }
                    }
                }
            }
            return x;
        }
        public string ChuyenVeChuoiThuong(string x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == ' ')
                    x = x.Remove(i, 1);
            }
            return x;
        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string x = ChuyenVeChuoiTien(txtTienNhan.Text);
            txtTienNhan.ResetText();
            txtTienNhan.Text = x;
            if (Int32.Parse(ChuyenVeChuoiThuong(txtTienNhan.Text)) < Int32.Parse(ChuyenVeChuoiThuong(txtTongTien.Text)))
                MessageBox.Show("Chưa Nhận Đủ Tiền");
            else
            {
                txtTienThua.Text = ChuyenVeChuoiTien((Int32.Parse(ChuyenVeChuoiThuong(txtTienNhan.Text)) - Int32.Parse(ChuyenVeChuoiThuong(txtTongTien.Text))).ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone2_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Xác Nhận Giao Dịch ?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                string maHD = txtMaHD.Text;

               // idKhachhang

                string idNV = TaiKhoan.ID;
                DateTime ngayLap = DateTime.Parse(dNgayLap.Text);
                try
                {
                    for (int i = 0; i < lDanhSachDonhang.Count; i++)
                    {
                        string maHang = "";
                        int n = lDanhSachDonhang[i].TenHang.IndexOf('_', 0);
                        maHang = lDanhSachDonhang[i].TenHang.Substring(n + 1);
                        int soLuong = lDanhSachDonhang[i].SoLuong;

                        NhapHangBAL.ThucHienGiaoDich(maHD, maHang, maNCC, soLuong, idNV, ngayLap);
                    }
                    MessageBox.Show("Lập Hóa Đơn Giao Dịch Thành Công", "Thông Báo");
                    LoadForm(sender, e);
                }
               catch
                {
                    MessageBox.Show("Lập Hóa Đơn Giao Dịch Không Thành Công", "Thông Báo");
                }
            }
        }
        void LoadForm(object sender, EventArgs e)
        {
            gcThanhToan.Enabled = false;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
            btnDone2.Enabled = false;
            btnDone1.Enabled = false;
            txtKhachHang.ResetText();
            txtTongTien.ResetText();
            txtTienNhan.ResetText();
            txtTienThua.ResetText();
            txtMaHD.ResetText();
            txtNhanVien.ResetText();
            txtKhachHang.ResetText();
            dNgayLap.ResetText();
            btnThietLapDonHang.Enabled = false;
            btnThietLapDonHang.Text = "Thiết Lập Đơn Hàng";
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void txtTienThua_TextChanged(object sender, EventArgs e)
        {
            btnDone2.Enabled = true;
        }
    }
}
