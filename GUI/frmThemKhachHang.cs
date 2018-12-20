using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DAL;

namespace GUI
{
    public partial class frmThemKhachHang : Form
    {
        KhachHangBAL KhachHangBAL;
        private string _id;
        private string _hoten;
  
        public frmThemKhachHang(string conn)
        {
            KhachHangBAL = new KhachHangBAL(conn);
            InitializeComponent();
        }
       
        
        public string Id { get => _id; set => _id = value; }
        public string Hoten { get => _hoten; set => _hoten = value; }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string hoten = txtHoTen.Text;

            string gioitinh = null;
            if (cbNam.Checked == true)
                gioitinh = "Nam";
            if (cbNu.Checked == true)
                gioitinh = "Nữ";
            string email = txtEmail.Text;
            string cmnd = txtCMND.Text;
            string diachi = txtDiaChi.Text;
            string ngaysinh = dNgaySinh.Text;

            
            try
            {
                KhachHangBAL.ThemKhachHang(id, hoten, gioitinh, DateTime.Parse(ngaysinh), email, cmnd, diachi);
                btnLuu.Enabled = true;
                Id = id;
                Hoten = hoten;
                MessageBox.Show("Thêm Khách Hàng Thành Công");
                this.Close();
                

            }
            catch
            {
                MessageBox.Show("Thêm Khách Hàng Không Thành Công");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            bool check = KhachHangBAL.CheckKhachHang(txtID.Text);
            if (check == true && btnLuu.Enabled == true)
                MessageBox.Show("Mã ID Đã Tồn Tại");
        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNam.Checked == true)
                cbNu.Checked = false;
        }

        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNu.Checked == true)
                cbNam.Checked = false;
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            txtID.ResetText();
            var query = KhachHangBAL.LayMaMoi();
            int n = query.Count + 1;
            if (n < 99)
                txtID.Text = "H0" + n.ToString();
            else
                txtID.Text = "H" + n.ToString();

        }
    }
}
