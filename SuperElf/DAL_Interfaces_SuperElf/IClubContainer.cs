using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface IClubContainerDAL
    {
        List<ClubDto> GetAllClubDtos();
    }
}
