using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OrderManagementSystem.DataLink;

namespace OrderManagementSystem.Business
{
    public class User
    {
        private string userID;
        private string password;
        private int userTypeId;
        private string employeeID;

        public string UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
        public int UserTypeId { get => userTypeId; set => userTypeId = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }

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

    }
}
