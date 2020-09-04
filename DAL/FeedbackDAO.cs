using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class FeedbackDAO : DBContext
    {
        public void sendFeedback(Feedbacks f)
        {
            string sql = "insert into Feedbacks values(@Title, @Description, @Name, @Room)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@Title",f.Title);
            command.Parameters.Add("@Description", f.Description);
            command.Parameters.Add("@Name", f.Name);
            command.Parameters.Add("@Room", f.Room);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }


        public DataTable showFeedback()
        {
            string sql = "select * from Feedbacks";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
