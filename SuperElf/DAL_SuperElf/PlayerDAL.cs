using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using Microsoft.Data.SqlClient;
using SharedFiles;

namespace DAL_SuperElf
{
    public class PlayerDAL : IPlayerDAL
    {
        private string connectionString =
            "Data Source=mssql.fhict.local;Persist Security Info=True;User ID = dbi449009_superelf; Password=!t5AC13791K";
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
                        player.playerName = reader.GetString(2);
                        player.position = (Position)reader.GetInt32(3);
                        player.club = reader.GetInt32(1);
                        players.Add(player);
                    }
                }
            }
            return players;
        }

    }
}

