using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class Poule_Factory
    {
        public static IPoule CreatePoule()
        {
            return new Poule();
        }
    }
}
