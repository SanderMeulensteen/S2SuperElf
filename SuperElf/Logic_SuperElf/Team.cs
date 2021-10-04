using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_SuperElf
{
    class Team
    {
        public int teamPoint { get; private set; }
        public Formation teamFormation { get; private set; }
        public Competition teamCompetition { get; private set; }

        public Team(int teamPoint, Formation teamFormation, Competition teamCompetition)
        {
            this.teamPoint = teamPoint;
            this.teamFormation = teamFormation;
            this.teamCompetition = teamCompetition;
        }
    }
}
