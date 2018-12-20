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
    public partial class frmHangTrongKho : Form
    {
        HoaDonBAL HoaDonBAL;
        public frmHangTrongKho(string conn)
        {
            HoaDonBAL = new HoaDonBAL(conn);
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnLoad_Click(object sender, EventArgs e)
        {
            gridHangTrongKho.DataSource= HoaDonBAL.LayThongTinHangTrongKho().ToList();
        }

        private void frmHangTrongKho_Load(object sender, EventArgs e)
        {

        }
    }
}
