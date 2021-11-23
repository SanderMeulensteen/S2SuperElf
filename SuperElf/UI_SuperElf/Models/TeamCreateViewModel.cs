using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Player 1")]
        [Required]
        public int playerId1 { get; set; }
        [DisplayName("Player 2")]
        [Required]
        public int playerId2 { get; set; }
        [DisplayName("Player 3")]
        [Required]
        public int playerId3 { get; set; }
        [DisplayName("Player 4")]
        [Required]
        public int playerId4 { get; set; }
        [DisplayName("Player 5")]
        [Required]
        public int playerId5 { get; set; }
        [DisplayName("Player 6")]
        [Required]
        public int playerId6 { get; set; }
        [DisplayName("Player 7")]
        [Required]
        public int playerId7 { get; set; }
        [DisplayName("Player 8")]
        [Required]
        public int playerId8 { get; set; }
        [DisplayName("Player 9")]
        [Required]
        public int playerId9 { get; set; }
        [DisplayName("Player 10")]
        [Required]
        public int playerId10 { get; set; }
        [DisplayName("Player 11")]
        [Required]
        public int playerId11 { get; set; }
        public List<IPlayer> keepers = new List<IPlayer>();
        public List<IPlayer> defenders = new List<IPlayer>();
        public List<IPlayer> midfielders = new List<IPlayer>();
        public List<IPlayer> forwards = new List<IPlayer>();
        

    }
}
