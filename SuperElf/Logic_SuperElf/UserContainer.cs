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
        private readonly IUserContainerDAL _userDAL = UserDAL_Factory.CreateUserContainerDal();
        // Manage users
        // Get all users from db
        public List<IUser> GetAllUsers()
        {
            List<IUser> users = new List<IUser>();
            List<UserDto> userDtos = _userDAL.GetAllUsers();
            foreach (UserDto userDto in userDtos)
            {
                users.Add(ConvertDtoToUser(userDto.userId, userDto.userName, userDto.firstName, userDto.lastName, userDto.password, userDto.emailaddress, userDto.isAdmin, userDto.isModerator, userDto.darkMode));
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
            _userDAL.AddUser(userDto);
        }
        // Get user from db by id
        public IUser GetUserById(int userId)
        {
            UserDto userDto = _userDAL.GetUserById(userId);
            IUser user = ConvertDtoToUser(userDto.userId, userDto.userName, userDto.firstName, userDto.lastName, userDto.password, userDto.emailaddress, userDto.isAdmin, userDto.isModerator, userDto.darkMode);
            return user;
        }
        // Delete user from db
        public void DeleteUser(int userId)
        {
            _userDAL.DeleteUser(userId);
        }
        // Control if email is already in db
        public bool EmailCheck(string newEmail)
        {
            return _userDAL.EmailCheck(newEmail);
        }
        // Control if username is already in db
        public bool UserNameCheck(string newUserName)
        {
            return _userDAL.UserNameCheck(newUserName);
        }
        // Control if email and password are correct
        public IUser LoginCheck(string emailaddress, string password)
        {
            UserDto userDto = _userDAL.LoginCheck(emailaddress, password);
            if (userDto == null) return null;
            
            IUser user = ConvertDtoToUser(userDto.userId, userDto.userName, userDto.firstName, userDto.lastName,
                userDto.password, userDto.emailaddress, userDto.isAdmin, userDto.isModerator, userDto.darkMode);
            return user;
        }
        // Convert dto to user
        public IUser ConvertDtoToUser(int userId, string userName, string firstName, string lastName, string password, string emailaddress, bool isAdmin, bool isModerator, bool darkMode)
        {
            User user = new User(userId, userName, firstName, lastName, password, emailaddress, isAdmin, isModerator, darkMode, PlayerDAL_Factory.CreatePlayerContainerDal());
            return user;
        }
    }
}
