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
            players.Add(new PlayerDto("Joel Drommel", Position.Goalkeeper));
            players.Add(new PlayerDto("Yvon Mvogo", Position.Goalkeeper));
            players.Add(new PlayerDto("Vincent Müller", Position.Goalkeeper));
            players.Add(new PlayerDto("Maxime Delanghe", Position.Goalkeeper));
            players.Add(new PlayerDto("Jordan Teze", Position.Defender));
            players.Add(new PlayerDto("Armando Obispo", Position.Defender));
            players.Add(new PlayerDto("André Ramalho", Position.Defender));
            players.Add(new PlayerDto("Olivier Boscagli", Position.Defender));
            players.Add(new PlayerDto("Phillip Mwene", Position.Defender));
            players.Add(new PlayerDto("Philipp Max", Position.Defender));
            players.Add(new PlayerDto("Ibrahim Sangaré", Position.Midfielder));
            players.Add(new PlayerDto("Marco van Ginkel", Position.Midfielder));
            players.Add(new PlayerDto("Davy Pröpper", Position.Midfielder));
            players.Add(new PlayerDto("Érick Gutiérrez", Position.Midfielder));
            players.Add(new PlayerDto("Mauro Júniro", Position.Midfielder));
            players.Add(new PlayerDto("Mario Götze", Position.Midfielder));
            players.Add(new PlayerDto("Ryan Thomas", Position.Midfielder));
            players.Add(new PlayerDto("Richard Ledezma", Position.Midfielder));
            players.Add(new PlayerDto("Eran Zahavi", Position.Forward));
            players.Add(new PlayerDto("Carlos Vinícius", Position.Forward));
            players.Add(new PlayerDto("Noni Madueke", Position.Forward));
            players.Add(new PlayerDto("Cody Gakpo", Position.Forward));
            players.Add(new PlayerDto("Bruma", Position.Forward));
            players.Add(new PlayerDto("Maxi Romero", Position.Forward));
            players.Add(new PlayerDto("Ritsu Doan", Position.Forward));
            players.Add(new PlayerDto("Yorbe Vertessen", Position.Forward));
            return players;
        }

    }
}

