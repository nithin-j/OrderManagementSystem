using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using OrderManagementSystem.DataLink;

namespace OrderManagementSystem.Validation
{
    public class Validator
    {

        public static bool IsValidName(string input, int type)
        {
            string error = "";
            switch (type)
            {
                case 0: //firstname
                    error = "First name must contain only letters or space(s)";
                    break;
                case 1: //lastname
                    error = "Last name must contain only letters or space(s)";
                    break;
                default:
                    break;
            }

                if (!Regex.IsMatch(input, @"[A-Za-z]{1}[a-z]{1,25}"))
                {
                    MessageBox.Show(error, "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            return true;
        }

        public static bool IsValidEmail(string input)
        {
            string error = "Invalid Email ID. \n Email ID must be in the format \"emailid@somemail.com\"";
            if (!Regex.IsMatch(input, @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$"))
            {
                MessageBox.Show(error, "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        public static bool isValidPhone(string input)
        {
            string error = "Invalid Phone number.\n Phone number ";
            if (!Regex.IsMatch(input, @"^[1-9]{3}[0-9]{7}$"))
            {
                MessageBox.Show(error, "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        public static bool CheckIfUserIDExists(string empId)
        {
            bool Exists = false;
            SqlConnection sqlconn = Connection.SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = "SELECT 1 FROM Employees WHERE EmployeeID = @EmployeeID GROUP BY UserID " +
                "HAVING LEN(UserID) > 5 ";
            sqlcomm.Parameters.AddWithValue("@EmployeeID", empId);
            SqlDataReader reader = sqlcomm.ExecuteReader();
            if (reader.HasRows)
                Exists = true;
            return Exists;
        }

    }
}
