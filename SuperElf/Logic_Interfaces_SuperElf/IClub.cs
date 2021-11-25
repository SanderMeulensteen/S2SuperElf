using System.Collections.Generic;

namespace Logic_Interfaces_SuperElf
{
    public interface IClub
    {
        int clubId { get; }
        string clubName { get; }
        int competitionId { get; }
        void UpdateClubName(IClub club, string newClubName);
        void UpdateCompetition(IClub club, int newCompetition);
        void AddPlayer(int playerId, string playerName, int position, int club);
        List<IPlayer> GetAllPlayers();
        void DeletePlayer(int playerId);
        IPlayer GetPlayerById(int playerId);
        IPlayer ConvertDtoToPlayer(int playerId, string playerName, int position, int club);
        List<IPlayer> GetAllKeepers();
        List<IPlayer> GetAllDefenders();
        List<IPlayer> GetAllMidfielders();
        List<IPlayer> GetAllForwards();
    }
}