using System;
using System.Collections.Generic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using Logic_Interfaces_SuperElf;

namespace Logic_SuperElf
{
    public class Formation : IFormation
    {
        private readonly IFormationDAL formationDAL = FormationDAL_Factory.CreateFormationDAL();
        public int formationId { get; private set; }
        public string formationName { get; private set; }

        public Formation(int formationId, string formationName)
        {
            this.formationId = formationId;
            this.formationName = formationName;
        }

        public Formation() : this(0, "")
        {

        }
        // Updates formation
        //-----Formation
        // Update formation in db
        public void UpdateFormation(IFormation formation, string newFormationName)
        {
            formationDAL.UpdateFormation(formationId, newFormationName);
        }
    }
}
