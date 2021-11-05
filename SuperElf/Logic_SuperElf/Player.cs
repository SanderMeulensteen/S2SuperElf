using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;
using SharedFiles;
// using Logic_Interfaces_SuperElf;

namespace Logic_SuperElf
{
    public class Player // : IPlayer
    {
        private IPlayerDAL playerDAL = PlayerDAL_Factory.CreatePlayerDal();
        private IClubDAL clubDAL = ClubDAL_Factory.CreateClubDal();
        private List<PlayerDto> playersDtos = new List<PlayerDto>();
        public string playerName { get; private set; }
        public Position position { get; private set; }
        public string club { get; private set; }
        

        public Player(string playerName, Position position, string club)
        {
            this.playerName = playerName;
            this.position = position;
            this.club = club;
        }
        public List<Player> GetAllPlayers()
        {
            List<Player> players = new List<Player>();
            List<PlayerDto> playerDtos = playerDAL.GetAllPlayers();
            List<ClubDto> clubDtos = clubDAL.GetAllClubs();
            
            foreach (PlayerDto playerDto in playerDtos)
            {
                string clubName = null;
                foreach (ClubDto clubDto in clubDtos)
                {
                    if (clubDto.clubId == playerDto.club)
                    {
                        clubName = clubDto.clubName;
                    }
                }
                if (clubName != null)
                {
                    players.Add(new Player(playerDto.playerName, playerDto.position, clubName));
                }
            }
            return players;
        }
    }
}
