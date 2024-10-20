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
using Excercise_3.DAO;
using System.Security.Cryptography;


namespace Excercise_3
{
    public partial class SignUp : Form
    {

        IPEndPoint ipe;
        TcpClient tcpClient;
        Stream stream;

        public SignUp()
        {
            InitializeComponent();
            BirthDay.Format = DateTimePickerFormat.Custom;
            BirthDay.CustomFormat = "yyyy-MM-dd";
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            Connect();
            string username = UserName.Text;
            string password = PassWord.Text;
            string REpassword = PassWord_confirm.Text;
            string fullname = FullName.Text;
            string email = Email.Text;
            string birthday = BirthDay.Text;

            if (string.IsNullOrEmpty(username)) { MessageBox.Show("Vui lòng nhập tên tài khoản!"); return; }
            if (password.Length < 8) { MessageBox.Show("Mật khẩu dài ít nhất 8 ký tự!"); return; }
            if (password != REpassword) { MessageBox.Show("Mật khẩu nhập lại không chính xác!"); return; }
            if (string.IsNullOrEmpty(fullname)) { MessageBox.Show("Vui lòng nhập tên người dùng!"); return; }

            var sha256 = SHA256.Create();
            byte[] Encrypt = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            string EncryptedPassword = Convert.ToBase64String(Encrypt);

            Send(username, EncryptedPassword, fullname, email, birthday);

        }
        ////TCP

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

        void Send(string username, string password, string fullname, string email, string birthday)
        {
            string str = "1" + Environment.NewLine + username + Environment.NewLine + password + Environment.NewLine
                + fullname + Environment.NewLine
                + email + Environment.NewLine + birthday;
            byte[] data = Encoding.UTF8.GetBytes(str);
            stream.Write(data, 0, data.Length);
            //AddMessage(Message.str);

        }

        void Receive()
        {
            while (true)
            {

                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                string s = Encoding.UTF8.GetString(recv);
                //AddMessage(s);

                int result = int.Parse(s);
                if (result == 1)
                {
                    if (MessageBox.Show("Bạn đăng kí thành công", "Thông báo", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
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

        private void PasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheck.Checked)
            {
                // Hiển thị mật khẩu
                PassWord.PasswordChar = '\0';
                PassWord_confirm.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                PassWord.PasswordChar = '*';
                PassWord_confirm.PasswordChar = '*';
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //void AddMessage(string msg)
        //{
        //    if (MessScreen.Text == "")
        //    {
        //        MessScreen.Text = msg;
        //    }
        //    else
        //    {
        //        MessScreen.Text += Environment.NewLine + msg;
        //    }
        //}
    }
}
