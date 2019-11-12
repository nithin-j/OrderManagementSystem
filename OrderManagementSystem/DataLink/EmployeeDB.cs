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

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = "INSERT INTO Employees(EmployeeID,FirstName,LastName,Email,Phone)" +
                                " VALUES (@EmployeeId,@FirstName,@LastName,@Email, @Phone)";

            sqlcmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeID);
            sqlcmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            sqlcmd.Parameters.AddWithValue("@LastName", employee.LastName);
            sqlcmd.Parameters.AddWithValue("@Email", employee.Email);
            sqlcmd.Parameters.AddWithValue("@Phone", employee.Phone);
            sqlcmd.ExecuteNonQuery();
            
            sqlconn.Close();
        }
    }
}
