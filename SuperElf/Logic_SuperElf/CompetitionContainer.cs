using System;
using System.Collections.Generic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using Logic_Interfaces_SuperElf;

namespace Logic_SuperElf
{
    public class CompetitionContainer : ICompetitionContainer
    {
        private readonly ICompetitionContainerDAL competitionDAL = CompetitionDAL_Factory.CreateCompetitionContainerDal();
        // Manage competitions
        // Get all competitions from db
        public List<ICompetition> GetAllCompetitions()
        {
            List<ICompetition> competitions = new List<ICompetition>();
            List<CompetitionDto> competitionDtos = competitionDAL.GetAllCompetitionDtos();
            foreach (CompetitionDto competitionDto in competitionDtos)
            {
                Competition competition = new Competition(competitionDto.competitionId, competitionDto.competitionName);
                competitions.Add(competition);
            }
            return competitions;
        }
        // Get competition from db by id
        public ICompetition GetCompetitionById(int competitionId)
        {
            CompetitionDto competitionDto = competitionDAL.GetCompetitionById(competitionId);
            ICompetition competition = ConvertDtoToCompetition(competitionDto.competitionId, competitionDto.competitionName);
            return competition;
        }
        // Add new competition to db
        public void AddCompetition(int competitionId, string competitionName)
        {
            CompetitionDto competitionDto = new CompetitionDto();
            competitionDto.competitionName = competitionName;
            competitionDAL.AddCompetition(competitionDto);
        }
        // Delete competition from db
        public void DeleteCompetition(int competitionId)
        {
            competitionDAL.DeleteCompetition(competitionId);
        }
        // Convert dto to competition
        public ICompetition ConvertDtoToCompetition(int competitionId, string competitionName)
        {
            Competition competition = new Competition(competitionId, competitionName);
            return competition;
        }
    }
}
