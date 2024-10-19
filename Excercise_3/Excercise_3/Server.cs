using Excercise_3.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Excercise_3
{
    public partial class Server : Form
    {
        IPEndPoint ipe;
        Socket client;
        TcpListener tcpListen;
        public Server()
        {
            InitializeComponent();

            //LoadUserAccount();

            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        //TCP
        void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Any, 9999);
            tcpListen = new TcpListener(ipe);
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    tcpListen.Start();
                    client = tcpListen.AcceptSocket();
                    Thread rec = new Thread(Receive);
                    rec.IsBackground = true;
                    rec.Start(client);
                }
            });
            thread.IsBackground = true;
            thread.Start();


        }

        void Send(Socket client, string result)
        {
            byte[] data = Encoding.UTF8.GetBytes(result);
            client.Send(data);

        }

        void Receive(object obj)
        {
            while (true)
            {
                Socket client = obj as Socket;
                if (client == null)
                {

                    throw new ArgumentException("obj không thể chuyển đổi sang Socket");
                }

                byte[] recv = new byte[1024];
                int bytesReceived = client.Receive(recv);
                string s = Encoding.UTF8.GetString(recv, 0, bytesReceived);
                string[] str = s.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                if (int.Parse(str[0].Trim())==0)
                {
                    ReceiveMessage("Client Login form:\n");
                    string username = str[1].Trim();
                    string password = str[2].Trim();
                    ReceiveMessage(username);
                    ReceiveMessage(password);

                    bool result = AccountDAO.Instance.login(username, password);
                    
                    if (result)
                    {
                        //cho phep dang nhap
                        //LoadUserAccount(username);

                        Send(client, "1");
                        SendMessage("To client Login: 1");
                    }
                    else
                    {
                        //khong cho phep dang nhap

                        Send(client, "0");
                        SendMessage("To client Login: 0");
                    }
                }
                else if(int.Parse(str[0].Trim()) == 1)
                {
                    ReceiveMessage("Client Sign up form:\n");
                    string username = str[1].Trim();
                    string password = str[2].Trim();
                    string fullname = str[3].Trim();
                    string email = str[4].Trim();
                    string birthday = str[5].Trim();
                    ReceiveMessage(username);
                    ReceiveMessage(password);
                    ReceiveMessage(fullname);
                    ReceiveMessage(email);
                    ReceiveMessage(birthday);

                    if (AccountDAO.Instance.signin(username, password, fullname, email, birthday) != 0)
                    {
                        Send(client, "1");
                        SendMessage("To client Sign up: 1");
                    }
                    else
                    {
                        Send(client, "0");
                        SendMessage("To client Sign up: 0");
                    }
                }
                else if (int.Parse(str[0].Trim())==2)
                {
                    string username = str[1].Trim();
                    AccountDAO.Instance.GetUserInfo(username);
                    ReceiveMessage("Client Main form:\n");
                    ReceiveMessage(username);
                    string rec = AccountDAO.Instance.GetSetAccUsername + Environment.NewLine
                        + AccountDAO.Instance.GetSetAccFullname + Environment.NewLine
                        + AccountDAO.Instance.GetSetAccEmail + Environment.NewLine
                        + AccountDAO.Instance.GetSetAccBirthday + Environment.NewLine;
                    //AddMessage(rec);
                    Send(client, rec);
                    SendMessage("To client Main form:");
                    SendMessage(rec);
                }
            }

        }

        void ReceiveMessage(string msg)
        {
            if (ServerScreen.Text == "")
            {
                ServerScreen.Text = msg;
            }
            else
            {
                ServerScreen.Text += Environment.NewLine + msg;
            }
        }

        void SendMessage(string msg)
        {
            if (SendMess.Text == "")
            {
                SendMess.Text = msg;
            }
            else
            {
                SendMess.Text += Environment.NewLine + msg;
            }
        }

    }
}
