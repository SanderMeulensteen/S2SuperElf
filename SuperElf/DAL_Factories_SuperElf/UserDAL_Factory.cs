using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;

namespace DAL_Factories_SuperElf
{
    public class UserDAL_Factory
    {
        public static IUserDAL CreateUserDal()
        {
            return new UserDAL();
        }
        public static IUserContainerDAL CreateUserContainerDal()
        {
            return new UserDAL();
        }
    }
}
