using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface IPlayerDAL
    {
        public List<PlayerDto> GetAllPlayers();
        void AddPlayer(PlayerDto playerDto);
    }
}
