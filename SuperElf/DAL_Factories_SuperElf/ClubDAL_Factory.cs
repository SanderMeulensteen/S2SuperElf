using System;
using DAL_SuperElf;

namespace DAL_Factories_SuperElf
{
    public class ClubDAL_Factory
    {
        public static IClubDAL CreateClubDal()
        {
            return new ClubDAL();
        }
    }
}
