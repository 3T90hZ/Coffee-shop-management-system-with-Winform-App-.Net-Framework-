using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider? instance;

        public static DataProvider Instance 
        { 
            get{if (instance == null) instance = new DataProvider(); return DataProvider.instance; } 
            private set => instance = value; 
        }
        private DataProvider() { }

        private const string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_QuanCafe;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public DataTable ExecuteQuery(string query, object[]? objects = null)
        {
            DataTable dt = new();
            using (SqlConnection conn = new(connectionStr))
            {
                conn.Open();
                SqlCommand command = new(query, conn);
                if (objects != null)
                {
                    string[] paralist = query.Split(' ');
                    int i = 0;
                    foreach (string para in paralist)
                    {
                        if (para.Contains("@"))
                        {
                            command.Parameters.AddWithValue(para, objects[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new(command);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }
        public int ExecuteNonQuery(string query, object[]? objects = null)
        {
            int dt = 0;
            using (SqlConnection conn = new(connectionStr))
            {
                conn.Open();
                SqlCommand command = new(query, conn);
                if (objects != null)
                {
                    string[] paralist = query.Split(' ');
                    int i = 0;
                    foreach (string para in paralist)
                    {
                        if (para.Contains("@"))
                        {
                            command.Parameters.AddWithValue(para, objects[i]);
                            i++;
                        }
                    }
                }
                dt = command.ExecuteNonQuery();
                conn.Close();
            }
            return dt;
        }
        public object ExecuteScalar(string query, object[]? objects = null)
        {
            object dt = 0;
            using (SqlConnection conn = new(connectionStr))
            {
                conn.Open();
                SqlCommand command = new(query, conn);
                if (objects != null)
                {
                    string[] paralist = query.Split(' ');
                    int i = 0;
                    foreach (string para in paralist)
                    {
                        if (para.Contains("@"))
                        {
                            command.Parameters.AddWithValue(para, objects[i]);
                            i++;
                        }
                    }
                }
                dt = command.ExecuteScalar();
                conn.Close();
            }
            return dt;
        }
    }
}
