using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class Team_Factory
    {
        public static ITeam CreateTeam()
        {
            return new Team(0, 0);
        }
    }
}
