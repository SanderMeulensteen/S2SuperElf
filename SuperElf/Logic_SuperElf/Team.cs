using System;
using System.Collections.Generic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Team
    {
        private IPlayerDAL playerDAL = PlayerDAL_Factory.CreatePlayerDal();
        private ClubContainer clubContainer = new ClubContainer();
        public int teamPoint { get; private set; }
        public Formation teamFormation { get; private set; }
        public Competition teamCompetition { get; private set; }

        public Team(int teamPoint, Formation teamFormation, Competition teamCompetition)
        {
            this.teamPoint = teamPoint;
            this.teamFormation = teamFormation;
            this.teamCompetition = teamCompetition;
        }
        
        // Add player to db
        public void AddPlayer(Player player)
        {
            PlayerDto playerDto = ConvertPlayerToDto(player);
            playerDAL.AddPlayer(playerDto);
        }
        // Convert player to playerDto
        public PlayerDto ConvertPlayerToDto(Player player)
        {
            List<ClubDto> clubDtos = clubContainer.GetAllClubDtos();
            PlayerDto playerDto = new PlayerDto();
            playerDto.playerName = player.playerName;
            playerDto.position = player.position;
            foreach (ClubDto clubDto in clubDtos)
            {
                if (clubDto.clubName == player.club)
                {
                    playerDto.club = clubDto.clubId;
                }
            }
            return playerDto;
        }
    }
}
