using System;
using System.Collections.Generic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Team
    {
        public int teamPoint { get; private set; }
        public Formation teamFormation { get; private set; }

        public Team(int teamPoint, Formation teamFormation)
        {
            this.teamPoint = teamPoint;
            this.teamFormation = teamFormation;
        }
        // Update team

        //-----Team


    }
}
