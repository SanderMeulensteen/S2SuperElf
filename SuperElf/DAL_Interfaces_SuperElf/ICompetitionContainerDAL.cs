using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface ICompetitionContainerDAL
    {
        List<CompetitionDto> GetAllCompetitionDtos();
        CompetitionDto GetCompetitionById(int competitionId);
        void AddCompetition(CompetitionDto competitionDto);
        void DeleteCompetition(int competitionId);
    }
}
