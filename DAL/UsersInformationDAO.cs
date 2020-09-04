using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UsersInformationDAO : DBContext
    {
        public void registerUser(UsersInformation ui)
        {
            string sqlInfor = "insert into UsersInformation values (@Username,@Password,@Firstname,@Lastname,@Email,@IndentityCard,@Address,@PhoneNumber,@Dob)";
            SqlCommand command = new SqlCommand(sqlInfor, connection);
            command.Parameters.Add(new SqlParameter("@Username", ui.Username ));
            command.Parameters.Add(new SqlParameter("@Password", ui.Password));
            command.Parameters.Add(new SqlParameter("@Firstname", ui.Firstname));
            command.Parameters.Add(new SqlParameter("@Lastname", ui.Lastname));
            command.Parameters.Add(new SqlParameter("@Email", ui.Email));
            command.Parameters.Add(new SqlParameter("@IndentityCard", ui.IndentityCard));
            command.Parameters.Add(new SqlParameter("@Address", ui.Address));
            command.Parameters.Add(new SqlParameter("@PhoneNumber", ui.PhoneNumber));
            command.Parameters.Add(new SqlParameter("@Dob", ui.Dob));



            connection.Open();

            command.ExecuteNonQuery();
            

            connection.Close();

        }

        public void addUsers(Users u)
        {
            string sqlUsers = " insert into Users values (@Username,@Password, @RoleId)";
            SqlCommand commandUsers = new SqlCommand(sqlUsers, connection);
            commandUsers.Parameters.Add(new SqlParameter("@Username", u.Username));

            commandUsers.Parameters.Add(new SqlParameter("@Password", u.Password));
            commandUsers.Parameters.Add(new SqlParameter("@RoleId", 0));
            connection.Open();
            commandUsers.ExecuteNonQuery();
            connection.Close();
        }
    }
}
