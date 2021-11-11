﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Team
    {
        private ClubContainer clubContainer = new ClubContainer();
        public int teamPoint { get; private set; }
        public Formation teamFormation { get; private set; }
        public Competition teamCompetition { get; private set; }

        public Team(int teamPoint, Formation teamFormation, Competition teamCompetition)
        {
            this.teamPoint = teamPoint;
            this.teamFormation = teamFormation;
            this.teamCompetition = teamCompetition;
        }
        // Update team

        //-----Team


    }
}
