using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DAL_Interfaces_SuperElf;

namespace UnitTest_SuperElf
{
    public class TestPlayerDAL : IPlayerDAL, IPlayerContainerDAL
    {
        public List<PlayerDto> testPlayers = CreateTestPlayerDALData();
        public void UpdatePlayerName(int playerId, string newPlayerName)
        {
            testPlayers.Find(x => x.playerId == playerId).playerName = newPlayerName;
        }

        public void UpdatePlayerPosition(int playerId, int newPosition)
        {
            testPlayers.Find(x => x.playerId == playerId).position = newPosition;
        }

        public void UpdatePlayerClub(int playerId, int newClub)
        {
            testPlayers.Find(x => x.playerId == playerId).club = newClub;
        }

        public List<PlayerDto> GetAllPlayers()
        {
            List<PlayerDto> playerDtos = new List<PlayerDto>();
            foreach (PlayerDto playerDto in testPlayers)
            {
                playerDtos.Add(playerDto);
            }
            return playerDtos;
        }

        public void AddPlayer(PlayerDto playerDto)
        {
            testPlayers.Add(playerDto);
        }

        public void DeletePlayer(int id)
        {
            testPlayers.RemoveAll(x => x.playerId == id);
        }

        public PlayerDto GetPlayerDtoById(int playerId)
        {
            PlayerDto playerDto = testPlayers.Find(x => x.playerId == playerId);
            return playerDto;
        }

        public List<PlayerDto> GetPlayersFromTeam(int teamId)
        {
            List<int> playerIds = GetPlayerIdsFromTeamId(teamId);
            List<PlayerDto> playerDtos = new List<PlayerDto>();
            foreach (int playerId in playerIds)
            {
                PlayerDto player = testPlayers.Find(x =>x.playerId == playerId);
				playerDtos.Add(player);
            }
            return playerDtos;
        }

        public static List<PlayerDto> CreateTestPlayerDALData()
        {
            List<PlayerDto> players = new List<PlayerDto>();
            players.Add(CreateTestPlayer(1, "keeper1", 0, 1));
            players.Add(CreateTestPlayer(2, "keeper2", 0, 2));
            players.Add(CreateTestPlayer(3, "keeper3", 0, 3));
            players.Add(CreateTestPlayer(4, "keeper4", 0, 16));
            players.Add(CreateTestPlayer(5, "defender1", 1, 1));
            players.Add(CreateTestPlayer(6, "defender2", 1, 2));
            players.Add(CreateTestPlayer(7, "defender3", 1, 3));
            players.Add(CreateTestPlayer(8, "defender4", 1, 16));
            players.Add(CreateTestPlayer(9, "midfielder1", 2, 1));
            players.Add(CreateTestPlayer(10, "midfielder2", 2, 2));
            players.Add(CreateTestPlayer(11, "midfielder3", 2, 3));
            players.Add(CreateTestPlayer(12, "midfielder4", 2, 16));
            players.Add(CreateTestPlayer(13, "forward1", 3, 1));
            players.Add(CreateTestPlayer(14, "forward2", 3, 2));
            players.Add(CreateTestPlayer(15, "forward3", 3, 3));
            players.Add(CreateTestPlayer(16, "forward4", 3, 16));
            return players;
        }
        private static PlayerDto CreateTestPlayer(int playerId, string playerName, int position, int clubId)
        {
            PlayerDto player = new PlayerDto();
            player.playerId = playerId;
            player.playerName = playerName;
            player.position = position;
            player.club = clubId;
            return player;
        }
        private List<int> GetPlayerIdsFromTeamId(int teamId)
        {
            List<int> players = new List<int>();
                players.Add(1);
                players.Add(5);
                players.Add(6);
                players.Add(7);
                players.Add(8);
                players.Add(9);
                players.Add(10);
                players.Add(11);
                players.Add(13);
                players.Add(14);
                players.Add(15);
            return players;
        }
    }
}
