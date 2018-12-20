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

namespace GUI
{
    public partial class frmDonHang : Form
    {
        //private BindingList<DonHangBAL> _Grid_data;
        BanHangBAL BanHangBAL;
        private List<DonHangBAL> DanhSachDonHang;
        DataTable dt = new DataTable();
        List<string> lMaHang = new List<string>();
        private string tenForm;
        public List<DonHangBAL> DanhSachDonHang1 { get => DanhSachDonHang; set => DanhSachDonHang = value; }
        public string TenForm { get => tenForm; set => tenForm = value; }

        public frmDonHang(string conn,string tenForm)
        {
            BanHangBAL = new BanHangBAL(conn);
            DanhSachDonHang1 = new List<DonHangBAL>();
            TenForm = tenForm;
            InitializeComponent();
            
        }
       /* public frmDonHang(string _tenForm,string conn):this()
        {
            this.TenForm = _tenForm;
            BanHangBAL = new BanHangBAL(conn);
        }*/

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
                btnAddNew.Enabled = false;
            else
                btnAddNew.Enabled = true;
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            if (TenForm == "NhapHang")
            {
                cbTenHang.Enabled = true;
                //cbTenHang.DropDownStyle = ComboBoxStyle.DropDown;
                //txtGiaNhap.Enabled = true;
                txtSoLuong.Enabled = true;

            }
            if(TenForm == "BanHang")
            {
                this.Size = new Size(544, 498);
            }
            
            cbTenHang.Items.Clear();
            var query = BanHangBAL.LayThongTinMatHang();
            foreach (var item in query)
            {
                cbTenHang.Items.Add(item.tenHang);
                lMaHang.Add(item.maHang);
                
            }
            
            /* _Grid_data = new BindingList<DonHangBAL>();
                gridDonHang.DataSource = _Grid_data;
                gridView1.PopulateColumns();*/
            dt.Columns.Clear();
            dt.Columns.Add("tenSP");
            dt.Columns.Add("donGia");
            dt.Columns.Add("soLuong");
            dt.Columns.Add("thanhTien");
            dt.Columns.Add("trangThai", typeof(bool));
           
        }

        private void cbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var query = BanHangBAL.LayThongTinMatHang();
            string ten = cbTenHang.Text;
            foreach (var item in query)
            {
                if (item.tenHang == ten)
                {
                    txtGiaNhap.Text = ChuyenVeChuoiTien(item.giaNhap.ToString());
                }
            }
            if (cbTenHang.Text != null)
                txtSoLuong.Enabled = true;
            else
                txtSoLuong.Enabled = false;
            
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

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int i = gridView1.FocusedRowHandle;
            gridView1.DeleteRow(i);
            DanhSachDonHang1.Remove(DanhSachDonHang1[i]);

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
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnDone.Enabled = true;


            string thanhTien =  ChuyenVeChuoiTien((Int32.Parse(ChuyenVeChuoiThuong(txtGiaNhap.Text)) * Int32.Parse(txtSoLuong.Text)).ToString());
            dt.Rows.Add(cbTenHang.Text, txtGiaNhap.Text, txtSoLuong.Text,thanhTien,true);
            gridDonHang.DataSource = dt;
            /* for (int i = 0; i < dt.Rows.Count; i++)
             {
                 if (dt.Rows[i]["tenSP"].ToString() == txtGiaNhap.Text)
                     dt.Rows[i].Delete();
             }*/

            /*U _Grid_data.Add(new DonHangBAL()
             {
                 TenHang = cbTenHang.Text,
                 DonGia = txtGiaNhap.Text,
                 SoLuong = Int32.Parse(txtSoLuong.Text),
                 ThanhTien = ChuyenVeChuoiTien((Int32.Parse(ChuyenVeChuoiThuong(txtGiaNhap.Text)) * Int32.Parse(txtSoLuong.Text)).ToString())
             });*/
            string maHang="";
            for (int i = 0; i < cbTenHang.Items.Count; i++)
            {
                if (cbTenHang.Text == cbTenHang.Items[i].ToString())
                    maHang = lMaHang[i];
            }
            
            DonHangBAL x = new DonHangBAL( cbTenHang.Text+"_"+maHang , txtGiaNhap.Text, Int32.Parse(txtSoLuong.Text), ChuyenVeChuoiTien((Int32.Parse(ChuyenVeChuoiThuong(txtGiaNhap.Text)) * Int32.Parse(txtSoLuong.Text)).ToString()));
            DanhSachDonHang1.Add(x);
         
            cbTenHang.ResetText();
            txtSoLuong.ResetText();
            txtGiaNhap.ResetText();
            btnAddNew.Enabled = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void gridDonHang_Click(object sender, EventArgs e)
        {

        }
        int co = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (co == 0)
            {
                txtGiaBan1.Enabled = true;
                txtGiaNhap1.Enabled = true;
                txtTenHang1.Enabled = true;
                co = 1;
                txtMaHang1.Enabled = true;
                txtMaHang1.ResetText();
               
                btnAdd.Enabled = false;
                
            }
            else
            {
                try
                {
                    BanHangBAL.ThemMatHang(txtMaHang1.Text, txtTenHang1.Text, txtGiaNhap1.Text, txtGiaBan1.Text);
                    MessageBox.Show("Thêm Mặt Hàng Thành Công", "Thông Báo");
                    txtGiaBan1.Enabled = false;
                    txtGiaNhap1.Enabled = false;
                    txtTenHang1.Enabled = false;
                    cbTenHang.Items.Clear();
                    lMaHang.Clear();
                    var query = BanHangBAL.LayThongTinMatHang();
                    foreach (var item in query)
                    {
                        cbTenHang.Items.Add(item.tenHang);
                        lMaHang.Add(item.maHang);
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm Mặt Hàng Không Thành Công", "Thông Báo");
                }
            }
        }

        private void txtGiaBan1_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaNhap1.Text != "" && txtGiaBan1.Text != "")
                btnAdd.Enabled = true;
        }

        
        private void txtGiaNhap1_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaNhap1.Text != "" && txtGiaBan1.Text != "")
                btnAdd.Enabled = true;
        }
        private void txtGiaNhap1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiaBan1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
