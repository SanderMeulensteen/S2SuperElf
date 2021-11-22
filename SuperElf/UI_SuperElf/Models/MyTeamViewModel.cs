using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Logic_Interfaces_SuperElf;

namespace UI_SuperElf.Models
{
    public class MyTeamViewModel
    {
        public List<IFormation> formations = new List<IFormation>();
        public List<IPlayer> Players = new List<IPlayer>();
        [DisplayName("Points")]
        [Required]
        public int teamPoints { get; set; }
        [DisplayName("Formation")]
        [Required]
        public int formation { get; set; }

    }
}
