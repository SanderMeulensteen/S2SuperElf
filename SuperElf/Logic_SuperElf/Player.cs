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
    public class Player
    {
        private IPlayerDAL playerDAL = PlayerDAL_Factory.CreatePlayerDal();
        public int playerId { get; private set; }
        public string playerName { get; private set; }
        public Position position { get; private set; }
        public int club { get; private set; }
        

        public Player(int playerId, string playerName, Position position, int club)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.position = position;
            this.club = club;
        }
        // Update players and manage matchrounds
        
        //-----Player
        // Update player in the db
        public void UpdatePlayer(Player player)
        {
            playerDAL.UpdatePlayer(ConvertPlayerToDto(player));
        }
        // Convert player to playerDto
        public PlayerDto ConvertPlayerToDto(Player player)
        {
            PlayerDto playerDto = new PlayerDto();
            playerDto.playerId = player.playerId;
            playerDto.playerName = player.playerName;
            playerDto.position = player.position;
            playerDto.club = player.club;
            return playerDto;
        }
    }
}
