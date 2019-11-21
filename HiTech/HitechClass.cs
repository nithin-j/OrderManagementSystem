using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using HiTech.Business;
using HiTech.DataLink;
using HiTech.Validation;
using System.Text.RegularExpressions;
using System.Configuration;


namespace HiTech.Business
{
    //Business
    public class Employee
    {
        private string employeeID;
        private string userID;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string role;

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Role { get => role; set => role = value; }

        public void AddEmployee(Employee employee)
        {
            EmployeeDB.SaveRecord(employee);
        }

        public List<Employee> ListEmployees()
        {
            return EmployeeDB.ListAllRecordds();
        }

        public Employee SearchEmployee(int userOption, string userInput)
        {
            return EmployeeDB.searchRecord(userOption, userInput);
        }

        public void UpdateEmployees(Employee employee)
        {
            EmployeeDB.UpdateDetails(employee);
        }

        public void DeleteEmployees(string Id)
        {
            EmployeeDB.DeleteRecords(Id);
        }

    }
    
    public class User
    {
        private static string userID;
        private static string password;
        private static int userTypeId;
        private string employeeID;

        public string UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public int UserTypeId { get => userTypeId; set => userTypeId = value; }

        public bool GetUserDetails(User user)
        {
            return UserDB.GetCredentials(user);
        }

        public int GetUserType(User user)
        {
            return UserDB.GetUserTypeID(user);
        }

        public List<String> GetAllUserTypes()
        {
            return UserDB.GetAllUserTypes();
        }

        public User GenerateUserPassword(User user)
        {
            return UserDB.GenerateAndSaveUserNamePassword(user);
        }

        public User SearchUser(string userInput)
        {
            return UserDB.SearchRecords(userInput);
        }

        public void RemoveUser(String userId)
        {
            UserDB.RemoveRecords(userId);
        }

    }

    public class UserPermissions
    {
        public List<string> GetUSerPermissions(int userTypeID)
        {
            return ManagePermissions.GetUserForms(userTypeID);
        }
    }

}

namespace HiTech.DataLink
{
    //DB
    public static class Connection
    {
        public static SqlConnection SqlConnection()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["OMSDBConnection"].ConnectionString;
            sqlconn.Open();
            return sqlconn;
        }

    }

    public static class EmployeeDB
    {
        public static void SaveRecord(Employee employee)
        {
            SqlConnection sqlconn = Connection.SqlConnection();
            String EmployeeID = RandomNumberGenerator.GenerateRandomString(5);
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = "INSERT INTO Employees(EmployeeID,FirstName,LastName,Email,Phone,UserID)" +
                                " VALUES (@EmployeeId,@FirstName,@LastName,@Email, @Phone,NEWID())";

            sqlcmd.Parameters.AddWithValue("@EmployeeId", EmployeeID);
            sqlcmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            sqlcmd.Parameters.AddWithValue("@LastName", employee.LastName);
            sqlcmd.Parameters.AddWithValue("@Email", employee.Email);
            sqlcmd.Parameters.AddWithValue("@Phone", employee.Phone);
            sqlcmd.ExecuteNonQuery();

            sqlconn.Close();
        }

        public static List<Employee> ListAllRecordds()
        {
            List<Employee> employees = new List<Employee>();
            SqlConnection sqlconn = Connection.SqlConnection();

            SqlCommand sqlcomm = new SqlCommand("EXEC GetEmployeeDetails", sqlconn);
            SqlDataReader reader = sqlcomm.ExecuteReader();
            Employee emp;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    emp = new Employee();
                    emp.EmployeeID = reader.GetString(reader.GetOrdinal("EmployeeID"));
                    emp.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                    emp.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                    emp.Email = reader.GetString(reader.GetOrdinal("Email"));
                    emp.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                    emp.Role = reader.GetString(reader.GetOrdinal("Role"));
                    emp.UserID = reader.GetString(reader.GetOrdinal("UserID"));

                    employees.Add(emp);
                }
            }
            else
                employees = null;
            sqlconn.Close();

            return employees;
        }

        public static Employee searchRecord(int userOption, string userInput)
        {
            Employee employee = new Employee();
            SqlConnection sqlconn = Connection.SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();

            switch (userOption)
            {
                case 1:
                    sqlcomm = new SqlCommand("SELECT * FROM Employees WHERE EmployeeID = \'" + userInput + "\'", sqlconn);
                    break;
                case 2:
                    sqlcomm = new SqlCommand("SELECT * FROM Employees WHERE UserID = \'" + userInput + "\'", sqlconn);
                    break;
            }

            SqlDataReader reader = sqlcomm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    employee.EmployeeID = reader.GetString(reader.GetOrdinal("EmployeeID"));
                    employee.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                    employee.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                    employee.Email = reader.GetString(reader.GetOrdinal("Email"));
                    employee.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                }
            }
            else
                employee = null;
            sqlconn.Close();

            return employee;
        }

        public static void UpdateDetails(Employee emp)
        {
            SqlConnection sqlconn = Connection.SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone WHERE EmployeeID = @EmployeeID";
            sqlcomm.Parameters.AddWithValue("@FirstName", emp.FirstName);
            sqlcomm.Parameters.AddWithValue("@LastName", emp.LastName);
            sqlcomm.Parameters.AddWithValue("@Email", emp.Email);
            sqlcomm.Parameters.AddWithValue("@Phone", emp.Phone);
            sqlcomm.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();

        }

        public static void DeleteRecords(string empID)
        {
            SqlConnection sqlconn = Connection.SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = "DELETE FROM Employees WHERE EmployeeID = @EmployeeId";
            sqlcomm.Parameters.AddWithValue("@EmployeeId", empID);
            sqlcomm.ExecuteNonQuery();

            sqlconn.Close();
        }

    }

    public static class UserDB
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
                "@EmployeeID = @Employee_ID, @Password = @Pword";
            sqlcmd.Parameters.AddWithValue("@User_Type", user.UserTypeId);
            sqlcmd.Parameters.AddWithValue("Employee_ID", user.EmployeeID);
            sqlcmd.Parameters.AddWithValue("@User_ID", RandomNumberGenerator.GenerateRandomString(5));
            sqlcmd.Parameters.AddWithValue("@Pword", RandomNumberGenerator.GenerateRandomString(15));
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

        public static User SearchRecords(string userInput)
        {
            User user = new User();
            SqlConnection sqlconn = Connection.SqlConnection();
            SqlCommand sqlcomm = new SqlCommand($"SELECT * from Users WHERE UserID = '{userInput}'", sqlconn);
            SqlDataReader reader = sqlcomm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user.UserID = reader.GetString(reader.GetOrdinal("UserID"));
                    user.UserTypeId = Convert.ToInt32(reader["UserTypeId"]);
                    user.Password = "************";
                }
            }
            else
                user = null;
            sqlconn.Close();

            return user;

        }

        public static void RemoveRecords(string userId)
        {
            SqlConnection sqlconn = Connection.SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = "EXEC RemoveUserIDPassword @UserID = @User_Id";
            sqlcomm.Parameters.AddWithValue("@User_Id", userId);
            sqlcomm.ExecuteNonQuery();

            sqlconn.Close();
        }
    }

    public static class RandomNumberGenerator
    {
        private static Random random = new Random();

        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

    public static class ManagePermissions
    {

        public static List<string> GetUserForms(int userTypeID)
        {
            List<string> AllowedForms = new List<string>();
            SqlConnection sqlconn = Connection.SqlConnection();
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = "SELECT UserForms FROM UserPermissions WHERE UserTypeID = @UserTypeID";
            sqlcomm.Parameters.AddWithValue("@UserTypeID", userTypeID);
            SqlDataReader reader = sqlcomm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AllowedForms.Add(reader.GetString(reader.GetOrdinal("UserForms")));
                }
            }
            return AllowedForms;
        }
    }
}

namespace HiTech.Validation
{
    //Validation
    public class Validator
    {
        public static bool IsValidID(string input)
        {
            string error = "Invalid UserID. \nPlease verify you User ID and try again or contact your MIS Manager";

            if (!Regex.IsMatch(input, @"^[a-zA-Z0-9]{5}$"))
            {
                MessageBox.Show(error, "Invalid UserID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool IsValidPassword(string input)
        {
            string error = "Invalid Password. \nPlease verify your Password and try again or contact your admin";

            if (!Regex.IsMatch(input, @"^[^.](?!.*[.]{2})[a-zA-Z0-9.!#$%&’'*+/=?^_`{|}~-]{8,16}[^.]+$"))
            {
                MessageBox.Show(error, "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
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

