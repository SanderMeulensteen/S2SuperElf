using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;

namespace DAL_SuperElf
{
    public class PouleDAL : IPouleDAL, IPouleContainerDAL
    {
        private string connectionString =
            "Data Source=mssql.fhict.local;Persist Security Info=True;User ID = dbi449009_superelf; Password=!t5AC13791K";
    }
}
