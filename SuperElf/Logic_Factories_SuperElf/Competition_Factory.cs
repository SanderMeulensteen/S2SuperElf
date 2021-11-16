using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class Competition_Factory
    {
        public static ICompetition CreateCompetition()
        {
            return new Competition(0,"");
        }
    }
}
