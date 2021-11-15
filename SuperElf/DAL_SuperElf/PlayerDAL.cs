using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using Microsoft.Data.SqlClient;
using SharedFiles;

namespace DAL_SuperElf
{
    public class PlayerDAL : IPlayerDAL, IPlayerContainerDAL
    {
        private string connectionString =
            "Data Source=mssql.fhict.local;Persist Security Info=True;User ID = dbi449009_superelf; Password=!t5AC13791K";
        
        // Get list of all players from db
        public List<PlayerDto> GetAllPlayers()
        {
            List<PlayerDto> players = new List<PlayerDto>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand query = new SqlCommand("select * from playerTable", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        PlayerDto player = new PlayerDto();
                        player.playerId = reader.GetInt32(0);
                        player.playerName = reader.GetString(2);
                        player.position = (Position)reader.GetInt32(3);
                        player.club = reader.GetInt32(1);
                        players.Add(player);
                    }
                }
            }
            return players;
        }

        // Add player to db
        public void AddPlayer(PlayerDto player)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query =
                    "INSERT INTO [dbo].[playerTable]([ClubId],[PlayerName],[Position]) VALUES(@clubId,@playerName,@position)";
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@clubId", player.club);
                    sqlCommand.Parameters.AddWithValue("@playerName", player.playerName);
                    sqlCommand.Parameters.AddWithValue("@position", player.position);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        // Get player details from id
        public PlayerDto GetPlayerDtoById(int playerId)
        {
            PlayerDto playerDto = new PlayerDto();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("select * from playerTable where PlayerId = @Id", conn))
                {
                    query.Parameters.AddWithValue("@Id", playerId);

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        playerDto.playerId = reader.GetInt32(0);
                        playerDto.playerName = reader.GetString(2);
                        playerDto.position = (Position)reader.GetInt32(3);
                        playerDto.club = reader.GetInt32(1);
                    }
                }
            }
            return playerDto;
        }

        // Delete player from db
        public void DeletePlayer(int playerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("DELETE FROM [dbo].[playerTable] WHERE playerId = @playerId", conn))
                {
                    query.Parameters.AddWithValue("@playerId", playerId);
                    query.ExecuteNonQuery();
                }
            }
        }
        // Update playername in db
        public void UpdatePlayerName(int playerId, string newPlayerName)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[playerTable] SET[PlayerName] = @playerName WHERE playerId = @playerId", conn))
                {
                    query.Parameters.AddWithValue("@playerId", playerId);
                    query.Parameters.AddWithValue("@playerName", newPlayerName);
                    query.ExecuteNonQuery();
                }
            }
        }
        // Update players position in db
        public void UpdatePlayerPosition(int playerId, int newPosition)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[playerTable] SET[Position] = @position WHERE playerId = @playerId", conn))
                {
                    query.Parameters.AddWithValue("@playerId", playerId);
                    query.Parameters.AddWithValue("@position", newPosition);
                    query.ExecuteNonQuery();
                }
            }
        }
        // Update players club in db
        public void UpdatePlayerClub(int playerId, int newClub)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[playerTable] SET[ClubId] = @clubId WHERE playerId = @playerId", conn))
                {
                    query.Parameters.AddWithValue("@playerId", playerId);
                    query.Parameters.AddWithValue("@clubId", newClub);
                    query.ExecuteNonQuery();
                }
            }
        }
    }
}

