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
        private static DataProvider instance;

        private string connectionStr = @"Data Source=LAPTOP-SLVPL967;Initial Catalog=QuanLyNguoiDung;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { instance=value; }
        }
        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();
                

                connection.Close();
            }

            return data;
        }

        public List<string> ExecuteReader(string query, object[] parameter = null)
        {
            List<string> data = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string data1 = reader.GetString(0); data.Add(data1);
                    string data2 = reader.GetString(1); data.Add(data2);
                    string data3 = reader.GetString(2); data.Add(data3);
                    string data4 = reader.GetString(3); data.Add(data4);
                    DateTime Datedata5 = reader.GetDateTime(4);
                    string data5 = Datedata5.ToString(); data.Add(data5);
                    
                }

                connection.Close();
            }

            return data;
        }

        
        
    }
}
