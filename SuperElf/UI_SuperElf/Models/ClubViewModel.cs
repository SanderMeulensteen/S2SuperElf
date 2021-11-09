using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using SharedFiles;

namespace UI_SuperElf.Models
{
    public class ClubViewModel
    {
        [DisplayName("Clubname")]
        public string clubName { get; private set; }
        [DisplayName("Competition")]
        public Competition clubCompetition { get; private set; }
    }
}
