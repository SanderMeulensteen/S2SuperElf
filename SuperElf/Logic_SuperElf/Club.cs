using System;
using System.Collections.Generic;
using System.Text;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Club
    {
        public string clubName { get; private set; }
        public Competition clubCompetition { get; private set; }

        public Club(string clubName, Competition clubCompetition)
        {
            this.clubName = clubName;
            this.clubCompetition = clubCompetition;
        }

    }
}
