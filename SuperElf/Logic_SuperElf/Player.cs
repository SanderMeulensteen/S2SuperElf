using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Player
    {
        private IPlayerDAL playerDAL = PlayerDAL_Factory.CreatePlayerDal();
        private List<PlayerDto> playersDtos = new List<PlayerDto>();
        public string playerName { get; private set; }
        public Position position { get; private set; }

        public Player(string playerName, Position position)
        {
            this.playerName = playerName;
            this.position = position;
        }
        public List<Player> GetAllPlayers()
        {
            List<Player> players = new List<Player>();
            List<PlayerDto> playerDtos = playerDAL.GetAllPlayers();
            foreach (PlayerDto playerDto in playerDtos)
            {
                players.Add(new Player(playerDto.playerName, playerDto.position));
            }
            return players;
        }
    }
}
