using System;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;

namespace DAL_Factories_SuperElf
{
    public class ClubDAL_Factory
    {
        public static IClubDAL CreateClubDal()
        {
            return new ClubDAL();
        }
        public static IClubContainerDAL CreateClubContainerDal()
        {
            return new ClubDAL();
        }
    }
}
