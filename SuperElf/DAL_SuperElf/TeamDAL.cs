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
    }
}
