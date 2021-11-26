using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using DAL_Interfaces_SuperElf;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedFiles;

namespace UnitTest_SuperElf
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void Player_Can_Be_Added_To_MockDB()
        {
            // Arrange
            Player newPlayer = new Player(20,"newPlayer",0,3);
            Club club = new Club();
            // Act
            club.AddPlayer(newPlayer.playerId, newPlayer.playerName, (int)newPlayer.position, newPlayer.club);
            // Assert
            Assert.AreEqual(17, club.GetAllPlayers().Count);
        }
        [TestMethod]
        public void Player_Can_Be_Deleted_From_MockDB()
        {
            // Arrange
            Club club = new Club();
            int playerId = 10;
            // Act
            club.DeletePlayer(playerId);
            // Assert
            Assert.AreEqual(15, club.GetAllPlayers().Count);
        }
        [TestMethod]
        public void Get_All_Players_From_MockDB()
        {
            // Arrange
            Club club = new Club();
            // Act
            List<IPlayer> players = club.GetAllPlayers();
            // Assert
            Assert.AreEqual(16, players.Count);
        }
        [TestMethod]
        public void Get_Player_From_MockDB_By_PlayerId()
        {
            // Arrange
            Club club = new Club();
            int playerId = 11;
            // Act
            IPlayer playerById = club.GetPlayerById(playerId);
            // Assert
            Assert.AreEqual(playerId ,playerById.playerId);
            Assert.AreEqual("midfielder3", playerById.playerName);
            Assert.AreEqual(Position.Midfielder, playerById.position);
            Assert.AreEqual(3, playerById.club);
        }
        [TestMethod]
        public void Update_PlayerName_In_MockDB()
        {
            // Arrange
            Club club = new Club();
            int playerId = 8;
            IPlayer player = club.GetPlayerById(playerId);
            string newPlayerName = "newName";
            // Act
            player.UpdatePlayerName(player, newPlayerName);
            string updatedName = player.playerName;
            // Assert
            Assert.AreEqual(newPlayerName, updatedName);
        }
        [TestMethod]
        public void Update_Position_In_MockDB()
        {
            // Arrange
            Club club = new Club();
            int playerId = 8;
            IPlayer player = club.GetPlayerById(playerId);
            int newPosition = 3;
            // Act
            player.UpdatePlayerPosition(player, newPosition);
            Position updatedPosition = player.position;
            // Assert
            Assert.AreEqual(Position.Forward, updatedPosition);
        }
        [TestMethod]
        public void Update_Club_In_MockDB()
        {
            // Arrange
            Club club = new Club();
            int playerId = 8;
            IPlayer player = club.GetPlayerById(playerId);
            int newClub = 2;
            // Act
            player.UpdatePlayerClub(player, newClub);
            int updatedClub = player.club;
            // Assert
            Assert.AreEqual(newClub, updatedClub);
        }
        [TestMethod]
        public void Get_My_Team_From_DB()
        {
            // Arrange
            User user = new User();
            int teamId = 1;
            // Act
            List<IPlayer> myTeam = user.GetPlayersFromTeam(teamId);
            // Assert
            Assert.AreEqual(11, myTeam.Count);
        }
    }
}
