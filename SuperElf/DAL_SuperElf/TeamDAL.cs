using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using Microsoft.Data.SqlClient;

namespace DAL_SuperElf
{
    public class TeamDAL : ITeamDAL, ITeamContainerDAL
    {
        private string connectionString =
            "Data Source=mssql.fhict.local;Persist Security Info=True;User ID = dbi449009_superelf; Password=!t5AC13791K";

        // Get team from db by id
        public TeamDto GetTeamById(int userId)
        {
            TeamDto teamDto = new TeamDto();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("select * from teamTable where UserId = @userId", conn))
                {
                    query.Parameters.AddWithValue("@userId", userId);
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        teamDto.teamId = reader.GetInt32(0);
                        teamDto.userId = reader.GetInt32(1);
                        teamDto.teamFormation = reader.GetInt32(2);
                        teamDto.teamPoint = reader.GetInt32(3);
                    }
                }
            }

            return teamDto;
        }

        // Get teamId from userId
        public int GetTeamIdByUserId(int userId)
        {
            int teamId = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("select * from teamTable where UserId = @userId", conn))
                {
                    query.Parameters.AddWithValue("@userId", userId);
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        teamId = reader.GetInt32(0);
                    }
                }
            }
            return teamId;
        }

        // Create team in db for userId
        public int AddTeam(int userId, int formationId)
        {
            int teamId = 0;
            // Check if userId already has a team
            teamId = GetTeamIdByUserId(userId);
            if (teamId != 0)
            {
                return 0;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query =
                    "INSERT INTO [dbo].[teamTable]([UserId],[FormationId],[TeamPoint])VALUES (@userId, @formationId, @points)";
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@userId", userId);
                    sqlCommand.Parameters.AddWithValue("@formationId", formationId);
                    sqlCommand.Parameters.AddWithValue("@points", 0);
                    sqlCommand.ExecuteNonQuery();
                }
            }

            teamId = GetTeamIdByUserId(userId);
            return teamId;
        }

        // Add players to team
        public void AddPlayersToTeam(int teamId, List<int> players)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (players.Count != 0)
                {
                    foreach (int playerId in players)
                    {
                        conn.Open();
                        using (SqlCommand query =
                            new SqlCommand("INSERT INTO [dbo].[player_teamTable]([PlayerId],[TeamId]) VALUES(@playerId, @teamId)", conn))
                        {
                            query.Parameters.AddWithValue("@playerId", playerId);
                            query.Parameters.AddWithValue("@teamId", teamId);
                            var reader = query.ExecuteReader();
                        }
                        conn.Close();
                    }
                }
            }
        }
    }
}
    

