using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DAL;

namespace BAL
{
    public class ChatLanBAL
    {
        private string conn;
        DataQLCHDTDataContext dbs;
    

        public string Conn { get => conn; set => conn = value; }
        public ChatLanBAL(string conn)
        {
            Conn = conn;
            dbs = new DataQLCHDTDataContext(conn);
        }
        public  List<NhanVienOnline> DanhSachNhanVienOnline()
        {
            
            return dbs.NhanVienOnlines.ToList();
            
        }
        public void UpdateOnline(string tinhtrang, string manv,string ip )
        {
            dbs.UpdateOnline(tinhtrang, manv, ip);
            
        }
    }
}
