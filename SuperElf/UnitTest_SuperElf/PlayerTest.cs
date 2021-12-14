using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using DAL_SuperElf;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedFiles;

namespace UnitTest_SuperElf
{
    [TestClass]
    public class PlayerTest
    {
        private static TestPlayerDAL _playerDAL = new TestPlayerDAL();
        private readonly Club club = new Club(0,"",0,_playerDAL);
        private readonly User user = new User(0,"","","","","",false,false,false,_playerDAL);

        [TestMethod]
        public void Player_Can_Be_Added_To_MockDB()
        {
            // Arrange
            int expectedPlayerCount = club.GetAllPlayers().Count + 1;
            Player newPlayer = new Player(20,"newPlayer",0,3, new TestPlayerDAL());
            // Act
            club.AddPlayer(newPlayer.playerId, newPlayer.playerName, (int)newPlayer.position, newPlayer.club);
            // Assert
            Assert.AreEqual(expectedPlayerCount, club.GetAllPlayers().Count);
        }
        [TestMethod]
        public void Player_Can_Be_Deleted_From_MockDB()
        {
            // Arrange
            int expectedPlayerCount = club.GetAllPlayers().Count - 1;
            int playerId = 10;
            // Act
            club.DeletePlayer(playerId);
            // Assert
            Assert.AreEqual(expectedPlayerCount, club.GetAllPlayers().Count);
        }
        [TestMethod]
        public void Get_All_Players_From_MockDB()
        {
            // Arrange

            // Act
            List<IPlayer> players = club.GetAllPlayers();
            // Assert
            Assert.AreEqual(16, players.Count);
        }
        [TestMethod]
        public void Get_Player_From_MockDB_By_PlayerId()
        {
            // Arrange
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
            int playerId = 8;
            IPlayer iPlayer = club.GetPlayerById(playerId);
            string newPlayerName = "newName";
            Player player = new Player(iPlayer.playerId, iPlayer.playerName, iPlayer.position, iPlayer.club, _playerDAL);
            //Act
            player.UpdatePlayerName(player, newPlayerName);
            // Assert
            Assert.AreEqual(newPlayerName, club.GetPlayerById(playerId).playerName);
        }
        [TestMethod]
        public void Update_Position_In_MockDB()
        {
            // Arrange
            int playerId = 8;
            IPlayer iPlayer = club.GetPlayerById(playerId);
            int newPosition = 3;
            Player player = new Player(iPlayer.playerId, iPlayer.playerName, iPlayer.position, iPlayer.club, _playerDAL);
            // Act
            player.UpdatePlayerPosition(player, newPosition);
            // Assert
            Assert.AreEqual(Position.Forward, club.GetPlayerById(player.playerId).position);
        }
        [TestMethod]
        public void Update_Club_In_MockDB()
        {
            // Arrange
            int playerId = 8;
            IPlayer iPlayer = club.GetPlayerById(playerId);
            int newClub = 2;
            Player player = new Player(iPlayer.playerId, iPlayer.playerName, iPlayer.position, iPlayer.club, _playerDAL);
            // Act
            player.UpdatePlayerClub(player, newClub);
			// Assert
            Assert.AreEqual(newClub, club.GetPlayerById(player.playerId).club);
        }
    }
}
