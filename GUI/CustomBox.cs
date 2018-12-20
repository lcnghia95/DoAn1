using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CustomBox : Form
    {
        private string tenForm;
        private bool result;
        public CustomBox()
        {
            InitializeComponent();
        }
        public CustomBox(string tenForm)
        {
            this.TenForm = tenForm;
            InitializeComponent();

        }
        public bool Result { get => result; set => result = value; }
        public string TenForm { get => tenForm; set => tenForm = value; }

        private void btnDangLam_Click(object sender, EventArgs e)
        {
            Result = true;
            this.Close();
        }

        private void btnDaNghi_Click(object sender, EventArgs e)
        {
            Result = false;
            this.Close();
        }

        private void CustomBox_Load(object sender, EventArgs e)
        {
            if (TenForm =="BaoHanh")
            {
                btnDaNghi.Text =  "Đã Trả";
                btnDangLam.Text = "Sửa Xong";
                label1.Text = "Chọn Trạng Thái Bảo Hành";
                
            }
        }
    }
}
