using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Internal_Communications
{
    public partial class InstantMessaging : Form
    {
        TcpClient Client = new TcpClient();

        public InstantMessaging()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Back.Enabled = false;
            btn_Disconnect.Enabled = false;
            btn_Send.Enabled = false;
            txt_Host.Text = GetLocalIP();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            btn_Send.Enabled = true;
            btn_Connect.Enabled = false;
            ConnectToServer();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txt_Message.Text == "") return;
            else
            {
                Stream stm = Client.GetStream();
                string str = txt_Message.Text;
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                stm.Write(ba, 0, ba.Length);

                lst_Status.Items.Add("You said : " + str);
                txt_Message.Text = "";
            }
            /*byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);

            string msg = "";
            for (int i = 0; i < k; i++)
            {
                msg += (Convert.ToChar(bb[i]));
            }
            lst_Status.Items.Add(msg);*/
        }

        private void txt_Message_TextChanged(object sender, EventArgs e)
        {

        }

        private string GetLocalIP()
        {
            //find my own IP
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    return address.ToString();
            }
            return "127.0.0.1";
        }

        private void ConnectToServer()
        {
            try
            {
                IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(txt_Host.Text), 80);//specifying the server's IP End Point
                lst_Status.Items.Add("Connecting....");
                Client.Connect(serverEndPoint);//connect to server
                lst_Status.Items.Add("Connected to " + (serverEndPoint));
                lst_Status.Items.Add("*****************************************************************************");
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong IP Address", "Server Not Available");
            }
        }

        private void lst_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
        }

        private void brn_Back_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Menu = new Form1();
            Menu.ShowDialog();
            this.Close();
        }
    }
}

