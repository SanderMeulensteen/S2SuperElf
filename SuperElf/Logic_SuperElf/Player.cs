using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_SuperElf
{
    class Player
    {
        public string playerName { get; private set; }
        public Position position { get; private set; }

        public Player(string playerName, Position position)
        {
            this.playerName = playerName;
            this.position = position;
        }
    }
}
