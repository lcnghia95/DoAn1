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
using DevExpress.XtraGrid;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        NhanVienBAL NhanVienBAL;
        int co = 0;
        int co1 = 0;


        public frmNhanVien(string conn)
        {
            NhanVienBAL = new NhanVienBAL(conn);
            InitializeComponent();


            
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtID.ResetText();
            txtHoTen.ResetText();
            cbChucVu.ResetText();
            txtEmail.ResetText();
            dNgaySinh.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            btnAddNew.Enabled = false;
            txtID.Enabled = false;
            txtHoTen.Enabled = false;
            cbChucVu.Enabled = false;
            cbNam.Enabled = false;
            cbNu.Enabled = false;
            txtEmail.Enabled = false;
            dNgaySinh.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            
        }
        public void LoadData()
        {
            btnAddNew.Enabled = true;
            txtID.Enabled = false;
            txtHoTen.Enabled = false;
            cbChucVu.Enabled = false;
            cbNam.Enabled = false;
            cbNu.Enabled = false;
            txtEmail.Enabled = false;
            dNgaySinh.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            gridNhanVien.DataSource = NhanVienBAL.LayNhanVien();

        }
        public void LoadData1()
        {
            //gridView1.Columns.Remove(gridColumn1);
            
            gridNhanVien.DataSource = NhanVienBAL.LayNhanVien1();
            btnAddNew.Enabled = false;

            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            CustomBox frm = new CustomBox();
            frm.ShowDialog();
            bool result = frm.Result;
            if(result ==true)
            {
                gridView1.RefreshData();
                LoadData();
                co1 = 0;
            }
            else
            {
                LoadData1();
                co1 = 1;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            txtID.ResetText();
            txtHoTen.ResetText();
            cbChucVu.ResetText();
            txtEmail.ResetText();
            dNgaySinh.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            txtID.Enabled = true;
            txtHoTen.Enabled = true;
            cbChucVu.Enabled = true;
            cbNam.Enabled = true;
            cbNu.Enabled = true;
            txtEmail.Enabled = true;
            dNgaySinh.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        /*private void btnSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
            string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNguoiID).ToString();
            string hoten = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colhoTen).ToString();
            string chucvu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colchucVu).ToString();
            string gioitinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colgioiTinh).ToString();
            string ngaysinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colngaySinh).ToString();
            string email = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colemail).ToString();
            string cmnd = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colcmnd).ToString();
            string diachi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, coldiaChi).ToString();
            try
            {
                NhanVienBAL.UpdateNhanVien(id, hoten, gioitinh, DateTime.Parse(ngaysinh), email, cmnd, diachi, chucvu);
                //NhanVienBAL.ThemNhanVien(id, hoten, gioitinh, DateTime.Parse(ngaysinh), email, cmnd, diachi, chucvu);
                MessageBox.Show("Cập Nhập Thành Công");
            }
            catch
            {
                MessageBox.Show("Cập Nhập Không Thành Công");
            }
        }*/

        private void gridNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //btnCancel_Click(sender, e);
            /*txtID.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            cbChucVu.DataBindings.Clear();
            cbNam.DataBindings.Clear();
            cbNu.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            dNgaySinh.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();*/
            btnSave.Enabled = false;
            cbNam.Checked = false;
            cbNu.Checked = false;
            txtID.ResetText();
            txtHoTen.ResetText();
            cbChucVu.ResetText();
            txtEmail.ResetText();
            dNgaySinh.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            txtID.Text = gridView1.GetFocusedRowCellValue(colNguoiID).ToString();
            txtHoTen.Text= gridView1.GetFocusedRowCellValue(colhoTen).ToString();
            txtDiaChi.Text= gridView1.GetFocusedRowCellValue(coldiaChi).ToString(); 
            cbChucVu.Text= gridView1.GetFocusedRowCellValue(colchucVu).ToString();
             
            txtEmail.Text= gridView1.GetFocusedRowCellValue(colemail).ToString();           
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            btnSave.Enabled = true;
            txtID.Enabled = false;
            txtHoTen.Enabled = true;
            cbChucVu.Enabled = true;
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
            if(co==0)
            {
                
                string id = txtID.Text;
                string hoten = txtHoTen.Text;
                string chucvu = cbChucVu.Text;
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
                    NhanVienBAL.ThemNhanVien(id, hoten, gioitinh, DateTime.Parse(ngaysinh), email, cmnd, diachi, chucvu);
                    btnSave.Enabled = false;
                    if (co1 == 0) LoadData(); else LoadData1();
                    MessageBox.Show("Thêm Nhân Viên Thành Công");
                    
                }
                catch
                {
                   MessageBox.Show("Thêm Nhân Viên Không Thành Công");
                }
            }
            else
            {
                string id = txtID.Text;
                string hoten = txtHoTen.Text;
                string chucvu = cbChucVu.Text;
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
                    NhanVienBAL.UpdateNhanVien(id, hoten, gioitinh, DateTime.Parse(ngaysinh), email, cmnd, diachi, chucvu);
                    btnSave.Enabled = false;
                    MessageBox.Show("Cập Nhập Thành Công");
                    if (co1 == 0) LoadData(); else LoadData1();
                    co=0;
                }
                catch
                {
                    MessageBox.Show("Cập Nhập Không Thành Công");
                }
             
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
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

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (co1 == 0)
            {
                string name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colhoTen).ToString();
                string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNguoiID).ToString();
                DialogResult tl = MessageBox.Show("Xóa Nhân Viên : " + name + " có mã ID : " + id + " ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {

                    NhanVienBAL.XoaNhanVien(id);
                    LoadData();
                }
            }
            else
            {
                string name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colhoTen).ToString();
                string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNguoiID).ToString();
                DialogResult tl = MessageBox.Show("Khôi Phục Nhân Viên : " + name + " có mã ID : " + id + " ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(tl==DialogResult.Yes)
                {
                    NhanVienBAL.KhoiPhucNhanVien(id);
                    LoadData1();
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            bool check = NhanVienBAL.CheckNhanVien(txtID.Text);
            if (check == true && btnSave.Enabled==true)   
                MessageBox.Show("Mã Nhân Viên Đã Tồn Tại");
        }
        public string checknull(string x)
        {
            if (x != null)
                return x;
            return "NULL";
        }
    }
}
