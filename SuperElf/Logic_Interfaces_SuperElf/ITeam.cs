using SharedFiles;
using System.Collections.Generic;

namespace Logic_Interfaces_SuperElf
{
    public interface ITeam
    {
        int teamId { get; }
        int userId { get; }
        int teamPoint { get; }
        int formationId { get; }

        List<IFormation> GetAllFormations();
        void AddFormation(string formationName);
        IFormation GetFormationById(int formationId);
        void DeleteFormation(int formationId);
    }
}