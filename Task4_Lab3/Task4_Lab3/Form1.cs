using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace Task4_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
        }

        private void bt_Listen_Click(object sender, EventArgs e)
        {
            Connect();
        }


        IPEndPoint IP;
        Socket Server;
        List<Socket> ClientList;

        void Connect()
        {
            addmessage("listening");
            ClientList = new List<Socket>();

            IP = new IPEndPoint(IPAddress.Any, 2000);
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            Server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        Server.Listen(100);
                        Socket Client = Server.Accept();
                        ClientList.Add(Client);
                        
                        if (Client.Connected)
                        {
                            
                            addmessage("listening to a new client");
                            Thread receive = new Thread(Receive);
                            receive.IsBackground = true;
                            receive.Start(Client);
                        }
                            
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 2000);
                    Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                }


            });
            Listen.IsBackground = true ;
            Listen.Start();
        }


        void Receive(object obj)
        {
            Socket Client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    Client.Receive(data);

                    string message = (string)deserialize(data);

                    addmessage(message);

                    foreach (Socket item in ClientList)
                    {
                        if (item != null)
                            item.Send(serialize(message));
                    }
                }
            }
            catch 
            {
                addmessage("Close 1 client");
                ClientList.Remove(Client);
                Client.Close();
            
            }
        }

        void addmessage(string s)
        {
            lV_chat.Items.Add(new ListViewItem() { Text = s });
            lV_chat.View = View.List;
        }
        byte[] serialize(object obj)
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

        void Close()
        {
            Server.Close();
        }
    }
}
