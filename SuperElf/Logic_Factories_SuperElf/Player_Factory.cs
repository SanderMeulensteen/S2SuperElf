using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class Player_Factory
    {
        public static IPlayer CreatePlayer()
        {
            return new Player(0, "", 0, 0);
        }
    }
}
