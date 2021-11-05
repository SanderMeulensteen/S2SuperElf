using System;
using System.Collections.Generic;
using DAL_Interfaces_SuperElf;
using Microsoft.Data.SqlClient;
using SharedFiles;

namespace DAL_SuperElf
{
    public class ClubDAL : IClubDAL
    {
        private string connectionString =
            "Data Source=mssql.fhict.local;Persist Security Info=True;User ID = dbi449009_superelf; Password=!t5AC13791K";
        public List<ClubDto> GetAllClubs()
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
                        club.clubCompetition = (Competition) reader.GetInt32(1);
                        club.clubName = reader.GetString(2);
                        clubs.Add(club);
                    }
                }
            }



            return clubs;
        }

    }
}
