using System;
using System.Collections.Generic;
using System.Text;
using SharedFiles;

namespace Logic_Interfaces_SuperElf
{
    class PlayerLogicDto
    {
        public string playerName { get; }
        public Position position { get; }

        public PlayerLogicDto(string playerName, Position position)
        {
            this.playerName = playerName;
            this.position = position;
        }
    }
}
