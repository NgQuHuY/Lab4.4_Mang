using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Task4_Lab3_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; 
            Connect();
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            Send();
        }

        IPEndPoint IP;
        Socket Client;

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("172.30.182.27"), 2000);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                Client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Khong the ket noi Server !", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Close()
        {
            Client.Close();
        }

        void Send()
        {
            string message = "";
            if (tb_message.Text != string.Empty && tb_name.Text != string.Empty)
            {
               message = tb_name.Text.ToString() + " : " + tb_message.Text.ToString();
            }
               
              Client.Send(serialize(message));
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 1000];
                    Client.Receive(data);

                    string message = (string)deserialize(data);

                    addmessage(message);
                }
            } catch { Close(); }
        }

        void addmessage (string s)
        {
            lV_chat.Items.Add(new ListViewItem() { Text = s});
        }

        byte[] serialize(string obj)
        { 
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        object deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}