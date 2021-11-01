using System;
using System.Collections.Generic;
using System.Text;
using SharedFiles;

namespace Logic_Interfaces_SuperElf
{
    public class dtoPlayer
    {
        public string playerName { get; }
        public Position position { get; }
        public string club { get; } 

        public dtoPlayer(string playerName, Position position, string club)
        {
            this.playerName = playerName;
            this.position = position;
            this.club = club;
        }
    }
}
