using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using SharedFiles;

namespace DAL_SuperElf
{
    public class PlayerDAL : IPlayerDAL
    {
        public List<PlayerDto> GetAllPlayers()
        {
            List<PlayerDto> players = new List<PlayerDto>();
            players.Add(new PlayerDto("Joel Drommel", Position.Goalkeeper, "PSV"));
            players.Add(new PlayerDto("Philipp Max", Position.Defender, "PSV"));
            players.Add(new PlayerDto("Mario Götze", Position.Midfielder, "PSV"));
            players.Add(new PlayerDto("Cody Gakpo", Position.Forward, "PSV"));
            players.Add(new PlayerDto("Maarten Stekelenburg",Position.Goalkeeper,"Ajax"));
            players.Add(new PlayerDto("Jurien Timber", Position.Defender, "Ajax"));
            players.Add(new PlayerDto("Steven Berghuis", Position.Midfielder, "Ajax"));
            players.Add(new PlayerDto("Antony", Position.Forward, "Ajax"));
            players.Add(new PlayerDto("Peter Jensen", Position.Goalkeeper, "AZ"));
            players.Add(new PlayerDto("Owen Wijndal", Position.Defender, "AZ"));
            players.Add(new PlayerDto("Fredrik Midtsjø", Position.Midfielder, "AZ"));
            players.Add(new PlayerDto("Albert Gudmundsson", Position.Forward, "AZ"));
            players.Add(new PlayerDto("Justin Bijlow", Position.Goalkeeper, "Feyenoord"));
            players.Add(new PlayerDto("Marcos Senesi", Position.Defender, "Feyenoord"));
            players.Add(new PlayerDto("Guus Til", Position.Midfielder, "Feyenoord"));
            players.Add(new PlayerDto("Bryan Linssen", Position.Forward, "Feyenoord"));
            return players;
        }

    }
}

