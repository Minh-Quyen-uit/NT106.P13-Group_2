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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Excercise_3.JsonFile;
using System.Runtime.Serialization;
using System.Xml;

namespace Excercise_3
{
    public partial class MainScreen : Form
    {
        IPEndPoint ipe;
        TcpClient tcpClient;
        Stream stream;

        public MainScreen(string Username)
        {
            InitializeComponent();
            Connect();
            Send(Username);
        }


        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void LogOut_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // TCP
        void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            tcpClient = new TcpClient();
            tcpClient.Connect(ipe);
            stream = tcpClient.GetStream();
            Thread recv = new Thread(Receive);
            recv.IsBackground = true;
            recv.Start();
        }

        void Send(string username)
        {
            string str = "2" + Environment.NewLine + username + Environment.NewLine;
            byte[] data = Encoding.UTF8.GetBytes(str);
            stream.Write(data, 0, data.Length);

        }

        void Receive()
        {
            while (true)
            {

                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                string xmlStr = Encoding.UTF8.GetString(recv);
                string s = DeserializeXMLData(xmlStr);
                string[] str = s.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                UserName.Text = str[0];
                FullName.Text = str[1];
                Email.Text = str[2];
                BirthDay.Text = str[3];
                //AddMessage(s);
                //if (int.Parse(str[0].Trim()) == 0)
                //{
                //    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (int.Parse(str[0].Trim()) == 2)
                //{

                //}
            }

        }
        public string DeserializeXMLData(string xmlString)
        {
            xmlString = xmlString.TrimEnd('\0');
            using (var stringReader = new StringReader(xmlString))
            using (var xmlReader = XmlReader.Create(stringReader))
            {
                var serializer = new DataContractSerializer(typeof(string));
                return (string)serializer.ReadObject(xmlReader);
            }
        }

    }
}
