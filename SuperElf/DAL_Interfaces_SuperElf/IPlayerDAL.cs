using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface IPlayerDAL
    {
        void UpdatePlayerName(int playerId, string newPlayerName);
        void UpdatePlayerPosition(int playerId, int newPosition);
        void UpdatePlayerClub(int playerId, int newClub);
    }
}
