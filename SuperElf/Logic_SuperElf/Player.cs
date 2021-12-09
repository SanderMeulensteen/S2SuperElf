using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;
using Logic_Interfaces_SuperElf;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Player : IPlayer
    {
        private readonly IPlayerDAL playerDAL; // = PlayerDAL_Factory.CreatePlayerDal();
        public int playerId { get; private set; }
        public string playerName { get; private set; }
        public Position position { get; private set; }
        public int club { get; private set; }
        

        public Player(int playerId, string playerName, Position position, int club, IPlayerDAL playerDAL)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.position = position;
            this.club = club;
            this.playerDAL = playerDAL;
        }
        public Player() : this(0,"",0,0, PlayerDAL_Factory.CreatePlayerDal())
        {

        }
        // Update players and manage matchrounds
        //-----Player
        // Update playername in db
        public void UpdatePlayerName(IPlayer player, string newPlayerName)
        {
            playerDAL.UpdatePlayerName(playerId, newPlayerName);
            playerName = newPlayerName;
        }

        // Update players position in db
        public void UpdatePlayerPosition(IPlayer player, int newPosition)
        {
            playerDAL.UpdatePlayerPosition(playerId, newPosition);
            position = (Position)newPosition;
        }

        // Update players club in db
        public void UpdatePlayerClub(IPlayer player, int newClub)
        {
            playerDAL.UpdatePlayerClub(playerId, newClub);
            club = newClub;
        }
    }
}
