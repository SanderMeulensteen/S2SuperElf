using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface ICompetitionDAL
    {
        void UpdateCompetitionName(int competitionId, string newCompetitionName);
    }
}
