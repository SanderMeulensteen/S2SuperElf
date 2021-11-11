using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_SuperElf
{
    public class User
    {
        public string userName { get; private set; }
        public string password { get; private set; }
        public string email { get; private set; }

        public User(string userName, string password, string email)
        {
            this.userName = userName;
            this.password = password;
            this.email = email;
        }
        // Update users and manage teams
    }
}
