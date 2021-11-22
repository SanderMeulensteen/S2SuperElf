using System;
using System.Collections.Generic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using Logic_Interfaces_SuperElf;
using SharedFiles;

namespace Logic_SuperElf
{
    public class User : IUser
    {
        private readonly IUserDAL userDAL = UserDAL_Factory.CreateUserDal();
        private readonly ITeamContainerDAL teamDAL = TeamDAL_Factory.CreateTeamContainerDal();
        private readonly IPlayerContainerDAL playerDAL = PlayerDAL_Factory.CreatePlayerContainerDal();
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
        public User() : this(0, "", "", "", "", "", false, false)
        {

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

        //----Team
        // Get MyTeam details by userId
        public ITeam GetTeamDetailsById(int userId)
        {
            TeamDto teamDto = teamDAL.GetTeamById(userId);
            ITeam team = ConvertDtoToTeam(teamDto.teamId, teamDto.userId, teamDto.teamFormation, teamDto.teamPoint);
            return team;
        }
        // Get players from MyTeam by userId
        public List<IPlayer> GetPlayersFromTeam(int userId)
        {
            List<IPlayer> players = new List<IPlayer>();
            int teamId = teamDAL.GetTeamIdByUserId(userId);
            List<PlayerDto> playerDtos = playerDAL.GetPlayersFromTeam(teamId);
            if (playerDtos.Count != 0)
            {
                foreach (PlayerDto playerDto in playerDtos)
                {
                    players.Add(ConvertDtoToPlayer(playerDto.playerId, playerDto.club, playerDto.position,
                        playerDto.playerName));
                }
            }
            return players;
        }
        // Convert dto to player
        public IPlayer ConvertDtoToPlayer(int playerId, int clubId, int position, string playerName)
        {
            IPlayer player = new Player(playerId, playerName, (Position) position, clubId);
            return player;
        }
        // Convert dto to team
        public ITeam ConvertDtoToTeam(int teamId, int userId, int teamFormation, int teamPoint)
        {
            ITeam team = new Team(teamId, userId, teamPoint, teamFormation);
            return team;
        }
    }
}
