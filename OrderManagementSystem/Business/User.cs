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

        public string UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }

        public bool GetUserDetails(User user)
        {
            return UserDB.GetCredentials(user);
        }

    }
}
