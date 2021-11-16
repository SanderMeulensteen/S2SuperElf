using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class CompetitionContainer_Factory
    {
        public static ICompetitionContainer CreateCompetitionContainer()
        {
            return new CompetitionContainer();
        }
    }
}
