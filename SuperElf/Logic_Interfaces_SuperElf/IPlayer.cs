using System.Collections.Generic;
using Logic_Interfaces_SuperElf;

namespace Logic_SuperElf
{
    public interface IPlayer
    {
        public List<dtoPlayer> GetAllPlayers();
    }
}