using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UserDAO : DBContext
    {
        
            public string getUser(string user, string pass)
            {
                string id = "";
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Users where Username = '" + user + "' and Password ='" + pass + "'", connection);
                adapter.Fill(table);
                if (table != null)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        id = dr["UserId"].ToString();
                    }
                }
                return id;
            }

        public DataTable showAccount()
        {
            string sql = "select * from Users";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void removeAccount(int id)
        {
            string sql = "DELETE FROM Users WHERE UserId = " + id;
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

    }
}
