using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;
using Logic_Interfaces_SuperElf;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Club : IClub
    {
        private IPlayerContainerDAL playerDAL = PlayerDAL_Factory.CreatePlayerContainerDal();
        private IClubDAL clubDAL = ClubDAL_Factory.CreateClubDal();
        public int clubId { get; private set; }
        public string clubName { get; private set; }
        public int competitionId { get; private set; }

        public Club(int clubId, string clubName, int competition)
        {
            this.clubId = clubId;
            this.clubName = clubName;
            this.competitionId = competition;
        }
        public Club() : this(0,"",0)
        {

        }
        // Update clubs and manage players

        //-----Club
        // Update clubname in db
        public void UpdateClubName(int clubId, string newClubName)
        {
            clubDAL.UpdateClubName(clubId, newClubName);
        }
        // Update competition in db
        public void UpdateCompetition(int clubId, int newCompetition)
        {
            clubDAL.UpdateCompetition(clubId, newCompetition);
        }

        //-----Player
        // Add player to db
        public void AddPlayer(int playerId, string playerName, int position, int club)
        {
            PlayerDto playerDto = new PlayerDto();
            playerDto.playerName = playerName;
            playerDto.position = position;
            playerDto.club = club;
            playerDAL.AddPlayer(playerDto);
        }

        // Get list of all players in db
        public List<IPlayer> GetAllPlayers()
        {
            List<IPlayer> players = new List<IPlayer>();
            List<PlayerDto> playerDtos = playerDAL.GetAllPlayers();
            foreach (PlayerDto playerDto in playerDtos)
            {
                players.Add(ConvertDtoToPlayer(playerDto.playerId, playerDto.playerName, playerDto.position, playerDto.club));
            }
            return players;
        }
        // Delete player from db
        public void DeletePlayer(int playerId)
        {
            playerDAL.DeletePlayer(playerId);
        }
        // Get playerdetails from db by id
        public IPlayer GetPlayerById(int playerId)
        {
            PlayerDto playerDto = playerDAL.GetPlayerDtoById(playerId);
            IPlayer player = ConvertDtoToPlayer(playerDto.playerId, playerDto.playerName, playerDto.position, playerDto.club);
            return player;
        }
        // Convert playerDto to player
        public IPlayer ConvertDtoToPlayer(int playerId, string playerName, int position, int club)
        {
            Player player = new Player(playerId, playerName, (Position) position, club);
            return player;
        }
        // Get all keepers from db
        public List<IPlayer> GetAllKeepers()
        {
            List<PlayerDto> allPlayers = playerDAL.GetAllPlayers();
            List<IPlayer> keepers = new List<IPlayer>();
            foreach (PlayerDto player in allPlayers)
            {
                if (player.position == 0)
                {
                    keepers.Add(ConvertDtoToPlayer(player.playerId, player.playerName, player.position, player.club));
                }
            }
            return keepers;
        }
        // Get all Defenders from db
        public List<IPlayer> GetAllDefenders()
        {
            List<PlayerDto> allPlayers = playerDAL.GetAllPlayers();
            List<IPlayer> defenders = new List<IPlayer>();
            foreach (PlayerDto player in allPlayers)
            {
                if (player.position == 1)
                {
                    defenders.Add(ConvertDtoToPlayer(player.playerId, player.playerName, player.position, player.club));
                }
            }
            return defenders;
        }
        // Get all midfielders from db
        public List<IPlayer> GetAllMidfielders()
        {
            List<PlayerDto> allPlayers = playerDAL.GetAllPlayers();
            List<IPlayer> midfielders = new List<IPlayer>();
            foreach (PlayerDto player in allPlayers)
            {
                if (player.position == 2)
                {
                    midfielders.Add(ConvertDtoToPlayer(player.playerId, player.playerName, player.position, player.club));
                }
            }
            return midfielders;
        }
        // Get all forwards from db
        public List<IPlayer> GetAllForwards()
        {
            List<PlayerDto> allPlayers = playerDAL.GetAllPlayers();
            List<IPlayer> forwards = new List<IPlayer>();
            foreach (PlayerDto player in allPlayers)
            {
                if (player.position == 3)
                {
                    forwards.Add(ConvertDtoToPlayer(player.playerId, player.playerName, player.position, player.club));
                }
            }
            return forwards;
        }
    }
}
