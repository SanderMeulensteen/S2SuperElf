using System;
using System.Collections.Generic;
using System.Text;
using DAL_Factories_SuperElf;
using DAL_Interfaces_SuperElf;
using Logic_Interfaces_SuperElf;
using SharedFiles;

namespace Logic_SuperElf
{
    public class Team : ITeam
    {
        private readonly IFormationContainerDAL formationDal = FormationDAL_Factory.CreateFormationContainerDAL();
        public int teamId { get; private set; }
        public int userId { get; private set; }
        public int teamPoint { get; private set; }
        public int formationId { get; private set; }

        public Team(int teamId, int userId, int teamPoint, int formationId)
        {
            this.teamId = teamId;
            this.userId = userId;
            this.teamPoint = teamPoint;
            this.formationId = formationId;
        }
        public Team() : this(0, 0,0,0)
        {

        }
        // Update team and manage formations

        //-----Team

        //-----Formation
        // Get all formations from db
        public List<IFormation> GetAllFormations()
        {
            List<IFormation> formations = new List<IFormation>();
            List<FormationDto> formationDtos = formationDal.GetAllFormations();
            foreach (FormationDto formationDto in formationDtos)
            {
                formations.Add(ConvertDtoToFormation(formationDto.formationId,formationDto.formationName));
            }
            return formations;
        }
        // Add new formation to db
        public void AddFormation(string formationName)
        {
            FormationDto formationDto = new FormationDto();
            formationDto.formationName = formationName;
            formationDal.AddFormation(formationDto);
        }
        // Get formation from db by id
        public IFormation GetFormationById(int formationId)
        {
            FormationDto formationDto = formationDal.GetFormationById(formationId);
            IFormation formation = ConvertDtoToFormation(formationDto.formationId, formationDto.formationName);
            return formation;
        }
        // Delete formation from db
        public void DeleteFormation(int formationId)
        {
            formationDal.DeleteFormation(formationId);
        }
        // Create Formation from dto
        public IFormation ConvertDtoToFormation(int formationId, string formationName)
        {
            Formation formation = new Formation(formationId, formationName);
            return formation;
        }
    }
}
