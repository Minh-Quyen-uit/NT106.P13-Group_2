using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Excercise_3.JsonFile
{
    public class BookShelf
    {
        private static BookShelf instance;
        private BookShelf() { }

        public static BookShelf Instance {
            get { if (instance == null) instance = new BookShelf(); return instance; }
            private set => instance=value;
        }

        // Thêm kệ sách
        public int AddBookShelf(string BookshelfName, string UserName)
        {
            // Tránh SQL Injection bằng cách sử dụng tham số
            string query = "SELECT * FROM dbo.BookShelfs WHERE BookshelfName = @BookshelfName AND UserName = @UserName";
            DataTable BookshelfNameResult = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BookShelfs WHERE BookshelfName = N'" + BookshelfName + "' and UserName = N'" + UserName + "' ");
            if(BookshelfNameResult.Rows.Count > 0) 
            {
                //MessageBox.Show("Tên kệ sách đã tồn tại!"); 
                return 0;
            }
            query = "INSERT INTO dbo.BookShelfs (BookshelfName, UserName) VALUES ( @BookshelfName , @UserName )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { BookshelfName, UserName });
            return result;
        }

        public DataTable GetBookShelfs(string UserName)
        {
            // Tránh SQL Injection bằng cách sử dụng tham số
            string query = "SELECT BookshelfName FROM dbo.BookShelfs WHERE UserName = @UserName";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { UserName });
            //DataTable data = DataProvider.Instance.ExecuteQuery("SELECT BookshelfName FROM dbo.BookShelfs WHERE UserName = N'" + UserName + "' ");
            //List<string> list = new List<string>();
            //foreach (DataRow row in data.Rows)
            //{
            //    list.Add(row["BookshelfName"].ToString());
            //}
            //return list;
        }
    }
}
