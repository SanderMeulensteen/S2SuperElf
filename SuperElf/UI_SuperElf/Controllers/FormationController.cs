using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic_Factories_SuperElf;
using Logic_Interfaces_SuperElf;
using UI_SuperElf.Models;

namespace UI_SuperElf.Controllers
{
    public class FormationController : Controller
    {
        private readonly ITeam _team = Team_Factory.CreateTeam();
        // GET: FormationController
        public ActionResult Index()
        {
            try
            {
                FormationPipeline formationPipeline = new FormationPipeline();
                List<IFormation> formations = _team.GetAllFormations();
                foreach (IFormation formation in formations)
                {
                    FormationViewModel formationViewModel = new FormationViewModel();
                    formationViewModel.formationId = formation.formationId;
                    formationViewModel.formationName = formation.formationName;
                    formationPipeline.Formations.Add(formationViewModel);
                }
                return View(formationPipeline);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: FormationController/Create
        public ActionResult Create()
        {
            FormationViewModel formation = new FormationViewModel();
            return View(formation);
        }

        // POST: FormationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormationViewModel newFormation)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    FormationViewModel formation = newFormation;
                    return View(formation);
                }

                _team.AddFormation(newFormation.formationName);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: FormationController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                return FormationViewModelById(id);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: FormationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int formationId, FormationViewModel updatedFormation)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return ReturnToFormation(formationId);
                }

                IFormation formation = _team.GetFormationById(formationId);
                string newFormationName = updatedFormation.formationName;
                formation.UpdateFormation(formation, newFormationName);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: FormationController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                return FormationViewModelById(id);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: FormationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormationViewModel formation)
        {
            try
            {
                if (id == 0)
                {
                    ModelState.AddModelError("", "Delete could not be processed, try again later.");
                    return RedirectToAction("Index");
                }

                _team.DeleteFormation(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }
        //
        private ActionResult FormationViewModelById(int formationId)
        {
            IFormation formatitionById = _team.GetFormationById(formationId);
            FormationViewModel formation = new FormationViewModel();
            formation.formationId = formatitionById.formationId;
            formation.formationName = formatitionById.formationName;
            return View(formation);
        }
        // 
        private ActionResult ReturnToFormation(int formationId)
        {
            ModelState.AddModelError("", "Update could not be processed, try again later.");
            return FormationViewModelById(formationId);
        }
    }
}
