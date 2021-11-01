using System;
using System.Collections.Generic;
using System.Text;
using SharedFiles;

namespace DAL_Interfaces_SuperElf
{
    public class PlayerDto
    {
        public string playerName { get; }
        public Position position { get; }
        public string club { get; }

        public PlayerDto(string playerName, Position position, string club)
        {
            this.playerName = playerName;
            this.position = position;
            this.club = club;
        }
    }
}
