using System;
using System.Collections.Generic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;

namespace Logic_SuperElf
{
    public class CompetitionContainer
    {
        private ICompetitionContainerDAL competitionDAL = CompetitionDAL_Factory.CreateCompetitionContainerDal();
        // Manage competitions
        public List<Competition> GetAllCompetitions()
        {
            List<Competition> competitions = new List<Competition>();
            List<CompetitionDto> competitionDtos = competitionDAL.GetAllCompetitionDtos();
            foreach (CompetitionDto competitionDto in competitionDtos)
            {
                Competition competition = new Competition(competitionDto.competitionId, competitionDto.competitionName);
                competitions.Add(competition);
            }
            return competitions;
        }
    }
}
