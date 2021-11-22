using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;

namespace DAL_Factories_SuperElf
{
    public class TeamDAL_Factory
    {
        public static ITeamDAL CreateTeamDal()
        {
            return new TeamDAL();
        }
        public static ITeamContainerDAL CreateTeamContainerDal()
        {
            return new TeamDAL();
        }
    }
}
