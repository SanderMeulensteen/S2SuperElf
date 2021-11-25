using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic_Factories_SuperElf;
using Logic_Interfaces_SuperElf;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using UI_SuperElf.Models;

namespace UI_SuperElf.Controllers
{
    public class CompetitionController : Controller
    {
        private readonly ICompetition _competition = Competition_Factory.CreateCompetition();
        private readonly ICompetitionContainer _competitionContainer = CompetitionContainer_Factory.CreateCompetitionContainer();
        // GET: CompetitionController
        public ActionResult Index()
        {
            CompetitionPipeline competitionPipeline = new CompetitionPipeline();
            List<ICompetition> competitions = _competitionContainer.GetAllCompetitions();
            foreach (ICompetition competition in competitions)
            {
                CompetitionViewModel competitionViewModel = new CompetitionViewModel();
                competitionViewModel.competitionId = competition.competitionId;
                competitionViewModel.competitionName = competition.competitionName;
                competitionPipeline.Competitions.Add(competitionViewModel);
            }
            return View(competitionPipeline);
        }

        // GET: CompetitionController/Details/5
        public ActionResult Details(int id)
        {
            ICompetition competitionById = _competitionContainer.GetCompetitionById(id);
            CompetitionDetailsViewModel competition = new CompetitionDetailsViewModel();
            competition.competitionId = competitionById.competitionId;
            competition.competitionName = competitionById.competitionName;
            competition.clubs = new List<IClub>();
            List<IClub> allClubs = _competition.GetAllClubs();
            foreach (IClub club in allClubs)
            {
                if (club.competitionId == competition.competitionId)
                {
                    competition.clubs.Add(club);
                }
            }
            return View(competition);
        }

        // GET: CompetitionController/Create
        public ActionResult Create()
        {
            CompetitionViewModel competition = new CompetitionViewModel();
            return View(competition);
        }

        // POST: CompetitionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CompetitionViewModel newCompetition)
        {
            if (!ModelState.IsValid)
            {
                CompetitionViewModel competition = new CompetitionViewModel();
                return View(competition);
            }

            _competitionContainer.AddCompetition(newCompetition.competitionId, newCompetition.competitionName);
            return RedirectToAction("Index");
        }

        // GET: CompetitionController/Edit/5
        public ActionResult Edit(int id)
        {
            return CompetitionViewModelById(id);
        }

        // POST: CompetitionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int competitionId, CompetitionViewModel updatedCompetition)
        {
            if (!ModelState.IsValid)
            {
                return ReturnToCompetition(competitionId);
            }

            ICompetition competition = _competitionContainer.GetCompetitionById(competitionId);
            string newCompetitionName = updatedCompetition.competitionName;
            competition.UpdateCompetitionName(competition, newCompetitionName);
            return RedirectToAction("Details", new {id = competitionId});
        }

        // GET: CompetitionController/Delete/5
        public ActionResult Delete(int id)
        {
            return CompetitionViewModelById(id);
        }

        // POST: CompetitionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CompetitionViewModel competition)
        {
            if (id == 0)
            {
                ModelState.AddModelError("", "Delete could not be processed, try again later.");
                return RedirectToAction("Index");
            }

            _competitionContainer.DeleteCompetition(id);
            return RedirectToAction("Index");
        }
        // Get competitionViewModel by id
        private ActionResult CompetitionViewModelById(int id)
        {
            ICompetition competitionById = _competitionContainer.GetCompetitionById(id);
            CompetitionViewModel competition = new CompetitionViewModel();
            competition.competitionId = competitionById.competitionId;
            competition.competitionName = competitionById.competitionName;
            return View(competition);
        }
        // Return correct competition to view when an error occurs
        private ActionResult ReturnToCompetition(int competitionId)
        {
            ModelState.AddModelError("", "Update could not be processed, try again later.");
            return CompetitionViewModelById(competitionId);
        }
    }
}
