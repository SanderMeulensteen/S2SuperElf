﻿using System;
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
        // Interface for web application
        // private readonly IPlayerDAL playerDAL = PlayerDAL_Factory.CreatePlayerDal();
        // Interface for testing
        private readonly IPlayerDAL playerDAL = PlayerDAL_Factory.CreateTestPlayerDal();
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
        public Player() : this(0,"",0,0)
        {

        }
        // Update players and manage matchrounds
        //-----Player
        // Update playername in db
        public void UpdatePlayerName(IPlayer player, string newPlayerName)
        {
            playerDAL.UpdatePlayerName(player.playerId, newPlayerName);
        }

        // Update players position in db
        public void UpdatePlayerPosition(IPlayer player, int newPosition)
        {
            playerDAL.UpdatePlayerPosition(player.playerId, newPosition);
        }

        // Update players club in db
        public void UpdatePlayerClub(IPlayer player, int newClub)
        {
            playerDAL.UpdatePlayerClub(player.playerId, newClub);
        }
    }
}
