using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class BookingDAO : DBContext
    {
        public void bookingRoom(Booking b)
        {
            string sql = "insert into Booking values (@FirstName, @LastName, @PhoneNumber, @IndentityCard, @TypeRoom, @DateOfBooking, @BillAmount, @Address)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@FirstName", b.FirstName);
            command.Parameters.Add("@LastName", b.LastName);
            command.Parameters.Add("@PhoneNumber", b.PhoneNumber);
            command.Parameters.Add("@IndentityCard", b.IndentityCard);
            command.Parameters.Add("@TypeRoom", b.TypeRoom);
            command.Parameters.Add("@DateOfBooking", b.DateOfBooking);
            command.Parameters.Add("@BillAmount", b.BillAmount);
            command.Parameters.Add("@Address", b.Address);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable showBooking()
        {
            string sql = "select * from Booking";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void removeBooking(int id)
        {
            string sql = "DELETE FROM Booking WHERE BookingId = " + id;
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            connection.Open();  
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
