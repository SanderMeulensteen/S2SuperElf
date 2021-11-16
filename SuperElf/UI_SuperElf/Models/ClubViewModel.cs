using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SharedFiles;

namespace UI_SuperElf.Models
{
    public class ClubViewModel
    {
        public int clubId { get; set; }
        [DisplayName("Club name")]
        [Required]
        public string clubName { get; set; }
        [DisplayName("Competition")]
        [Required]
        public int competitionId { get; set; }
    }
}
