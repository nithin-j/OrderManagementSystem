using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using OrderManagementSystem.Business;

namespace OrderManagementSystem.DataLink
{
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
            sqlcomm.Parameters.AddWithValue("@FirstName",emp.FirstName);
            sqlcomm.Parameters.AddWithValue("@LastName",emp.LastName);
            sqlcomm.Parameters.AddWithValue("@Email",emp.Email);
            sqlcomm.Parameters.AddWithValue("@Phone",emp.Phone);
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
}
