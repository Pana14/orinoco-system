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


namespace Server
{
    public partial class Server : Form
    {
        IPAddress host;
        TcpListener Listener;
        Socket ClientConnection;
        Thread ListeningThread;

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            btn_Stop.Enabled = false;
            brn_Back.Enabled = false;
            host = GetLocalIP();
        }


        private void btn_Start_Click(object sender, EventArgs e)
        {
            brn_Back.Enabled = true;
            btn_Start.Enabled = false;
            ListeningThread = new Thread(new ThreadStart(CreateConnection)); //assign thread variable with the blocking function
            ListeningThread.Start();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {

        }

        //find my own IP
        private IPAddress GetLocalIP()
        {
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    return address;
            }
            return IPAddress.Any;
        }

        //Create a connection
        private void CreateConnection()
        {
            IPEndPoint localEndPoint = new IPEndPoint(host, 80);
            Listener = new TcpListener(localEndPoint);//listen to given localEndPoint
            Listener.Start();//start listening for connections;
            //lst_Status.Items.Add("Listening For Connections...");
            ClientConnection = Listener.AcceptSocket();//waits untill a client connects  
            //lst_Status.Items.Add("Connection Accepted : " + (ClientConnection.RemoteEndPoint));//shows the connected client's information   
            //lst_Status.Items.Add("***********************************************************************");            
        }

        private void lst_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            byte[] b = new byte[100];
            int k = ClientConnection.Receive(b);

            string msg = "";
            for (int i = 0; i < k; i++)
            {
                msg += (Convert.ToChar(b[i]));
            }
            lst_Status.Items.Add(msg);

            //ASCIIEncoding asen = new ASCIIEncoding();
            //ClientConnection.Send(asen.GetBytes("Automatic message: " + " String received by server!"));
        }

        private void brn_Back_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }
    }
}

