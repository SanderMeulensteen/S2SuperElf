using System;
using System.Collections.Generic;
using System.Text;
using Logic_Interfaces_SuperElf;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Poule : IPoule
    {
        public string pouleName { get; private set; }
        public int competition { get; private set; }

        public Poule(string pouleName, int competition)
        {
            this.pouleName = pouleName;
            this.competition = competition;
        }
        public Poule() : this("", 0)
        {

        }
        // Update poules
    }
}
