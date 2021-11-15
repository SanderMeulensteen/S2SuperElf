using System;
using System.Collections.Generic;
using System.Text;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Poule
    {
        public string pouleName { get; private set; }
        public int competition { get; private set; }

        public Poule(string pouleName, int competition)
        {
            this.pouleName = pouleName;
            this.competition = competition;
        }
        // Update poules
    }
}
