using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;

namespace Logic_SuperElf
{
    public class User : IUser
    {
        public int userId { get; private set; }
        public string userName { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string password { get; private set; }
        public string emailaddress { get; private set; }
        public bool isAdmin { get; private set; }
        public bool isModerator { get; private set; }

        public User(int userId, string userName, string firstName, string lastName, string password, string emailaddress, bool isAdmin, bool isModerator)
        {
            this.userId = userId;
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.emailaddress = emailaddress;
            this.isAdmin = isAdmin;
            this.isModerator = isModerator;
        }
        // Update users and manage teams
    }
}
