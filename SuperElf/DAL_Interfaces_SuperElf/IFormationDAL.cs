using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface IFormationDAL
    {
        void UpdateFormation(int formationId, string newFormationName);
    }
}
