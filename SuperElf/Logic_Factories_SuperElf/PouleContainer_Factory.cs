using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class PouleContainer_Factory
    {
        public static IPouleContainer CreatePouleContainer()
        {
            return new PouleContainer();
        }
    }
}
