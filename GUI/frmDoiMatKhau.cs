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
    public partial class frmDoiMatKhau : Form
    {
        PhanQuyenBAL PhanQuyenBAL;
        private string PW;
        private string ID;
        public frmDoiMatKhau(string ID, string PassWord, string conn)
        {
            PW1 = PassWord;
            ID1 = ID;
            PhanQuyenBAL =  new PhanQuyenBAL(conn);
            InitializeComponent();
        }

        public string PW1 { get => PW; set => PW = value; }
        public string ID1 { get => ID; set => ID = value; }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtPassCu.Text == PW1)
            {
                if (txtPassMoi.Text == txtPassNhapLai.Text)
                {
                    PhanQuyenBAL.UpdatePassWord(ID1, txtPassMoi.Text);
                    PW1 = txtPassMoi.Text;
                    this.Close();
                }
                else
                    MessageBox.Show("Mật Khẩu Mới Không Trùng");
            }
            else MessageBox.Show("Sai Mật Khẩu Cũ");
            
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
