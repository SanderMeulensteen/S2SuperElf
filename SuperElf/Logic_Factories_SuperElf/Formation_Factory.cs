using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class Formation_Factory
    {
        public static IFormation CreateFormation()
        {
            return new Formation();
        }
    }
}
