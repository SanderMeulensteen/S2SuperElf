using System.Collections.Generic;

namespace Logic_Interfaces_SuperElf
{
    public interface IUserContainer
    {
        List<IUser> GetAllUsers();
        void AddUser(string emailaddress, string userName, string firstName, string lastName, string password, bool isAdmin, bool isModerator);
        IUser GetUserById(int userId);
        void DeleteUser(int userId);
    }
}