using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;
using Logic_Interfaces_SuperElf;

namespace Logic_SuperElf
{
    public class Competition : ICompetition
    {
        private readonly IClubContainerDAL clubDAL = ClubDAL_Factory.CreateClubContainerDal();
        private readonly ICompetitionDAL competitionDal = CompetitionDAL_Factory.CreateCompetitionDal();
        public int competitionId { get; private set; }
        public string competitionName { get; private set; }
        public Competition(int competitionId, string competitionName)
        {
            this.competitionId = competitionId;
            this.competitionName = competitionName;
        }
        public Competition() : this(0, "")
        {

        }
        // Update competition and manage clubs
        //-----Competition
        // Update competition name in db
        public void UpdateCompetitionName(ICompetition competition, string newCompetitionName)
        {
            competitionDal.UpdateCompetitionName(competitionId, newCompetitionName);
        }
        //-----Club
        // Get all clubs from db
        public List<IClub> GetAllClubs()
        {
            List<IClub> clubs = new List<IClub>();
            List<ClubDto> clubDtos = clubDAL.GetAllClubDtos();
            foreach (ClubDto clubDto in clubDtos)
            {
                Club club = new Club(clubDto.clubId, clubDto.clubName, clubDto.competitionId);
                clubs.Add(club);
            }
            return clubs;
        }
        // Add club to db
        public void AddClub(int clubId, int clubCompetitionId, string clubName)
        {
            ClubDto clubDto = new ClubDto();
            clubDto.clubName = clubName;
            clubDto.competitionId = clubCompetitionId;
            clubDAL.AddClub(clubDto);
        }
        // Get club from clubId
        public IClub GetClubById(int clubId)
        {
            ClubDto clubDto = clubDAL.GetClubById(clubId);
            IClub club = ConvertDtoToClub(clubDto.clubId, clubDto.clubName, clubDto.competitionId);
            return club;
        }
        // Delete club from db
        public void DeleteClub(int clubId)
        {
            clubDAL.DeleteClub(clubId);
        }
        // Convert dto to club
        public IClub ConvertDtoToClub(int clubId, string clubName, int clubCompetitionId)
        {
            Club club = new Club(clubId, clubName, clubCompetitionId);
            return club;
        }
    }
}
