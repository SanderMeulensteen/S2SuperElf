using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using Microsoft.Data.SqlClient;

namespace DAL_SuperElf
{
    public class FormationDAL : IFormationDAL, IFormationContainerDAL
    {
        private string connectionString =
            "Data Source=mssql.fhict.local;Persist Security Info=True;User ID = dbi449009_superelf; Password=!t5AC13791K";
        // Get all formations from db
        public List<FormationDto> GetAllFormations()
        {
            List<FormationDto> formations = new List<FormationDto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand query = new SqlCommand("select * from formationTable", conn))
                {
                    conn.Open();

                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        FormationDto formation = new FormationDto();
                        formation.formationId = reader.GetInt32(0);
                        formation.formationName = reader.GetString(1);
                        formations.Add(formation);
                    }
                }
            }
            return formations;
        }
        // Add new formation to db
        public void AddFormation(FormationDto formationDto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query =
                    "INSERT INTO [dbo].[formationTable]([FormationName]) VALUES(@formationName)";
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@formationName", formationDto.formationName);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        // Get formation from db by id
        public FormationDto GetFormationById(int formationId)
        {
            FormationDto formationDto = new FormationDto();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("select * from formationTable where FormationId = @formationId", conn))
                {
                    query.Parameters.AddWithValue("@formationId", formationId);
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        formationDto.formationId = reader.GetInt32(0);
                        formationDto.formationName = reader.GetString(1);
                    }
                }
            }
            return formationDto;
        }
        // Update formation in db
        public void UpdateFormation(int formationId, string newFormationName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("UPDATE[dbo].[formationTable] SET[FormationName] = @formationName WHERE FormationId = @formationId", conn))
                {
                    query.Parameters.AddWithValue("@formationName", newFormationName);
                    query.Parameters.AddWithValue("@formationId", formationId);
                    query.ExecuteNonQuery();
                }
            }
        }
        // Delete formation from db
        public void DeleteFormation(int formationId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand query = new SqlCommand("DELETE FROM [dbo].[formationTable] WHERE FormationId = @formationId", conn))
                {
                    query.Parameters.AddWithValue("@formationId", formationId);
                    query.ExecuteNonQuery();
                }
            }
        }
    }
}
