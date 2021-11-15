using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;

namespace Logic_SuperElf
{
    public class Competition
    {
        private IClubContainerDAL clubDAL = ClubDAL_Factory.CreateClubContainerDal();
        private ICompetitionDAL competitionDal = CompetitionDAL_Factory.CreateCompetitionDal();
        public int competitionId { get; private set; }
        public string competitionName { get; private set; }
        public Competition(int competitionId, string competitionName)
        {
            this.competitionId = competitionId;
            this.competitionName = competitionName;
        }
        // Update competition and manage clubs
        //-----Competition

        //-----Club
        public List<Club> GetAllClubs()
        {
            List<Club> clubs = new List<Club>();
            List<ClubDto> clubDtos = clubDAL.GetAllClubDtos();
            foreach (ClubDto clubDto in clubDtos)
            {
                Club club = new Club(clubDto.clubId, clubDto.clubName, clubDto.competition);
                clubs.Add(club);
            }
            return clubs;
        }
    }
}
