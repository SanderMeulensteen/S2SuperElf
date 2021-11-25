using SharedFiles;

namespace Logic_Interfaces_SuperElf
{
    public interface IPlayer
    {
        int playerId { get; }
        string playerName { get; }
        Position position { get; }
        int club { get; }
        void UpdatePlayerName(IPlayer player, string newPlayerName);
        void UpdatePlayerPosition(IPlayer player, int newPosition);
        void UpdatePlayerClub(IPlayer player, int newClub);
    }
}