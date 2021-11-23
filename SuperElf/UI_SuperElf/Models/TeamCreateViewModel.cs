using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Logic_Interfaces_SuperElf;

namespace UI_SuperElf.Models
{
    public class TeamCreateViewModel
    {
        public int teamId { get; set; }
        public int userId { get; set; }
        public int formationId { get; set; }
        public int teamPoints { get; set; }
        [Required]
        public int playerId1 { get; set; }
        [Required]
        public int playerId2 { get; set; }
        [Required]
        public int playerId3 { get; set; }
        [Required]
        public int playerId4 { get; set; }
        [Required]
        public int playerId5 { get; set; }
        [Required]
        public int playerId6 { get; set; }
        [Required]
        public int playerId7 { get; set; }
        [Required]
        public int playerId8 { get; set; }
        [Required]
        public int playerId9 { get; set; }
        [Required]
        public int playerId10 { get; set; }
        [Required]
        public int playerId11 { get; set; }
        public List<IPlayer> keepers = new List<IPlayer>();
        public List<IPlayer> defenders = new List<IPlayer>();
        public List<IPlayer> midfielders = new List<IPlayer>();
        public List<IPlayer> forwards = new List<IPlayer>();
        

    }
}
