using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class Matchround_Factory
    {
        public static IMatchround CreateMatchround()
        {
            return new Matchround(0,0,0,0);
        }
    }
}
