using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;


namespace GUI
{
    public partial class frmDangNhapServer : Form
    {
        
        private string Conn;

        public string Conn1 { get => Conn; set => Conn = value; }
        
        public static bool flag = false;
        private List<string> lIPs = new List<string>();
        string subnet = "255.255.255.0";
        public frmDangNhapServer()
        {
            InitializeComponent();
         
            ///
            


        }

        

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
        private void frmDangNhapServer_Load(object sender, EventArgs e)
        {
            

        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            //string _conn = Conn1 + "Initial Catalog" + cbDatabase.Text;
            string sever = cbServer.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;

            this.Hide();
            string str = "Data Source=" + sever + ";Initial Catalog=" + cbDatabase.Text + ";User ID=" + user + ";Password=" + password;
            Conn1 = str;
            this.Hide();
            Form1 frm = new Form1(Conn1);
            frm.Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            cbDatabase.Items.Clear();
            cbDatabase.Text = "QUANLYCUAHANGBANTHUCUNG";
            string sever = cbServer.Text;
            SqlConnection conn = null;

            string user = txtUser.Text;
            string password = txtPassword.Text;
            try
            {
                string str = "Data Source=" + sever + ";User ID=" + user + ";Password=" + password;
                conn = new SqlConnection(str);
                conn.Open();
                DataTable databases = conn.GetSchema("Databases");
                if (databases != null)
                {
                    foreach (DataRow database in databases.Rows)
                    {
                        string databaseName = database.Field<string>("database_name");
                        short dbID = database.Field<short>("dbid");
                        cbDatabase.Items.Add(databaseName);
                    }
                }

                cbServer.Enabled = false;
                txtPassword.Enabled = false;
                txtUser.Enabled = false;
                btnKetNoi.Enabled = true;
                btExit.Enabled = true;
                cbDatabase.Enabled = true;
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lấy Danh Sách Database Không Thành Công");
            }
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetIPAddress_Click(object sender, EventArgs e)
        {
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    txtIPAddress.Text = address.ToString();
            }
        }

        
        public void GetServerName()
        {
            
            rtxtIP.Text += "Danh sách Server Name : \n";
            string myServer = Environment.MachineName;
            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            int co = 1;
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                if (myServer == servers.Rows[i]["ServerName"].ToString())
                {
                    cbServer.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                    rtxtIP.Text += "Server Name " + co.ToString() + " : " + servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"] + "\n";
                    co++;

                }
                else
                {
                    cbServer.Items.Add(servers.Rows[i]["ServerName"]);
                    rtxtIP.Text += "Server Name " + co.ToString() + " : " + servers.Rows[i]["ServerName"].ToString()+ "\n";
                    co++;
                }
            }
            rtxtIP.Text += "------------------------------------------------------------------------------------------------------------\n";
            rtxtIP.Text += "Danh Sach IP :\n";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cbServer.Items.Clear();
            rtxtIP.ResetText();
            lIPs = new List<string>();
            GetIPCanPing();
            GetServerName();
        }
        private void GetIPCanPing()
        {
        
            if (subnet.Split('0').Length - 1 == 1)
            {
                for (int i = 1; i < 255; i++)
                {
                    Ping p = new Ping();
                    p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                    string temp = (txtIPAddress.Text.Trim().Substring(0, txtIPAddress.Text.Trim().LastIndexOf('.') + 1) + i).Replace(" ", String.Empty);
                    p.SendAsync(temp, 100, temp);
                }
            }
            if (subnet.Split('0').Length - 1 == 2)
            {
                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 1; j < 255; j++)
                    {
                        Ping p = new Ping();
                        p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                        string temp = (txtIPAddress.Text.Trim().Substring(0, txtIPAddress.Text.Trim().IndexOf('.', txtIPAddress.Text.IndexOf('.', txtIPAddress.Text.IndexOf('.') + 1)) + 1) + i + "." + j).Replace(" ", String.Empty);
                        p.SendAsync(temp, 100, temp);
                    }
                }
            }
            if (subnet.Split('0').Length - 1 == 3)
            {
                for (int i = 0; i <= 255; i++)
                {
                    for (int j = 0; j <= 255; j++)
                    {
                        for (int k = 1; k < 255; k++)
                        {
                            Ping p = new Ping();
                            p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                            string temp = (txtIPAddress.Text.Trim().Substring(0, txtIPAddress.Text.Trim().IndexOf('.') + 1) + i + "." + j + "." + k).Replace(" ", String.Empty);
                            p.SendAsync(temp, 100, temp);
                        }
                    }
                }
            }
        }
        private List<string> GetIpAddressFromHostName()
        {
            List<string> lIPs = new List<string>();
            IPHostEntry IPs = Dns.GetHostEntry(Dns.GetHostName());
            rtxtIP.Text += "Danh sách IP...\n";
            //WaitNSeconds(2);
            foreach (IPAddress ip in IPs.AddressList)
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    lIPs.Add(ip.ToString().Trim());
                    rtxtIP.Text = rtxtIP.Text + "--> " + ip.ToString().Trim() + "\n";

                }
            return lIPs;
        }
        private void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply.Status == IPStatus.Success)
            {
                lIPs.Add(ip);
                rtxtIP.Text = rtxtIP.Text + "--> " + ip + "\n";
                cbServer.Items.Add(ip.ToString().Trim());
               
            }

  
        }
        private void txtIPAddress_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIPAddress.Text.Trim().Substring(0, txtIPAddress.Text.Trim().IndexOf('.'))) < 128 && Convert.ToInt32(txtIPAddress.Text.Trim().Substring(0, txtIPAddress.Text.Trim().IndexOf('.'))) >= 1)
                subnet = "2250  0  0";
            else if (Convert.ToInt32(txtIPAddress.Text.Trim().Substring(0, txtIPAddress.Text.Trim().IndexOf('.'))) < 192)
                subnet = "2552550  0";
            else if (Convert.ToInt32(txtIPAddress.Text.Trim().Substring(0, txtIPAddress.Text.Trim().IndexOf('.'))) < 223)
                subnet = "2552552550";
        }
        public static void WaitNSeconds(int seconds)         //đợi trong seconds giây
        {
            if (seconds < 1) return;
            DateTime desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < desired)
            {
                Application.DoEvents();
            }
        }
    }
}
