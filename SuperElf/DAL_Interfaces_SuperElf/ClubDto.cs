using System;
using System.Collections.Generic;
using System.Text;
using SharedFiles;

namespace DAL_Interfaces_SuperElf
{
    public class ClubDto
    {
        public int clubId { get; set; }
        public string clubName { get; set; }
        public Competition clubCompetition { get; set; }
    }
}
