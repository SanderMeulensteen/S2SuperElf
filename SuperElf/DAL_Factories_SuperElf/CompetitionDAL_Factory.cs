using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;

namespace DAL_Factories_SuperElf
{
    public class CompetitionDAL_Factory
    {
        public static ICompetitionDAL CreateCompetitionDal()
        {
            return new CompetitionDAL();
        }
        public static ICompetitionContainerDAL CreateCompetitionContainerDal()
        {
            return new CompetitionDAL();
        }
    }
}
