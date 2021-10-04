using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_SuperElf
{
    class Poule
    {
        public string pouleName { get; private set; }
        public Competition pouleCompetion { get; private set; }

        public Poule(string pouleName, Competition pouleCompetion)
        {
            this.pouleName = pouleName;
            this.pouleCompetion = pouleCompetion;
        }
    }
}
