using System;
using System.Collections.Generic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using Logic_Interfaces_SuperElf;

namespace Logic_SuperElf
{
    public class UserContainer : IUserContainer
    {
        private readonly IUserContainerDAL userDAL = UserDAL_Factory.CreateUserContainerDal();
        // Manage users
        // Get all users from db
        public List<IUser> GetAllUsers()
        {
            List<IUser> users = new List<IUser>();
            List<UserDto> userDtos = userDAL.GetAllUsers();
            foreach (UserDto userDto in userDtos)
            {
                users.Add(ConvertDtoToUser(userDto.userId, userDto.userName, userDto.firstName, userDto.lastName, userDto.password, userDto.emailaddress, userDto.isAdmin, userDto.isModerator));
            }
            return users;
        }
        // Add new user to db
        public void AddUser(string emailaddress, string userName, string firstName, string lastName, string password,
            bool isAdmin, bool isModerator)
        {
            UserDto userDto = new UserDto();
            userDto.emailaddress = emailaddress;
            userDto.userName = userName;
            userDto.firstName = firstName;
            userDto.lastName = lastName;
            userDto.password = password;
            userDto.isAdmin = isAdmin;
            userDto.isModerator = isModerator;
            userDAL.AddUser(userDto);
        }
        // Get user from db by id
        public IUser GetUserById(int userId)
        {
            UserDto userDto = userDAL.GetUserById(userId);
            IUser user = ConvertDtoToUser(userDto.userId, userDto.userName, userDto.firstName, userDto.lastName, userDto.password, userDto.emailaddress, userDto.isAdmin, userDto.isModerator);
            return user;
        }
        // Delete user from db
        public void DeleteUser(int userId)
        {
            userDAL.DeleteUser(userId);
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
        // Convert dto to user
        public IUser ConvertDtoToUser(int userId, string userName, string firstName, string lastName, string password, string emailaddress, bool isAdmin, bool isModerator)
        {
            User user = new User(userId, userName, firstName, lastName, password, emailaddress, isAdmin, isModerator);
            return user;
        }
    }
}
