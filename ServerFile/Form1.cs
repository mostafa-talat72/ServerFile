using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace ServerFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            string input, stringData;
            int recv;
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);
            }
            catch (SocketException ex)
            {
                InfoTxt.Text += "Unable to connect to server.\n";
                InfoTxt.Text += ex.ToString() + "\n";
                return;
            }
            NetworkStream ns = new NetworkStream(server);
            if (ns.CanRead)
            {
                recv = ns.Read(data, 0, data.Length);
                stringData = Encoding.ASCII.GetString(data, 0, recv);
                InfoTxt.Text += stringData + "\n";
            }
            else
            {
                InfoTxt.Text += "Error: Can't read from this socke\n";
                ns.Close();
                server.Close();
                return;
            }
            bool ok = false;
            input = PathFileTxt.Text;
            if (ns.CanWrite)
            {
                ok = true;
                ns.Write(Encoding.ASCII.GetBytes("Send File --> "), 0, "Send File --> ".Length);
                ns.Flush();
                ns.Write(Encoding.ASCII.GetBytes(input), 0, input.Length);
                ns.Flush();
                Stream file = new FileStream(input, FileMode.OpenOrCreate);
                file.Close();
                StreamReader streamReader = new StreamReader(input);
                string line = streamReader.ReadToEnd();
                ns.Write(Encoding.ASCII.GetBytes(line), 0, line.Length);
                ns.Flush();
                InfoTxt.Text += "";
            }
            recv = ns.Read(data, 0, data.Length);
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            InfoTxt.Text += stringData.Substring(0, "Send File --> ".Length + PathFileTxt.TextLength) + "\n";
            InfoTxt.Text += "The file has been sent successfully..\n";
            InfoTxt.Text += "................................................................\n";
            InfoTxt.Text += "Disconnecting from server...\n";
            ns.Close();
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }
    }
}