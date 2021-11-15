using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface IClubContainerDAL
    {
        List<ClubDto> GetAllClubDtos();
        void AddClub(ClubDto clubDto);
        ClubDto GetClubById(int clubId);
        void DeleteClub(int clubId);
    }
}
