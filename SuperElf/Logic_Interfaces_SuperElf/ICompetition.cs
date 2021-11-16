using System.Collections.Generic;

namespace Logic_Interfaces_SuperElf
{
    public interface ICompetition
    {
        int competitionId { get; }
        string competitionName { get; }
        void UpdateCompetitionName(int competitionId, string newCompetitionName);
        List<IClub> GetAllClubs();
        void AddClub(int clubId, int clubCompetitionId, string clubName);
        IClub GetClubById(int clubId);
        void DeleteClub(int clubId);
        public IClub ConvertDtoToClub(int clubId, string clubName, int clubCompetitionId);
    }
}