using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class UserContainer_Factory
    {
        public static IUserContainer CreateUserContainer()
        {
            return new UserContainer();
        }
    }
}
