using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class Club_Factory
    {
        public static IClub CreateClub()
        {
            return new Club(0,"",0);
        }
    }
}
