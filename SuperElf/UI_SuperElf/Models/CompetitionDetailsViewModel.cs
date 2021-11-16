using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Logic_SuperElf;

namespace UI_SuperElf.Models
{
    public class CompetitionDetailsViewModel
    {
        public int competitionId { get; set; }
        [DisplayName("Competition name")]
        [Required]
        public string competitionName { get; set; }
        public List<Club> clubs { get; set; }
    }
}
