using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace Logic_Factories_SuperElf
{
    public class User_Factory
    {
        public static IUser CreateUser()
        {
            return new User();
        }
    }
}
