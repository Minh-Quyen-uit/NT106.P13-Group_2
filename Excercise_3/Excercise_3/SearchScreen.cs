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
using Excercise_3.JsonFile;
//using Excercise_3.DAO;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization;
using System.Xml;
using Microsoft.IdentityModel.Tokens;
using Google.Apis.Books.v1.Data;
using System.Text.Json;
using Google.Apis.Util;
using Azure.Core;
using Newtonsoft.Json;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;

namespace Excercise_3
{
    public partial class SearchScreen : Form
    {
        private string[] Scopes = { "https://www.googleapis.com/auth/books" }; // Phạm vi quyền truy cập vào Google Books API
        private UserCredential credential;

        private List<string> selectedValues = new List<string>();
        private const string BookshelfFilePath = "bookshelves.json";
        private List<Bookshelfs> bookshelves;
        private List<Bookshelfs> bookshelvesPersonal;
        private string accessToken;

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
            GetAccessTokenAsync().Wait();
            this.UserName = Username;
            //Connect();
            LoadBookshelves();
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
                            string bookId = item["id"]?.ToString() ?? "Không có mã sách";

                            dgvBooks.Rows.Add(title, authors, publishedDate, bookId);
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

        private async void btnCreateBookshelf_Click(object sender, EventArgs e)
        {

            string BookshelfName = txtBookshelfTitle.Text;
            string bookshelfDescription = UserName;



            if (string.IsNullOrEmpty(BookshelfName))
            {
                MessageBox.Show("Vui lòng nhập tên kệ sách!");
                return;
            }
            bool bookshelfExists = bookshelves.Exists(b =>
                b.Title.Equals(BookshelfName, StringComparison.OrdinalIgnoreCase) &&
                b.Description.Equals(bookshelfDescription, StringComparison.OrdinalIgnoreCase)
            );

            if (bookshelfExists)
            {
                MessageBox.Show("Kệ sách đã tồn tại. Vui lòng đặt tên khác.");
                return;
            }
            var newBookshelf = new Bookshelfs
            {
                Title = BookshelfName,
                Description = bookshelfDescription
            };

            bookshelves.Add(newBookshelf);
            dgvBookshelf.Rows.Add(newBookshelf.Title);

            // Lưu kệ sách vào file JSON;
            SaveBookshelves();

            // Xóa nội dung nhập sau khi tạo
            txtBookshelfTitle.Clear();


            MessageBox.Show("Kệ sách đã được tạo thành công!");

            //string title = txtBookshelfTitle.Text;
            //string description = UserName;

            //if (string.IsNullOrEmpty(title))
            //{
            //    MessageBox.Show("Vui lòng nhập tên kệ sách.");
            //    return;
            //}

            //bool result = await CreateBookshelfAsync(title, description);

            //if (result)
            //    MessageBox.Show("Tạo kệ sách mới thành công.");
            //else
            //    MessageBox.Show("Không thể tạo kệ sách mới.");
        }

        private void PersonInfo_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen(UserName);
            this.Hide();
            mainScreen.ShowDialog();
            this.Show();
        }


        private void dgvBookshelf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBookshelf.Columns["DeleteBookShelf"].Index)
            {
                if (dgvBookshelf.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    int rowIndex = e.RowIndex;
                    string bookshelfNameToDelete = dgvBookshelf.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    var bookshelfToDelete = bookshelves.Find(b => b.Title.Equals(bookshelfNameToDelete, StringComparison.OrdinalIgnoreCase));
                    bookshelves.Remove(bookshelfToDelete);
                    dgvBookshelf.Rows.RemoveAt(rowIndex);
                    SaveBookshelves();
                }

            }
            if (e.ColumnIndex == dgvBookshelf.Columns["SelecBookshelf"].Index && e.RowIndex >= 0)
            {
                if (dgvBookshelf.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dgvBookshelf.Rows[e.RowIndex].Cells[1];

                    // Kiểm tra trạng thái checkbox (tick hoặc bỏ tick)
                    bool isChecked = (bool)checkBoxCell.EditedFormattedValue;

                    // Lấy giá trị của ô ở cột thứ 2 (cột 1 tính từ 0) trong hàng hiện tại
                    string value = dgvBookshelf.Rows[e.RowIndex].Cells[0].Value.ToString();

                    if (isChecked)
                    {
                        // Thêm giá trị vào mảng nếu checkbox được tick
                        if (!selectedValues.Contains(value))
                        {
                            selectedValues.Add(value);
                        }
                    }
                    else
                    {
                        // Xóa giá trị khỏi mảng nếu checkbox bị bỏ tick
                        if (selectedValues.Contains(value))
                        {
                            selectedValues.Remove(value);
                        }
                    }
                    updateDgvShowBookshelfs();
                }
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBooks.Columns["selecBook"].Index)
            {
                if (dgvBooks.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string bookTitle = dgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    string bookAuthor = dgvBooks.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                    string bookPublishedDate = dgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                    string bookId = dgvBooks.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                    var newBook = new Book
                    {
                        Title = bookTitle,
                        Author = bookAuthor,
                        PublishedDate = bookPublishedDate,
                        Id = bookId
                    };
                    bool bookAdded = false;
                    foreach (var item in bookshelves)
                    {
                        if (selectedValues.Contains(item.Title) && item.Description == UserName)
                        {

                            bool bookExists = item.Books.Exists(b => b.Id.Equals(bookId, StringComparison.OrdinalIgnoreCase));

                            if (bookExists)
                            {
                                MessageBox.Show($"Sách đã tồn tại trong kệ sách {item.Title}.");
                                continue;
                            }
                            item.Books.Add(newBook);
                            bookAdded = true;
                        }
                    }
                    if (bookAdded)
                    {
                        // Lưu lại danh sách kệ sách vào file JSON

                        SaveBookshelves();
                        updateDgvShowBookshelfs();
                        MessageBox.Show("Sách đã được thêm vào kệ sách!");
                    }
                    else
                    {
                        MessageBox.Show("Không có kệ sách nào phù hợp để thêm sách.");
                    }
                }

            }
        }

        private void dgvShowBookShelfs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach(var str in selectedValues)
            {
                if (e.ColumnIndex == dgvShowBookShelfs.Columns["DeleteBook" + str].Index)
                {
                    string bookTitle = dgvShowBookShelfs.Rows[e.RowIndex].Cells[e.ColumnIndex-2].Value.ToString();
                    string bookID = dgvShowBookShelfs.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value.ToString();
                    DialogResult result = MessageBox.Show(
                        $"Bạn có chắc chắn muốn xóa cuốn sách '{bookTitle}' với ID '{bookID}' khỏi kệ sách không?",
                        "Xác nhận xóa sách",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    // Kiểm tra nếu người dùng chọn "No" thì dừng thực hiện thao tác xóa
                    if (result == DialogResult.No)
                    {
                        return;
                    }

                    foreach (var item in bookshelves)
                    {
                        // Tìm cuốn sách cần xóa trong kệ sách này
                        if(item.Title == str)
                        {
                            var bookToDelete = item.Books.FirstOrDefault(b => string.Equals(b.Id, bookID, StringComparison.OrdinalIgnoreCase));

                            if (bookToDelete != null)
                            {
                                // Nếu tìm thấy sách, xóa nó khỏi kệ sách
                                item.Books.Remove(bookToDelete);

                                SaveBookshelves();
                                // Cập nhật lại giao diện người dùng (DataGridView hoặc ListBox)
                                // Xóa dòng hiện tại trong DataGridView
                                updateDgvShowBookshelfs();
                                MessageBox.Show($"Cuốn sách '{bookTitle}' đã được xóa khỏi kệ sách.");
                                break; // Xóa xong, thoát khỏi vòng lặp
                            }
                        }
                    }
                }
            }
        }

        #region Bookshelf
        void LoadBookshelves()
        {
            // Kiểm tra nếu file JSON tồn tại, thì đọc dữ liệu vào danh sách kệ sách
            if (File.Exists(BookshelfFilePath))
            {
                string json = File.ReadAllText(BookshelfFilePath);
                bookshelves = System.Text.Json.JsonSerializer.Deserialize<List<Bookshelfs>>(json) ?? new List<Bookshelfs>();
            }
            else
            {
                bookshelves = new List<Bookshelfs>();
            }

            // Hiển thị danh sách kệ sách trong ListBox
            foreach (var bookshelf in bookshelves)
            {
                if (bookshelf.Description == UserName)
                    dgvBookshelf.Rows.Add(bookshelf.Title); // lstBookshelves là control thứ 3
            }
        }
        private void SaveBookshelves()
        {
            // Ghi danh sách kệ sách vào file JSON
            string json = System.Text.Json.JsonSerializer.Serialize(bookshelves, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(BookshelfFilePath, json);
        }


        #endregion

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
                    dgvBookshelf.DataSource = null;
                    //dvgBookshelf.Rows.Clear();
                    //if(dvgBookshelf.Rows.Count > 0)
                    //{
                    //    dvgBookshelf.Rows.Clear();
                    //}
                    //foreach (string str in list)
                    //{
                    //    dvgBookshelf.Rows.Add(str);
                    //}
                    dgvBookshelf.DataSource = dt;
                    dgvBookshelf.Columns["BookshelfName"].HeaderText = "Kệ sách";
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

        public void updateDgvShowBookshelfs()
        {
            dgvShowBookShelfs.Columns.Clear();

            foreach (var item in bookshelves)
            {
                if (selectedValues.Contains(item.Title) && item.Description == UserName)
                {
                    dgvShowBookShelfs.Columns.Add(item.Title, item.Title);
                    dgvShowBookShelfs.Columns.Add("ID"+item.Title, "Mã sách");
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.HeaderText = "Xóa khỏi kệ sách";
                    buttonColumn.Name = "DeleteBook"+item.Title;
                    buttonColumn.UseColumnTextForButtonValue = true;
                    dgvShowBookShelfs.Columns.Add(buttonColumn);
                    int i = 0;
                    foreach (var bookItem in item.Books)
                    {
                        if (dgvShowBookShelfs.Rows.Count-i == 1)
                        {
                            dgvShowBookShelfs.Rows.Add();
                        }
                        dgvShowBookShelfs.Rows[i].Cells[item.Title].Value = bookItem.Title;
                        dgvShowBookShelfs.Rows[i].Cells["ID"+item.Title].Value = bookItem.Id;
                        i++;
                    }
                }
            }
        }

        private async Task<bool> CreateBookshelfAsync(string title, string description)
        {
            if (string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("Access token không hợp lệ.");
                return false;
            }

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                string requestUrl = "https://www.googleapis.com/books/v1/mylibrary/bookshelves";

                var bookshelfData = new
                {
                    titles = title,
                    descriptions = description
                };

                string jsonContent = JsonConvert.SerializeObject(bookshelfData);
                StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(requestUrl, content);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return false;
                }


                return true;
            }
        }

        private class Bookshelfs
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public List<Book> Books { get; set; } = new List<Book>();
            public override string ToString()
            {
                return $"{Title} - {Description}";
            }
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string PublishedDate { get; set; }

            public string Id { get; set; }
        }

        private async Task GetAccessTokenAsync()
        {
            try
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets
                    {
                        ClientId = "991804734265-844ne7l8tqt09hrbfo4qhgecvno7csob.apps.googleusercontent.com", // Thay YOUR_CLIENT_ID bằng Client ID của bạn
                        ClientSecret = "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" // Thay YOUR_CLIENT_SECRET bằng Client Secret của bạn
                    },
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore("BooksApiTokenStore", true)
                );
                accessToken = credential.Token.AccessToken;
                //MessageBox.Show("Access Token: " + credential.Token.AccessToken);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy access token: " + ex.Message);
            }
        }

        
    }


}
