using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


using OrderManagementSystem.Business;
namespace OrderManagementSystem.DataLink
{
    public class UserDB
    {
        public static bool GetCredentials(User user)
        {
            bool Flag = false;
            SqlConnection sqlconn = Connection.SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = "SELECT UserID, Password FROM Users WHERE UserID = @UserID AND Password = @Password";
            sqlcmd.Parameters.AddWithValue("@UserID", user.UserID);
            sqlcmd.Parameters.AddWithValue("@Password", user.Password);
            SqlDataReader reader = sqlcmd.ExecuteReader();


            if (reader.HasRows)
            {
                Flag = true;
            }

            sqlconn.Close();

            return Flag;
        }

        public static int GetUserTypeID(User user)
        {
            int Usertype = 0;
            SqlConnection sqlconn = Connection.SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = "SELECT UserTypeID FROM Users WHERE UserID = @UserID AND Password = @Password";
            sqlcmd.Parameters.AddWithValue("@UserID", user.UserID);
            sqlcmd.Parameters.AddWithValue("@Password", user.Password);
            SqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {
                Usertype = Convert.ToInt32(reader["UserTypeID"]);
            }
            return Usertype;
        }

        public static List<String> GetAllUserTypes()
        {
            List<string> AllUserTypes = new List<string>();

            SqlConnection sqlconn = Connection.SqlConnection();
            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM UserTypes", sqlconn);
            SqlDataReader reader = sqlcmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string userTypeid = reader["UserTypeID"].ToString();
                    string userTypeName = reader["UserTypeName"].ToString();
                    AllUserTypes.Add($"{userTypeid}: {userTypeName}");
                }
            }
            else
            {
                AllUserTypes = null;
            }

            sqlconn.Close();

            return AllUserTypes;
        }

        public static User GenerateAndSaveUserNamePassword(User user)
        {
            SqlConnection sqlconn = Connection.SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();
            List<User> userdetails = new List<User>();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = "EXEC GenerateAndSaveUserIDandPassword @UserType = @User_Type, @UserID = @User_ID, " +
                "@EmployeeID = 'KP3S0', @Password = @Pword";
            sqlcmd.Parameters.AddWithValue("@User_Type",user.UserTypeId);
            sqlcmd.Parameters.AddWithValue("@User_ID",RandomNumberGenerator.GenerateRandomString(5));
            sqlcmd.Parameters.AddWithValue("@Pword",RandomNumberGenerator.GenerateRandomString(15));
            User usr = new User();

            using (var reader = sqlcmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    usr.UserID = reader.GetString(reader.GetOrdinal("UserID"));
                    usr.Password = reader.GetString(reader.GetOrdinal("Password"));
                    usr.UserTypeId = Convert.ToInt32(reader.GetOrdinal("UserTypeId"));
                }
            }
            
            sqlconn.Close();

            return usr;

        }
    }
}
