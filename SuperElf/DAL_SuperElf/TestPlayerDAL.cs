using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;

namespace DAL_SuperElf
{
    public class TestPlayerDAL : IPlayerDAL, IPlayerContainerDAL
    {
        public List<PlayerDto> players = new List<PlayerDto>();
        public void UpdatePlayerName(int playerId, string newPlayerName)
        {

        }

        public void UpdatePlayerPosition(int playerId, int newPosition)
        {

        }

        public void UpdatePlayerClub(int playerId, int newClub)
        {

        }

        public List<PlayerDto> GetAllPlayers()
        {
            List<PlayerDto> playerDtos = new List<PlayerDto>();
            foreach (PlayerDto playerDto in players)
            {
                playerDtos.Add(playerDto);
            }
            return playerDtos;
        }

        public void AddPlayer(PlayerDto playerDto)
        {

        }

        public void DeletePlayer(int id)
        {

        }

        public PlayerDto GetPlayerDtoById(int playerId)
        {
            PlayerDto playerDto = new PlayerDto();

            return playerDto;
        }

        public List<PlayerDto> GetPlayersFromTeam(int teamId)
        {
            List<PlayerDto> playerDtos = new List<PlayerDto>();

            return playerDtos;
        }
        public void CreateTestPlayerDALData()
        {
            PlayerDto player1 = CreateTestPlayer(1, "keeper1",0,10);
            PlayerDto player2 = CreateTestPlayer(1, "keeper2", 0, 11);
            PlayerDto player3 = CreateTestPlayer(1, "keeper3", 0, 12);
            PlayerDto player4 = CreateTestPlayer(1, "keeper4", 0, 13);
            PlayerDto player5 = CreateTestPlayer(1, "defender1", 0, 14);
            PlayerDto player6 = CreateTestPlayer(1, "defender2", 0, 15);
            PlayerDto player7 = CreateTestPlayer(1, "defender3", 0, 16);
            PlayerDto player8 = CreateTestPlayer(1, "defender4", 0, 17);
            PlayerDto player9 = CreateTestPlayer(1, "midfielder1", 0, 18);
            PlayerDto player10 = CreateTestPlayer(1, "midfielder2", 0, 19);
            PlayerDto player11 = CreateTestPlayer(1, "midfielder3", 0, 20);
            PlayerDto player12 = CreateTestPlayer(1, "midfielder4", 0, 21);
            PlayerDto player13 = CreateTestPlayer(1, "forward1", 0, 22);
            PlayerDto player14 = CreateTestPlayer(1, "forward2", 0, 23);
            PlayerDto player15 = CreateTestPlayer(1, "forward3", 0, 24);
            PlayerDto player16 = CreateTestPlayer(1, "forward4", 0, 25);
        }
        private PlayerDto CreateTestPlayer(int playerId, string playerName, int position, int clubId)
        {
            PlayerDto player = new PlayerDto();
            player.playerId = playerId;
            player.playerName = playerName;
            player.position = position;
            player.club = clubId;
            return player;
        }
    }
}
