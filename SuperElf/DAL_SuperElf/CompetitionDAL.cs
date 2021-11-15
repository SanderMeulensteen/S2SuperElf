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
        public List<CompetitionDto> GetAllCompetitionDtos()
        {
            List<CompetitionDto> competitionDtos = new List<CompetitionDto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand query = new SqlCommand("select * from competitionTable", conn))
                {
                    conn.Open();

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
    }
}
