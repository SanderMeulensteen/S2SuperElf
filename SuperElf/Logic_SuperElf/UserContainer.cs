using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;

namespace Logic_SuperElf
{
    public class UserContainer : IUserContainer
    {
        // Manage users
        // Get all users from db
        public List<IUser> GetAllUsers()
        {
            List<IUser> users = new List<IUser>();
            IUser user = new User(1, "Sanderfjord Fotball", "Sander", "Meulensteen", "123",
                "sandermeulensteen@hotmail.com", true, false);
            users.Add(user);
            return users;
        }
    }
}
