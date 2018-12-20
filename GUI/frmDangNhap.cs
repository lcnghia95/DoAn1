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

namespace GUI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        PhanQuyenBAL phanQuyenBAL;
        private GetTaiKhoan taikhoan;

        public GetTaiKhoan Taikhoan { get => taikhoan; set => taikhoan = value; }

        public frmDangNhap(string conn)
        {
            phanQuyenBAL = new PhanQuyenBAL(conn);
            InitializeComponent();
        }
       

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panHeader_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<GetTaiKhoan> x = phanQuyenBAL.LayUser();
            int co = -1; ;
            for (int i = 0; i < x.Count; i++)
            {

                if (txtuser.Text == x[i].ID)
                {
                    co = i;
                    break;
                }
            }
            if (co == -1)
            {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu");
            }
            else
            {
                if (txtPass.Text == x[co].PassWord)
                {
                    Taikhoan = x[co];
                    if(taikhoan.trangThai==false)
                    {
                        MessageBox.Show("Tài Khoản Đã Bị Vô Hiệu Hóa");
                    }
                    else
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu");
                }
            }
        }

       
    }
}