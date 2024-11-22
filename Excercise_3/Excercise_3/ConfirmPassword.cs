using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography;

namespace Excercise_3
{
    public partial class ConfirmPassword : Form
    {
        //Get username to reuse AccountDAO login function in ConfirmPassword for ResetPassword
        public string Username;

        IPEndPoint ipe;
        TcpClient tcpClient;
        Stream stream;

        public ConfirmPassword(string Username)
        {
            InitializeComponent();
            this.Username = Username;
        }

        private void Confirm_Btn_Click(object sender, EventArgs e)
        {

            Connect();

            string username = Username;
            string password = Password_Tb.Text;

            var sha256 = SHA256.Create();
            byte[] EnteredPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            string EncryptEnteredPassword = Convert.ToBase64String(EnteredPassword);
            Send(username, EncryptEnteredPassword);
        }

        #region TCP_Connect

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

        void Send(string username, string password)
        {
            string str = "0" + Environment.NewLine + username + Environment.NewLine + password + Environment.NewLine;
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

                if (int.Parse(s) == 0)
                {
                    MessageBox.Show("Mật khẩu không chính xác!!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(s) == 1)
                {
                    ResetPassword resetPassword = new ResetPassword(Username);
                    this.Close();
                    resetPassword.ShowDialog();
                }
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

        #endregion

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
