using System.Collections.Generic;
using DAL_Interfaces_SuperElf;

namespace DAL_SuperElf
{
    public interface IClubDAL
    {
        void UpdateClubName(int clubId, string newClubName);
        void UpdateCompetition(int clubId, int newCompetition);
    }
}