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
            Connect();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        void Send()
        {
            string str = "1" + Environment.NewLine + UserName.Text + Environment.NewLine + PassWord.Text + Environment.NewLine
                + FullName.Text + Environment.NewLine
                + Email.Text + Environment.NewLine + BirthDay.Text; 
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
                    MessageBox.Show("Đăng ký thành công!");
                }
                else
                {
                    return;
                }
            }

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
