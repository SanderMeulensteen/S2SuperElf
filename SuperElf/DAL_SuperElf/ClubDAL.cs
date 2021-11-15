using System;
using System.Collections.Generic;
using DAL_Interfaces_SuperElf;
using Microsoft.Data.SqlClient;
using SharedFiles;

namespace DAL_SuperElf
{
    public class ClubDAL : IClubDAL, IClubContainerDAL
    {
        private string connectionString =
            "Data Source=mssql.fhict.local;Persist Security Info=True;User ID = dbi449009_superelf; Password=!t5AC13791K";
        // Get all clubs from db
        public List<ClubDto> GetAllClubDtos()
        {
            List<ClubDto> clubs = new List<ClubDto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand query = new SqlCommand("select * from clubTable", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        ClubDto club = new ClubDto();
                        club.clubId = reader.GetInt32(0);
                        club.competitionId = reader.GetInt32(1);
                        club.clubName = reader.GetString(2);
                        clubs.Add(club);
                    }
                }
            }
            return clubs;
        }
        // Add club to db
        public void AddClub(ClubDto club)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query =
                    "INSERT INTO [dbo].[clubTable]([CompetitionId],[ClubName]) VALUES(@competitionId,@clubName)";
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@competitionId", club.competitionId);
                    sqlCommand.Parameters.AddWithValue("@clubName", club.clubName);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        // Get club from db by clubID
        public ClubDto GetClubById(int clubId)
        {
            ClubDto clubDto = new ClubDto();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("select * from clubTable where ClubId = @Id", conn))
                {
                    query.Parameters.AddWithValue("@Id", clubId);

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        clubDto.clubId = reader.GetInt32(0);
                        clubDto.competitionId = reader.GetInt32(1);
                        clubDto.clubName = reader.GetString(2);
                    }
                }
            }
            return clubDto;
        }
        // Delete club from db
        public void DeleteClub(int clubId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("DELETE FROM [dbo].[clubTable] WHERE clubId = @clubId", conn))
                {
                    query.Parameters.AddWithValue("@clubId", clubId);
                    query.ExecuteNonQuery();
                }
            }
        }
    }
}
