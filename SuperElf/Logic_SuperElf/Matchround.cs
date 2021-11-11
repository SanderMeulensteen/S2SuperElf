using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_SuperElf
{
    public class Matchround
    {
        public int season { get; private set; }
        public int week { get; private set; }
        public int point { get; private set; }

        public Matchround(int season, int week, int point)
        {
            this.season = season;
            this.point = point;
            this.week = week;
        }
        // Update matchrounds
    }
}
