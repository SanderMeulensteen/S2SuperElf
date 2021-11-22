using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface IFormationContainerDAL
    {
        List<FormationDto> GetAllFormations();
        void AddFormation(FormationDto formationDto);
        FormationDto GetFormationById(int formationId);
        void DeleteFormation(int formationId);
    }
}
