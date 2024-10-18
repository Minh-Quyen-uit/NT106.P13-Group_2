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

        void LoadUserAccount(string UserName)
        {

            string query = "Exec dbo.USP_GetAccountByUserName @username";
            //Exec dbo.USP_GetAccountByUserName @username = N'admin01'
            //AddMessage(UserName);
            DgvAccounts.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"admin01"});
            
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
                    AddMessage("Client:\n");
                    string username = str[1].Trim();
                    string password = str[2].Trim();
                    AddMessage(username);
                    AddMessage(password);

                    bool result = AccountDAO.Instance.login(username, password);
                    if (result)
                    {
                        //cho phep dang nhap
                        //LoadUserAccount(username);
                        Send(client, "1");
                    }
                    else
                    {
                        //khong cho phep dang nhap
                        Send(client, "0");
                    }
                }
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
