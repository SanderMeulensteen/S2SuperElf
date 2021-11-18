using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface IUserDAL
    {
        void UpdateEmail(int userId, string newEmail);
        void UpdateName(int userId, string newFirstName, string newLastName);
        void UpdatePermissions(int userId, bool isAdmin, bool isModerator);
        void UpdateUserName(int userId, string newUserName);
        void UpdatePassword(int userId, string newPassword);
        bool EmailCheck(string newEmail);
        bool UserNameCheck(string newUserName);
    }
}
