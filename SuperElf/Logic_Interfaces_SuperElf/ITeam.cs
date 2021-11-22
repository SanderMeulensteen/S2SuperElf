using SharedFiles;
using System.Collections.Generic;

namespace Logic_Interfaces_SuperElf
{
    public interface ITeam
    {
        int teamPoint { get; }
        int teamFormation { get; }

        List<IFormation> GetAllFormations();
        void AddFormation(string formationName);
        IFormation GetFormationById(int formationId);
        void DeleteFormation(int formationId);
    }
}