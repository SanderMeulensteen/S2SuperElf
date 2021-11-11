using System;
using System.Collections.Generic;
using System.Text;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Club
    {
        public int clubId { get; set; }
        public string clubName { get; private set; }
        public Competition clubCompetition { get; private set; }

        public Club(int clubId, string clubName, Competition clubCompetition)
        {
            this.clubId = clubId;
            this.clubName = clubName;
            this.clubCompetition = clubCompetition;
        }

    }
}
