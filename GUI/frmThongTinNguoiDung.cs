using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;

namespace GUI
{
    public partial class frmThongTinNguoiDung : Form
    {
        private LayThongTinTaiKhoanResult taikhoan;
        PhanQuyenBAL PhanQuyenBAL;
        public frmThongTinNguoiDung(string conn)
        {
            PhanQuyenBAL = new PhanQuyenBAL(conn);
            InitializeComponent();
        }

        public LayThongTinTaiKhoanResult Taikhoan { get => taikhoan; set => taikhoan = value; }
        public frmThongTinNguoiDung(LayThongTinTaiKhoanResult _taikhoan,string conn)
        {
            PhanQuyenBAL = new PhanQuyenBAL(conn);
            this.Taikhoan = _taikhoan;
            InitializeComponent();
        }

        private void frmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            txtID.Text = taikhoan.NguoiID;
            txtHoTen.Text = taikhoan.hoTen;
            txtEmail.Text = taikhoan.email;
            txtCMND.Text = taikhoan.cmnd.ToString();
            txtChucVu.Text = taikhoan.chucVu;
            txtDiaChi.Text = taikhoan.diaChi;
            if (taikhoan.gioiTinh == "Nam")
                cbNam.Checked = true;
            else
                cbNu.Checked = true;
            dNgaySinh.Text = ((DateTime)taikhoan.ngaySinh).ToString("dd/MM/yy");

            txtID.Enabled = false;
            txtHoTen.Enabled = false;
            txtEmail.Enabled = false;
            txtCMND.Enabled = false;
            txtChucVu.Enabled = false;
            txtDiaChi.Enabled = false;
            cbNam.Enabled = false;
            cbNu.Enabled = false;
            dNgaySinh.Enabled = false;
            btnLuu.Enabled = false;

        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNam.Checked == true)
                cbNu.Checked = false;
            else
                cbNu.Checked = true;
        }

        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNu.Checked == true)
                cbNam.Checked = false;
            else
                cbNam.Checked = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtHoTen.Enabled = true;
            txtEmail.Enabled = true;
            txtCMND.Enabled = true;
            txtChucVu.Enabled = false;
            txtDiaChi.Enabled = true;
            cbNam.Enabled = true;
            cbNu.Enabled = true;
            dNgaySinh.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string x;
            if (cbNam.Checked == true)
                x = "Nam";
            else x = "Nữ";
            PhanQuyenBAL.UpdateThongTinTaiKhoan(txtID.Text, txtHoTen.Text, x, txtEmail.Text,txtDiaChi.Text, dNgaySinh.DateTime, txtCMND.Text);

            taikhoan.hoTen = txtHoTen.Text;
            taikhoan.email = txtEmail.Text;
            taikhoan.cmnd=Int32.Parse(txtCMND.Text);
            taikhoan.diaChi = txtDiaChi.Text;
            if (cbNam.Checked == true)
                taikhoan.gioiTinh = "Nam";
            else
                taikhoan.gioiTinh = "Nữ";
            taikhoan.ngaySinh = dNgaySinh.DateTime;
            frmThongTinNguoiDung_Load(sender, e);
        }

        private void dNgaySinh_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
