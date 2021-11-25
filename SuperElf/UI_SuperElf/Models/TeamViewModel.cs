using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Logic_Interfaces_SuperElf;

namespace UI_SuperElf.Models
{
    public class TeamViewModel
    {
        public int teamId { get; set; }
        [Required]
        public int userId { get; set; }
        [DisplayName("Formation")]
        [Required]
        public int formation { get; set; }
        [DisplayName("Points")]
        [Required]
        public int teamPoints { get; set; }

        public List<IUser> users = new List<IUser>();
        public List<IFormation> formations = new List<IFormation>();
        public List<IPlayer> players = new List<IPlayer>();
    }
}