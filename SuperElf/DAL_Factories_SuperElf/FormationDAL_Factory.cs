using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;

namespace DAL_Factories_SuperElf
{
    public class FormationDAL_Factory
    {
        public static IFormationDAL CreateFormationDAL()
        {
            return new FormationDAL();
        }
        public static IFormationContainerDAL CreateFormationContainerDAL()
        {
            return new FormationDAL();
        }
    }
}
