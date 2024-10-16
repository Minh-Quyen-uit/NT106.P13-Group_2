using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Excercise_3.DAO
{
    public class DataProvider
    {
        private string connectionStr = @"Data Source=LAPTOP-SLVPL967;Initial Catalog=QuanLyNguoiDung;Integrated Security=True;Trust Server Certificate=True";
        
        public DataTable ExecuQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            
            return data;
        }

    }
}
