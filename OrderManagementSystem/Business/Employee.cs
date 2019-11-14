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
}
