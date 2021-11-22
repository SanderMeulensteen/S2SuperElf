using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public interface IPlayerContainerDAL
    {
        List<PlayerDto> GetAllPlayers();
        void AddPlayer(PlayerDto playerDto);
        void DeletePlayer(int id);
        PlayerDto GetPlayerDtoById(int playerId);
        List<PlayerDto> GetPlayersFromTeam(int teamId);
    }
}
