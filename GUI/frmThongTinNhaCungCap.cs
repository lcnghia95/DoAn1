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
    public partial class frmThongTinNhaCungCap : Form
    {
        NhapHangBAL NhapHangBAL;
        private string maNCC;
        private string tenNCC;
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public frmThongTinNhaCungCap(string conn)
        {
            NhapHangBAL  = new NhapHangBAL(conn);
            InitializeComponent();
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text;
            string ten = txtTenNCC.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            try
            {
                NhapHangBAL.ThemNhaCungCap(ma,ten, diachi, sdt);
                TenNCC = ten;
                MaNCC = ma;
                MessageBox.Show("Thêm Nhà Cung Cấp Thành Công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Thêm Nhà Cung Cấp Không Thành Công");
            }
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {
            bool check = NhapHangBAL.CheckMaNCC(txtMaNCC.Text);
            if (check == true && btnLuu.Enabled == true)
                MessageBox.Show("Mã ID Đã Tồn Tại");
        }

        private void frmThongTinNhaCungCap_Load(object sender, EventArgs e)
        {
            var query = NhapHangBAL.LayDanhSachNhaCungCap();
            int n = query.Count + 1;
            if (n < 99)
                txtMaNCC.Text = "CC0" + n.ToString();
            else
                txtMaNCC.Text = "CC" + n.ToString();
        }
    }
}
