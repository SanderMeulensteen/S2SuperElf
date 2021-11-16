using System.Collections.Generic;

namespace Logic_Interfaces_SuperElf
{
    public interface ICompetitionContainer
    {
        List<ICompetition> GetAllCompetitions();
        ICompetition GetCompetitionById(int competitionId);
        void AddCompetition(int competitionId, string competitionName);
        void DeleteCompetition(int competitionId);
        public ICompetition ConvertDtoToCompetition(int competitionId, string competitionName);
    }
}