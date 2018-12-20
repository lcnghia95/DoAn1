using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Timers;
using TableDependency;
using TableDependency.Enums;
using TableDependency.Mappers;
using TableDependency.SqlClient;
using BAL;
using DAL;

namespace GUI
{
    public partial class frmChatLan : Form
    {
        private string conn;
        private GetTaiKhoan taiKhoan;
        ChatLanBAL ChatLanBAL;
        SqlTableDependency<Online> table;
        public string Conn { get => conn; set => conn = value; }
        public GetTaiKhoan TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        

        public frmChatLan(string conn,GetTaiKhoan taikhoan)
        {
            Conn = conn;
            string strconn = "Data Source=DESKTOP-M5AI04O;Initial Catalog=QUANLYCUAHANGBANTHUCUNG;User ID=nghia;Password=123";
            Conn = strconn;
            ChatLanBAL = new ChatLanBAL(strconn);
            TaiKhoan = taikhoan;
            
            InitializeComponent();
            //timer1.Start();

        }
        void Watcher()
        {
        
            table = new SqlTableDependency<Online>(Conn, "Online");
            table.OnChanged += Table_OnChanged;
            //table.OnError += Table_OnError;
            table.Start();
        }

        

        private void Table_OnChanged(object sender, TableDependency.EventArgs.RecordChangedEventArgs<Online> e)
        {
            if(e.ChangeType!=ChangeType.None)
            {
                LoadData();
            }
        }

        private void frmChatLan_Load(object sender, EventArgs e)
        {
            ChatLanBAL.UpdateOnline("Online", TaiKhoan.ID, GetIP());
            LoadData();
            Watcher();
            
        }

    
        
        void LoadData()
        {
            List<NhanVienOnline> ds = ChatLanBAL.DanhSachNhanVienOnline();
            lvOnline.Items.Clear();
            if (ds.Count > 0)
            {
                foreach (NhanVienOnline item in ds)
                {
                    if (item.MaNV != TaiKhoan.ID)
                        lvOnline.Items.Add(item.TenNV + "_" + item.MaNV);
                }
            }
        }

        public string GetIP()
        {
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            string ip = "127.0.0.1";
            try
            {
                foreach (IPAddress address in localIP)
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                        ip = address.ToString();
                }
            }
            catch
            {

            }
            return ip;
        }

       /* private void timer1_Tick(object sender, EventArgs e)
        {
           
            DateTime dt = DateTime.Now;
            int flag = Int32.Parse(dt.ToString("ss"));
            List<NhanVienOnline> ds = ChatLanBAL.DanhSachNhanVienOnline();
            if (flag % 5 == 0)
            {
                lvOnline.Items.Clear();
                foreach (NhanVienOnline item in ds)
                {
                    if (item.MaNV != TaiKhoan.ID) 
                        lvOnline.Items.Add(item.TenNV+"_"+item.MaNV);
                }
            }

            

        }*/

        private void frmChatLan_FormClosed(object sender, FormClosedEventArgs e)
        {
            table.Stop();
            ChatLanBAL.UpdateOnline("Offline", TaiKhoan.ID, "NULL");
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            table.Stop();
            this.Close();
        }
        Boolean flag; int x, y;
        private void frmChatLan_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void frmChatLan_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void lvOnline_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvOnline_Click(object sender, EventArgs e)
        {

        }
       
        private void lvOnline_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lvOnline.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            if (item != null)
            {
                string Item = item.Text;
                string s1=null, s2=null;
                for (int i = 0; i < Item.Length; i++)
                {
                    if(Item[i]=='_')
                    {
                        s2 = Item.Substring(i + 1);
                        s1 = Item.Substring(0, i);
                        break;
                    }
                }
                
                foreach (NhanVienOnline q in ChatLanBAL.DanhSachNhanVienOnline())
                {
                    if(q.MaNV==s2)
                    {
                        frmKhungChat frm = new frmKhungChat(GetIP(), q.IP, TaiKhoan.hoTen, s1);
                        frm.Text = s1;
                        frm.Show();
                        break;
                    }
                }
               
            }
            else
            {
                this.lvOnline.SelectedItems.Clear();
                MessageBox.Show("No Item is selected");
            }
            


        }

        private void frmChatLan_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
    }
}
