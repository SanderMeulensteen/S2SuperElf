using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Logic_SuperElf;

namespace UI_SuperElf.Models
{
    public class ClubCreateViewModel
    {
        public int clubId { get; set; }
        [DisplayName("Clubname")]
        [Required]
        public string clubName { get; set; }
        [DisplayName("Competition")]
        [Required]
        public int competitionId { get; set; }
        public List<Competition> allCompetitions { get; set; }
    }
}
