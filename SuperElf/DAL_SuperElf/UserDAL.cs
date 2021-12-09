using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using Microsoft.Data.SqlClient;

namespace DAL_SuperElf
{
    public class UserDAL : IUserDAL, IUserContainerDAL
    {
        private string connectionString =
            "Data Source=mssql.fhict.local;Persist Security Info=True;User ID = dbi449009_superelf; Password=!t5AC13791K";
        // Get all user from db
        public List<UserDto> GetAllUsers()
        {
            List<UserDto> users = new List<UserDto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand query = new SqlCommand("select * from userTable", conn))
                {
                    conn.Open();
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        UserDto user = new UserDto();
                        user.userId = reader.GetInt32(0);
                        user.emailaddress = reader.GetString(1);
                        user.userName = reader.GetString(2);
                        user.firstName = reader.GetString(3);
                        user.lastName = reader.GetString(4);
                        user.password = reader.GetString(5);
                        user.isAdmin = reader.GetBoolean(6);
                        user.isModerator = reader.GetBoolean(7);
                        user.darkMode = reader.GetBoolean(8);
                        users.Add(user);
                    }
                }
            }
            return users;
        }
        // Add new user to db
        public void AddUser(UserDto user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query =
                    "INSERT INTO [dbo].[userTable]([EmailAddress],[UserName],[FirstName],[LastName],[Password],[IsAdmin],[IsModerator],[DarkMode])VALUES(@EmailAddress,@UserName,@FirstName,@LastName,@Password,@IsAdmin,@IsModerator,@DarkMode)";
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@EmailAddress", user.emailaddress);
                    sqlCommand.Parameters.AddWithValue("@UserName", user.userName);
                    sqlCommand.Parameters.AddWithValue("@FirstName", user.firstName);
                    sqlCommand.Parameters.AddWithValue("@Lastname", user.lastName);
                    sqlCommand.Parameters.AddWithValue("@Password", user.password);
                    sqlCommand.Parameters.AddWithValue("@IsAdmin", user.isAdmin);
                    sqlCommand.Parameters.AddWithValue("@IsModerator", user.isModerator);
                    sqlCommand.Parameters.AddWithValue("@DarkMode", user.darkMode);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        // Get user from db by id
        public UserDto GetUserById(int userId)
        {
            UserDto user = new UserDto();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("select * from userTable where UserId = @Id", conn))
                {
                    query.Parameters.AddWithValue("@Id", userId);
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        user.userId = reader.GetInt32(0);
                        user.emailaddress = reader.GetString(1);
                        user.userName = reader.GetString(2);
                        user.firstName = reader.GetString(3);
                        user.lastName = reader.GetString(4);
                        user.password = reader.GetString(5);
                        user.isAdmin = reader.GetBoolean(6);
                        user.isModerator = reader.GetBoolean(7);
                        user.darkMode = reader.GetBoolean(8);
                    }
                }
            }
            return user;
        }
        // delete user from db
        public void DeleteUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                int teamId = 0;
                using (SqlCommand queryGet = new SqlCommand("select * from teamTable where UserId = @userId", conn))
                {
                    conn.Open();
                    queryGet.Parameters.AddWithValue("@userId", userId);
                    var reader = queryGet.ExecuteReader();
                    while (reader.Read())
                    {
                        teamId = reader.GetInt32(0);
                    }
                    conn.Close();
                }
                if (teamId == 0)
                {
                    conn.Open();
                    using (SqlCommand query =
                        new SqlCommand("DELETE FROM [dbo].[userTable] WHERE UserId = @userId", conn))
                    {
                        query.Parameters.AddWithValue("@userId", userId);
                        query.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    using (SqlCommand query1 =
                        new SqlCommand("DELETE FROM [dbo].[teamTable] WHERE UserId = @userId", conn))
                    {
                        query1.Parameters.AddWithValue("@userId", userId);
                        using (SqlCommand query2 =
                            new SqlCommand("DELETE FROM [dbo].[userTable] WHERE UserId = @userId", conn))
                        {
                            query2.Parameters.AddWithValue("@userId", userId);
                            using (SqlCommand query3 = new SqlCommand("DELETE FROM [dbo].[player_teamTable] WHERE TeamId = @teamId", conn))
                            {
                                query3.Parameters.AddWithValue("@teamId", teamId);
                                query3.ExecuteNonQuery();
                                query1.ExecuteNonQuery();
                                query2.ExecuteNonQuery();
                            }
                        }
                    }
                    conn.Close();
                }
            }
        }
        // Update email in db
        public void UpdateEmail(int userId, string newEmail)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[userTable] SET[EmailAddress] = @email WHERE UserId = @userId", conn))
                {
                    query.Parameters.AddWithValue("@userId", userId);
                    query.Parameters.AddWithValue("@email", newEmail);
                    query.ExecuteNonQuery();
                }
            }
        }
        // Update names in db
        public void UpdateName(int userId, string newFirstName, string newLastName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[userTable] SET[FirstName] = @firstName, [LastName] = @lastName WHERE UserId = @userId", conn))
                {
                    query.Parameters.AddWithValue("@userId", userId);
                    query.Parameters.AddWithValue("@firstName", newFirstName);
                    query.Parameters.AddWithValue("@lastName", newLastName);
                    query.ExecuteNonQuery();
                }
            }
        }
        // Update permissions in db
        public void UpdatePermissions(int userId, bool isAdmin, bool isModerator)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[userTable] SET[IsAdmin] = @admin, [IsModerator] = @moderator WHERE UserId = @userId", conn))
                {
                    query.Parameters.AddWithValue("@userId", userId);
                    query.Parameters.AddWithValue("@admin", isAdmin);
                    query.Parameters.AddWithValue("@moderator", isModerator);
                    query.ExecuteNonQuery();
                }
            }
        }
        // Update username in db
        public void UpdateUserName(int userId, string newUserName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[userTable] SET[UserName] = @userName WHERE UserId = @userId", conn))
                {
                    query.Parameters.AddWithValue("@userId", userId);
                    query.Parameters.AddWithValue("@userName", newUserName);
                    query.ExecuteNonQuery();
                }
            }
        }
        // Update darkmode in db
        public void UpdateDarkMode(int userId, bool darkMode)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[userTable] SET[DarkMode] = @darkMode WHERE UserId = @userId", conn))
                {
                    query.Parameters.AddWithValue("@userId", userId);
                    query.Parameters.AddWithValue("@darkMode", darkMode);
                    query.ExecuteNonQuery();
                }
            }
        }
        // Update password in db
        public void UpdatePassword(int userId, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[userTable] SET[Password] = @password WHERE UserId = @userId", conn))
                {
                    query.Parameters.AddWithValue("@userId", userId);
                    query.Parameters.AddWithValue("@password", newPassword);
                    query.ExecuteNonQuery();
                }
            }
        }
        // Control if email already in db
        public bool EmailCheck(string newEmail)
        {
            int user = -1;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("select * from userTable where EmailAddress = @email", conn))
                {
                    query.Parameters.AddWithValue("@email", newEmail);
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        user = reader.GetInt32(0);
                    }
                }
            }
            if (user < 0)
            {
                return true;
            }
            return false;
        }
        // Control if username already in db
        public bool UserNameCheck(string newUserName)
        {
            int user = -1;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("select * from userTable where UserName = @userName", conn))
                {
                    query.Parameters.AddWithValue("@userName", newUserName);
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        user = reader.GetInt32(0);
                    }
                }
            }
            if (user < 0)
            {
                return true;
            }
            return false;
        }
        public UserDto LoginCheck(string emailaddress, string password)
        {
            UserDto user = new UserDto();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("select * from userTable where EmailAddress = @email", conn))
                {
                    query.Parameters.AddWithValue("@email", emailaddress);
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        user.userId = reader.GetInt32(0);
                        user.emailaddress = reader.GetString(1);
                        user.userName = reader.GetString(2);
                        user.firstName = reader.GetString(3);
                        user.lastName = reader.GetString(4);
                        user.password = reader.GetString(5);
                        user.isAdmin = reader.GetBoolean(6);
                        user.isModerator = reader.GetBoolean(7);
                        user.darkMode = reader.GetBoolean(8);
                    }
                }
            }
            if (user.password == password)
            {
                return user;
            }
            return null;
        }
    }
}
