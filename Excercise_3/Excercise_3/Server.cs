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

        void LoginUserAccount(string UserName, string PassWord)
        {

            string query = "Exec dbo.USP_GetAccountByUserName @username";
            //Exec dbo.USP_GetAccountByUserName @username = N'admin01'
            //AddMessage(UserName);
            DgvAccounts.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"admin01" });
            string username = DgvAccounts.Rows[0].Cells[0].Value.ToString();
            string password = DgvAccounts.Rows[0].Cells[1].Value.ToString();
            //AddMessage(username);
            if (username == UserName && password == PassWord)
            {
                //Send(client, "1");
                AddMessage("cho");
            }
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
            //AddMessage(Message.Text);

        }

        void Receive(object obj)
        {
            while (true)
            {
                Socket client = obj as Socket;
                byte[] recv = new byte[1024];
                client.Receive(recv);
                string s = Encoding.UTF8.GetString(recv);
                //AddMessage(s);
                string[] str = s.Split(new[] {'\n'}, StringSplitOptions.None);
                AddMessage(str[1]);
                AddMessage( str[2]);
                //LoginUserAccount(str[1], str[2]);
                string query = "begin select * from dbo.UserAccount where UserName = N'" + str[1] + "' and PassWord = N'" + str[2] + "' end ";
                AddMessage(query);
                bool result = AccountDAO.Instance.login(str[1], str[2]);
                if (result)
                {
                    Send(client, "1");
                }
                else
                {
                    Send(client, "0");
                }
                //AddMessage(str[1]);

                //if (int.Parse(str[0]) == 0)
                //{

                //    result = LoginUserAccount(str[1], str[2]); 
                //    // neu result = 1 thi gui tin hieu cho dang nhap
                //    // neu result = 0 thi dang nhap sai
                //}

                //Send(client, result.ToString());
            }

        }

        void AddMessage(string msg)
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

    }
}
