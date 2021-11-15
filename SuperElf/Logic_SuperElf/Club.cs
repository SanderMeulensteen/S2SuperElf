using System;
using System.Collections.Generic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Club
    {
        private IPlayerContainerDAL playerDAL = PlayerDAL_Factory.CreatePlayerContainerDal();
        public int clubId { get; set; }
        public string clubName { get; private set; }
        public int competition { get; private set; }

        public Club(int clubId, string clubName, int competition)
        {
            this.clubId = clubId;
            this.clubName = clubName;
            this.competition = competition;
        }
        // Update clubs and manage players

        //-----Club


        //-----Player
        // Add player to db
        public void AddPlayer(Player player)
        {
            PlayerDto playerDto = ConvertPlayerToDto(player);
            
            playerDAL.AddPlayer(playerDto);
        }

        // Get list of all players in db
        public List<Player> GetAllPlayers()
        {
            List<Player> players = new List<Player>();
            List<PlayerDto> playerDtos = playerDAL.GetAllPlayers();

            foreach (PlayerDto playerDto in playerDtos)
            {
                players.Add(ConvertDtoToPlayer(playerDto));
            }
            return players;
        }

        // Delete player from db
        public void DeletePlayer(int playerId)
        {
            playerDAL.DeletePlayer(playerId);
        }

        public Player GetPlayerById(int id)
        {
            PlayerDto playerDto = playerDAL.GetPlayerDtoById(id);
            Player player = ConvertDtoToPlayer(playerDto);
            return player;
        }

        // Convert playerDto to player
        public Player ConvertDtoToPlayer(PlayerDto playerDto)
        {
            Player player = new Player(playerDto.playerId, playerDto.playerName, playerDto.position, playerDto.club);
            return player;
        }

        // Convert player to playerDto
        public PlayerDto ConvertPlayerToDto(Player player)
        {
            PlayerDto playerDto = new PlayerDto();
            playerDto.playerName = player.playerName;
            playerDto.position = player.position;
            playerDto.club = player.club;
            return playerDto;
        }
    }
}
