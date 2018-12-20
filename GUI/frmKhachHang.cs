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
    public partial class frmKhachHang : Form
    {
        KhachHangBAL KhachHangBAL;
        int co = 0;
        public frmKhachHang(string conn)
        {
            KhachHangBAL = new KhachHangBAL(conn);
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            gridKhachHang.DataSource = KhachHangBAL.LayKhachHang();
            btnAddNew.Enabled = true;
           
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {          
            txtID.ResetText();
            txtHoTen.ResetText();
            txtEmail.ResetText();
            dNgaySinh.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            txtID.Enabled = true;
            txtHoTen.Enabled = true;
            cbNam.Enabled = true;
            cbNu.Enabled = true;
            txtEmail.Enabled = true;
            dNgaySinh.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            txtID.Enabled = false;
            txtHoTen.Enabled = true;
            cbNam.Enabled = true;
            cbNu.Enabled = true;
            txtEmail.Enabled = true;
            dNgaySinh.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            co = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (co == 0)
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
                    //NhanVienBAL.ThemNhanVien("N023", "Nghĩa", "Name",DateTime.Parse("03/09/1995"), "hactukjet", "123456789", "diachi", "Bán Hàng");
                    KhachHangBAL.ThemKhachHang(id, hoten, gioitinh, DateTime.Parse(ngaysinh), email, cmnd, diachi);
                    btnSave.Enabled = false;
                    LoadData();
                    MessageBox.Show("Thêm Khách Hàng Thành Công");

                }
                catch
                {
                    MessageBox.Show("Thêm Khách Hàng Không Thành Công");
                }
            }
            else
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
                    KhachHangBAL.UpdateKhachHang(id, hoten, gioitinh, DateTime.Parse(ngaysinh), email, cmnd, diachi);
                    btnSave.Enabled = false;
                    MessageBox.Show("Cập Nhập Thành Công");
                    LoadData();
                    co = 0;
                }
                catch
                {
                    MessageBox.Show("Cập Nhập Không Thành Công");
                }

            }
        }
        public void  LoadData()
        {

            btnAddNew.Enabled = true;
            txtID.Enabled = false;
            txtHoTen.Enabled = false;

            cbNam.Enabled = false;
            cbNu.Enabled = false;
            txtEmail.Enabled = false;
            dNgaySinh.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            gridKhachHang.DataSource = KhachHangBAL.LayKhachHang();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtID.ResetText();
            txtHoTen.ResetText();

            txtEmail.ResetText();
            dNgaySinh.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            btnAddNew.Enabled = false;
            txtID.Enabled = false;
            txtHoTen.Enabled = false;
            
            cbNam.Enabled = false;
            cbNu.Enabled = false;
            txtEmail.Enabled = false;
            dNgaySinh.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            bool check = KhachHangBAL.CheckKhachHang(txtID.Text);
            if (check == true && btnSave.Enabled == true)
                MessageBox.Show("Mã Khách Hàng Đã Tồn Tại");
        }
        public string checknull(string x)
        {
            if (x != null)
                return x;
            return "NULL";
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnSave.Enabled = false;
            cbNam.Checked = false;
            cbNu.Checked = false;
            txtID.ResetText();
            txtHoTen.ResetText();
          
            txtEmail.ResetText();
            dNgaySinh.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            txtID.Text = gridView1.GetFocusedRowCellValue(colNguoiID).ToString();
            txtHoTen.Text = gridView1.GetFocusedRowCellValue(colhoTen).ToString();
            txtDiaChi.Text = gridView1.GetFocusedRowCellValue(coldiaChi).ToString();
            

            txtEmail.Text = gridView1.GetFocusedRowCellValue(colemail).ToString();
            if (gridView1.GetFocusedRowCellValue(colgioiTinh).ToString() == "Nam")
            { cbNam.Checked = true; cbNu.Checked = false; }
            if (gridView1.GetFocusedRowCellValue(colgioiTinh).ToString() == "Nữ")
            { cbNu.Checked = true; cbNam.Checked = false; }
            btnEdit.Enabled = true;

            txtCMND.Text = gridView1.GetFocusedRowCellValue(colcmnd).ToString();

            dNgaySinh.Text = ((DateTime)gridView1.GetFocusedRowCellValue(colngaySinh)).ToString("MM/dd/yyyy");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
            btnAddNew.Enabled = true;
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

        
    }
}
