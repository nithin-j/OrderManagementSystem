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


    }
}
