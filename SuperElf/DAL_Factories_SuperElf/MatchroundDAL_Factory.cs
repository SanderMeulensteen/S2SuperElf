using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;

namespace DAL_Factories_SuperElf
{
    public class MatchroundDAL_Factory
    {
        public static IMatchroundDAL CreateMatchroundDal()
        {
            return new MatchroundDAL();
        }
        public static IMatchroundContainerDAL CreateClubContainerDal()
        {
            return new MatchroundDAL();
        }
    }
}
