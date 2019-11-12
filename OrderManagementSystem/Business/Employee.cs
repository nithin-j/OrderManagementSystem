using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using OrderManagementSystem.DataLink;

namespace OrderManagementSystem.Business
{
    public class Employee
    {
        private string employeeID;
        private string userID;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }

        public void AddEmployee(Employee employee)
        {
            EmployeeDB.SaveRecord(employee);
        }
        
    }
}
