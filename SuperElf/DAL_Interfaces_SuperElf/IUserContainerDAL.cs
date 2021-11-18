using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface IUserContainerDAL
    {
        List<UserDto> GetAllUsers();
        void AddUser(UserDto userDto);
        UserDto GetUserById(int userId);
        void DeleteUser(int userId);
        bool EmailCheck(string newEmail);
        bool UserNameCheck(string newUserName);
        UserDto LoginCheck(string emailaddress, string password);
    }
}
