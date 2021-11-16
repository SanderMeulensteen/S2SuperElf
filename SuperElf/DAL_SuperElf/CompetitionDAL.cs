using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using Microsoft.Data.SqlClient;

namespace DAL_SuperElf
{
    public class CompetitionDAL : ICompetitionDAL, ICompetitionContainerDAL
    {
        private string connectionString =
            "Data Source=mssql.fhict.local;Persist Security Info=True;User ID = dbi449009_superelf; Password=!t5AC13791K";
        // Get all competitions from db
        public List<CompetitionDto> GetAllCompetitionDtos()
        {
            List<CompetitionDto> competitionDtos = new List<CompetitionDto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("select * from competitionTable", conn))
                {
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        CompetitionDto competitionDto = new CompetitionDto();
                        competitionDto.competitionId = reader.GetInt32(0);
                        competitionDto.competitionName = reader.GetString(1);
                        competitionDtos.Add(competitionDto);
                    }
                }
            }
            return competitionDtos;
        }
        // Get competition from db by id
        public CompetitionDto GetCompetitionById(int competitionId)
        {
            CompetitionDto competitionDto = new CompetitionDto();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("select * from competitionTable where CompetitionId = @competitionId", conn))
                {
                    query.Parameters.AddWithValue("@competitionId", competitionId);
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        competitionDto.competitionId = reader.GetInt32(0);
                        competitionDto.competitionName = reader.GetString(1);
                    }
                }
            }
            return competitionDto;
        }
        // Add competition to db
        public void AddCompetition(CompetitionDto competitionDto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query =
                    "INSERT INTO [dbo].[competitionTable]([CompetitionName]) VALUES(@competitionName)";
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@competitionName", competitionDto.competitionName);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        // Delete competition from db
        public void DeleteCompetition(int competitionId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[clubTable] SET[CompetitionId] = @newCompetitionId WHERE CompetitionId = @competitionId", conn))
                {
                    query.Parameters.AddWithValue("@newCompetitionId", 1);
                    query.Parameters.AddWithValue("@competitionId", competitionId);
                    query.ExecuteNonQuery();
                }
                using (SqlCommand query = new SqlCommand("DELETE FROM [dbo].[competitionTable] WHERE CompetitionId = @competitionId", conn))
                {
                    query.Parameters.AddWithValue("@competitionId",competitionId);
                    query.ExecuteNonQuery();
                }
            }
        }
        // Update competition name in db
        public void UpdateCompetitionName(int competitionId, string newCompetitionName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[competitionTable] SET[CompetitionName] = @competitionName WHERE CompetitionId = @competitionId", conn))
                {
                    query.Parameters.AddWithValue("@competitionName", newCompetitionName);
                    query.Parameters.AddWithValue("@competitionId", competitionId);
                    query.ExecuteNonQuery();
                }
            }
        }
    }
}
