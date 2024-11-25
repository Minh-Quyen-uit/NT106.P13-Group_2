using Excercise_3.JsonFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Excercise_3
{
    public partial class ForgotPassword : Form
    {
        IPEndPoint ipe;
        TcpClient tcpClient;
        Stream stream;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void Send_Btn_Click(object sender, EventArgs e)
        {
            Connect();

            if(CheckValidEmail(Email_Tb.Text))
            {
                Send(Email_Tb.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!");
                return;
            }
            
        }

        #region TCP_Listener
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

        void Send(string email)
        {
            string str = "4" + Environment.NewLine + email + Environment.NewLine;
            byte[] data = Encoding.UTF8.GetBytes(str);
            stream.Write(data, 0, data.Length);

        }

        void Receive()
        {
            while (true)
            {

                byte[] recv = new byte[5000*1024];
                stream.Read(recv, 0, recv.Length);
                string xmlStr = Encoding.UTF8.GetString(recv);
                string s = DeserializeXMLData(xmlStr);

                if (int.Parse(s) == 0)
                {
                    MessageBox.Show("Email chưa có tài khoản đăng ký!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(s) == 1)
                {
                    string password = GeneratePassword(8);
                    SendEmail(password);
                    this.Close();
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

        void SendEmail(string password)
        {
            try
            {
                string senderEmail = "oke147019@gmail.com";
                string senderPassword = "i l p d m p s t b n z o u c i z";
                
                var sha256 = SHA256.Create();
                byte[] Password = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string EncryptedPassword = Convert.ToBase64String(Password);

                AccountDAO.Instance.ForgotPasswordReset(Email_Tb.Text, EncryptedPassword);
                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(senderEmail),
                    Subject = "Forgot password",
                    Body = "Your new password:\n" +
                            password + "\n" +
                            "Login with the new password :D\n",
                    IsBodyHtml = false
                };

                mail.To.Add(Email_Tb.Text);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 25)
                {
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true
                };

                smtp.Send(mail);
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckValidEmail(string email)
        {
            return Regex.IsMatch(email, "^[a-zA-Z0-9_.]{3,24}@gmail.com$");
        }

        #region RandomPassword
        string GeneratePassword(int length)
        {
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string specialChars = "!@#$%^&*()-_=+<>?";

            string allChars = lowerCase + upperCase + numbers + specialChars;

            Random random = new Random();

            StringBuilder password = new StringBuilder();

            password.Append(lowerCase[random.Next(lowerCase.Length)]);
            password.Append(upperCase[random.Next(upperCase.Length)]);
            password.Append(numbers[random.Next(numbers.Length)]);
            password.Append(specialChars[random.Next(specialChars.Length)]);

            for (int i = 4; i < length; i++)
            {
                password.Append(allChars[random.Next(allChars.Length)]);
            }

            return Shuffle(password.ToString());
        }

        string Shuffle(string input)
        {
            char[] array = input.ToCharArray();
            Random random = new Random();

            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (array[i], array[j]) = (array[j], array[i]);
            }

            return new string(array);
        }
        #endregion
    }
}
