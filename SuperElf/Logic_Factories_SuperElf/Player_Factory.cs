using System;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class Player_Factory
    {
        public static IPlayer CreatePlayerLogic()
        {
            return new Player("", 0);
        }
    }
}
