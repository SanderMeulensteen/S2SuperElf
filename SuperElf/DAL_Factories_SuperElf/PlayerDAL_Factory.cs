using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;

namespace DAL_Factories_SuperElf
{
    public class PlayerDAL_Factory
    {
        public static IPlayerDAL CreatePlayerDal()
        {
            return new PlayerDAL();
        }
        public static IPlayerContainerDAL CreatePlayerContainerDal()
        {
            return new PlayerDAL();
        }

        //public static IPlayerDAL CreateTestPlayerDal()
        //{
        //    return new TestPlayerDAL();
        //}
        //public static IPlayerContainerDAL CreateTestPlayerContainerDal()
        //{
        //    return new TestPlayerDAL();
        //}
    }
}
