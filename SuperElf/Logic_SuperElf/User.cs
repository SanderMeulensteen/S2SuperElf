using System;
using System.Collections.Generic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using Logic_Interfaces_SuperElf;

namespace Logic_SuperElf
{
    public class User : IUser
    {
        private IUserDAL userDAL = UserDAL_Factory.CreateUserDal();
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

        //-----User
        // Update email in db
        public void UpdateEmail(int userId, string newEmail)
        {
            userDAL.UpdateEmail(userId, newEmail);
        }
        // Update name in db
        public void UpdateName(int userId, string newFirstName, string newLastName)
        {
            userDAL.UpdateName(userId, newFirstName, newLastName);
        }
        // Update permissions in db
        public void UpdatePermissions(int userId, bool isAdmin, bool isModerator)
        {
            userDAL.UpdatePermissions(userId, isAdmin, isModerator);
        }
        // Update username in db
        public void UpdateUserName(int userId, string newUserName)
        {
            userDAL.UpdateUserName(userId, newUserName);
        }
        // Update password in db
        public void UpdatePassword(int userId, string newPassword)
        {
            userDAL.UpdatePassword(userId, newPassword);
        }
        // Control if email is already in db
        public bool EmailCheck(string newEmail)
        {
            return userDAL.EmailCheck(newEmail);
        }
        // Control if username is already in db
        public bool UserNameCheck(string newUserName)
        {
            return userDAL.UserNameCheck(newUserName);
        }

        //----Team

    }
}
