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
using System.Net.NetworkInformation;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading;

namespace GUI
{
    public partial class frmKhungChat : Form
    {
        Socket sck;
        EndPoint epLocal;
        EndPoint epRemote;
        private string myIP;
        private string friendIP;
        private string myName;
        private string friendName;
        public string MyIP { get => myIP; set => myIP = value; }
        public string FriendIP { get => friendIP; set => friendIP = value; }
        public string FriendName { get => friendName; set => friendName = value; }
        public string MyName { get => myName; set => myName = value; }

        public frmKhungChat(string myIP,string friendIP,string myName, string friendName)
        {
            MyIP = myIP;
            FriendIP = friendIP;
            FriendName = friendName;
            MyName = myName;
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            InitializeComponent();
            
            
        }

        

        private void frmKhungChat_Load(object sender, EventArgs e)
        {
            
            connect();
        }
        void connect()
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(MyIP), 9999);
                sck.Bind(epLocal);
                epRemote = new IPEndPoint(IPAddress.Parse(FriendIP), 9999);
                sck.Connect(epRemote);
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                txtMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);

                if (size > 0)
                {
                    byte[] receiveData = new byte[1464];
                    receiveData = (byte[])aResult.AsyncState;
                    string receiveMessage = (string)deserialize(receiveData);
                    lvMessage.Items.Add(FriendName + " : " + receiveMessage);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch 
            {
                //MessageBox.Show(exp.ToString());
            }
        }
        byte[] serialize(object obj)  //phân mãnh tin
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }
        object deserialize(byte[] data) //gọp mãnh tin
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                sck.Send(serialize(txtMessage.Text));
                lvMessage.Items.Add("Bạn : " + txtMessage.Text);
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmKhungChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            sck.Close();
        }       

    }
}