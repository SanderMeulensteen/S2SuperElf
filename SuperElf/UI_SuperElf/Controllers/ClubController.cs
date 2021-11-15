using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL_Interfaces_SuperElf;
using Logic_SuperElf;
using UI_SuperElf.Models;

namespace UI_SuperElf.Controllers
{
    public class ClubController : Controller
    {
        private readonly Club _club = new Club(0,"", 0);
        private readonly Competition _competition = new Competition(0, "");

        private readonly CompetitionContainer _competitionContainer = new CompetitionContainer();
        // GET: ClubController
        public ActionResult Index()
        {
            ClubPipeline clubPipeline = new ClubPipeline();
            List<Club> clubs = _competition.GetAllClubs();
            foreach (Club club in clubs)
            {
                ClubViewModel clubViewModel = new ClubViewModel();
                clubViewModel.clubId = club.clubId;
                clubViewModel.clubName = club.clubName;
                clubViewModel.competition = club.competition;
                clubPipeline.Clubs.Add(clubViewModel);
            }

            clubPipeline.Competitions = _competitionContainer.GetAllCompetitions();
            return View(clubPipeline);
        }

        // GET: ClubController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClubController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClubController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClubController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClubController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClubController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClubController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
