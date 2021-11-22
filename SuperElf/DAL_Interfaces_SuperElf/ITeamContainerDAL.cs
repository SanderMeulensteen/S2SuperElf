using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface ITeamContainerDAL
    {
        TeamDto GetTeamById(int userId);
        int GetTeamIdByUserId(int userId);
    }
}
