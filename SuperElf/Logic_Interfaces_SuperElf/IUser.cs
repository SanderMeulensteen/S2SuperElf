using System.Collections.Generic;

namespace Logic_Interfaces_SuperElf
{
    public interface IUser
    {
        int userId { get; }
        string userName { get; }
        string firstName { get; }
        string lastName { get; }
        string password { get; }
        string emailaddress { get; }
        bool isAdmin { get; }
        bool isModerator { get; }

        void UpdateEmail(int userId, string newEmail);
        void UpdateName(int userId, string newFirstName, string newLastName);
        void UpdatePermissions(int userId, bool isAdmin, bool isModerator);
        void UpdateUserName(int userId, string newUserName);
        void UpdatePassword(int userId, string newPassword);
        ITeam GetTeamDetailsById(int userId);
        List<IPlayer> GetPlayersFromTeam(int userId);
        int AddTeam(int userId, int formationId);
        void AddPlayersToTeam(int teamId, List<int> players);
    }
}