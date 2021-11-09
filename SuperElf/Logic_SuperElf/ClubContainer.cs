using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using DAL_SuperElf;

namespace Logic_SuperElf
{
    public class ClubContainer
    {
        private IClubDAL clubDAL = ClubDAL_Factory.CreateClubDal();
        public List<ClubDto> GetAllClubDtos()
        {
            List<ClubDto> clubDtos = clubDAL.GetAllClubDtos();
            return clubDtos;
        }
        public List<Club> GetAllClubs()
        {
            List<Club> clubs = new List<Club>();
            List<ClubDto> clubDtos = clubDAL.GetAllClubDtos();
            foreach (ClubDto clubDto in clubDtos)
            {
                Club club = new Club(clubDto.clubName, clubDto.clubCompetition);
                clubs.Add(club);
            }
            return clubs;
        }

        public List<string> GetAllClubNames()
        {
            List<string> clubNames = new List<string>();
            List<ClubDto> clubDtos = clubDAL.GetAllClubDtos();
            foreach (ClubDto clubDto in clubDtos)
            {
                clubNames.Add(clubDto.clubName);
            }
            return clubNames;
        }
    }
}
