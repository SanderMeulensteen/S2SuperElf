using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;

namespace Logic_SuperElf
{
    public class Matchround : IMatchround
    {
        public int playerId { get; private set; }
        public int season { get; private set; }
        public int week { get; private set; }
        public int point { get; private set; }

        public Matchround(int playerId, int season, int week, int point)
        {
            this.playerId = playerId;
            this.season = season;
            this.point = point;
            this.week = week;
        }
        // Update matchrounds
    }
}
