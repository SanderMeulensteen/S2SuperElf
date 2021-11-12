using SharedFiles;

namespace Logic_Interfaces_SuperElf
{
    public interface IPlayer
    {
        int playerId { get; }
        string playerName { get; }
        Position position { get; }
        int club { get; }
        void UpdatePlayerName(int playerId, string newPlayerName);
        void UpdatePlayerPosition(int playerId, int newPosition);
        void UpdatePlayerClub(int playerId, int newClub);
    }
}