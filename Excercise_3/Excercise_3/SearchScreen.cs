using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excercise_3.DAO;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization;
using System.Xml;
using Microsoft.IdentityModel.Tokens;

namespace Excercise_3
{
    public partial class SearchScreen : Form
    {
        IPEndPoint ipe;
        TcpClient tcpClient;
        Stream stream;

        private const string ApiKey = "AIzaSyAGZGbl5AsfsrSspaKzaE0SS3CpjljQTRY";
        private int progressValue;
        string UserName;
        int Count;
        public SearchScreen(string Username)
        {
            InitializeComponent();
            this.UserName = Username;
            Connect();

            progressBar.Visible = false; // Ẩn ProgressBar khi khởi động
            timer.Interval = 1000; // Mỗi 100ms, ProgressBar sẽ cập nhật
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            progressValue += 2;
            if (progressValue >= progressBar.Maximum)
            {
                progressValue = progressBar.Maximum;
            }
            progressBar.Value = progressValue;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Hãy nhập từ khóa để tìm kiếm sách.");
                return;
            }

            string apiUrl = $"https://www.googleapis.com/books/v1/volumes?q={query}&key={ApiKey}";

            progressBar.Visible = true;
            progressBar.Value = 0;
            progressValue = 0;
            timer.Start();

            await SearchBooks(apiUrl);

            timer.Stop();
            progressBar.Value = progressBar.Maximum;
        }

        private async Task SearchBooks(string apiUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    JArray items = (JArray)json["items"];

                    if (items != null)
                    {
                        dgvBooks.Rows.Clear();
                        foreach (var item in items)
                        {
                            string title = (string)item["volumeInfo"]["title"];
                            string authors = item["volumeInfo"]["authors"] != null ?
                                 string.Join(", ", item["volumeInfo"]["authors"]) : "N/A";
                            string publishedDate = (string)item["volumeInfo"]["publishedDate"] ?? "N/A";

                            dgvBooks.Rows.Add(title, authors, publishedDate);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sách nào.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btnCreateBookshelf_Click(object sender, EventArgs e)
        {
            
            string BookshelfName = txtBookshelfTitle.Text;
            if (string.IsNullOrEmpty(BookshelfName))
            {
                MessageBox.Show("Vui lòng nhập tên kệ sách!");
                return;
            }
            else
            {
                this.Count = 1;
                Send(BookshelfName);
            }
            //int result = BookShelf.Instance.AddBookShelf(txtBookshelfTitle.Text, UserName);
            //if (result != 0) MessageBox.Show("");
            //else MessageBox.Show("Lỗi không thêm được");
        }

        private void ShowBookShelfs_Click(object sender, EventArgs e)
        {
            //this.Count = 0;
            //Send("");
            dvgBookshelf.DataSource = DataProvider.Instance.ExecuteQuery("SELECT BookshelfName FROM dbo.BookShelfs WHERE UserName = N'" + UserName + "' ");
        }

        #region TCP_connect
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

        void Send(string BookshelfName)
        {
            string str = "";
            if (Count == 0)
            {
                str = "3" + Environment.NewLine + UserName + Environment.NewLine;
            }
            else if (Count == 1)
            {
                str = "4" + Environment.NewLine + BookshelfName + Environment.NewLine + UserName + Environment.NewLine;
            }
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
                DataTable dt = DeserializeXMLData(xmlStr);
                
                //AddMessage(s);
                if (dt.Rows.Count==0 && Count == 4)
                {
                    MessageBox.Show("Kệ sách đã tồn tại !!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dvgBookshelf.DataSource = null;
                    //dvgBookshelf.Rows.Clear();
                    //if(dvgBookshelf.Rows.Count > 0)
                    //{
                    //    dvgBookshelf.Rows.Clear();
                    //}
                    //foreach (string str in list)
                    //{
                    //    dvgBookshelf.Rows.Add(str);
                    //}
                    dvgBookshelf.DataSource = dt;
                    dvgBookshelf.Columns["BookshelfName"].HeaderText = "Kệ sách";
                }
            }

        }

        public DataTable DeserializeXMLData(string xmlString)
        {
            xmlString = xmlString.TrimEnd('\0');
            using (var stringReader = new StringReader(xmlString))
            using (var xmlReader = XmlReader.Create(stringReader))
            {
                var serializer = new DataContractSerializer(typeof(DataTable));
                return (DataTable)serializer.ReadObject(xmlReader);
            }
        }
        #endregion


        private void PersonInfo_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen(UserName);
            this.Hide();
            mainScreen.ShowDialog();
            this.Show();
        }
    }
}
