using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace UI_SuperElf.Models
{
    public class ClubPipeline
    {
        public List<ClubViewModel> Clubs = new List<ClubViewModel>();
        public List<ICompetition> Competitions = new List<ICompetition>();
    }
}
