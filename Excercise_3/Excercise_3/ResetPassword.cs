using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml;
using System.Security.Cryptography;

namespace Excercise_3
{
    public partial class ResetPassword : Form
    {
        IPEndPoint ipe;
        TcpClient tcpClient;
        Stream stream;
        string Username;

        public ResetPassword(string Username)
        {
            InitializeComponent();
            this.Username = Username;
        }

        private void Confirm_Btn_Click(object sender, EventArgs e)
        {
            Connect();
            
            string password = NewPassword_Tb.Text;
            string REpassword = RENewPassword_Tb.Text;
            
            if (password.Length < 8) { MessageBox.Show("Mật khẩu dài ít nhất 8 ký tự!"); return; }
            if (password != REpassword) { MessageBox.Show("Mật khẩu nhập lại không chính xác!"); return; }

            var sha256 = SHA256.Create();
            byte[] Encrypt = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            string EncryptedPassword = Convert.ToBase64String(Encrypt);

            Send(Username, EncryptedPassword);
        }

        #region TCP_Client

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
            string str = "3" + Environment.NewLine + username + Environment.NewLine + password;
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
                //AddMessage(s);

                int result = int.Parse(s);
                if (result == 1)
                {
                    if (MessageBox.Show("Bạn đã đặt lại mật khẩu thành công", "Thông báo", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    return;
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
    }
}
