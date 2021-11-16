using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI_SuperElf.Models
{
    public class CompetitionViewModel
    {
        public int competitionId { get; set; }
        [DisplayName("Competition name")]
        [Required]
        public string competitionName { get; set; }
    }
}
