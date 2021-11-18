using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;

namespace DAL_Factories_SuperElf
{
    public class PouleDAL_Factory
    {
        public static IPouleDAL CreatePouleDal()
        {
            return new PouleDAL();
        }
        public static IPouleContainerDAL CreatePouleContainerDal()
        {
            return new PouleDAL();
        }
    }
}
