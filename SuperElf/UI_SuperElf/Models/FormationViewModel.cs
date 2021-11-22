using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI_SuperElf.Models
{
    public class FormationViewModel
    {
        public int formationId { get; set; }
        [DisplayName("Formation")]
        [Required]
        public string formationName { get; set; }
    }
}
