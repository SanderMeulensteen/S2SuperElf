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
        // Get all competitions from db
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
        // Get competition from db by id
        public Competition GetCompetitionById(int competitionId)
        {
            CompetitionDto competitionDto = competitionDAL.GetCompetitionById(competitionId);
            Competition competition = ConvertDtoToCompetition(competitionDto);
            return competition;
        }
        // Add new competition to db
        public void AddCompetition(Competition competition)
        {
            CompetitionDto competitionDto = ConvertCompetitionToDto(competition);
            competitionDAL.AddCompetition(competitionDto);
        }
        // Delete competition from db
        public void DeleteCompetition(int competitionId)
        {
            competitionDAL.DeleteCompetition(competitionId);
        }
        // Convert competition to dto
        public CompetitionDto ConvertCompetitionToDto(Competition competition)
        {
            CompetitionDto competitionDto = new CompetitionDto();
            competitionDto.competitionName = competition.competitionName;
            return competitionDto;
        }
        // Convert dto to competition
        public Competition ConvertDtoToCompetition(CompetitionDto competitionDto)
        {
            Competition competition = new Competition(competitionDto.competitionId, competitionDto.competitionName);
            return competition;
        }
    }
}
