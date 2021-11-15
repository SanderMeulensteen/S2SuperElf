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
                clubViewModel.competitionId = club.competitionId;
                clubPipeline.Clubs.Add(clubViewModel);
            }
            clubPipeline.Competitions = _competitionContainer.GetAllCompetitions();
            return View(clubPipeline);
        }

        // GET: ClubController/Details/5
        public ActionResult Details(int id)
        {
            Club clubById = _competition.GetClubById(id);
            ClubCreateViewModel club = new ClubCreateViewModel();
            club.clubId = clubById.clubId;
            club.competitionId = clubById.competitionId;
            club.clubName = clubById.clubName;
            club.allCompetitions = _competitionContainer.GetAllCompetitions();
            return View(club);
        }

        // GET: ClubController/Create
        public ActionResult Create()
        {
            ClubCreateViewModel club = new ClubCreateViewModel();
            club.allCompetitions = _competitionContainer.GetAllCompetitions();
            return View(club);
        }

        // POST: ClubController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClubViewModel newClub)
        {
            if (ModelState.IsValid)
            {
                Club club = new Club(newClub.clubId, newClub.clubName, newClub.competitionId);
                _competition.AddClub(club);
                return RedirectToAction("Index");
            }
            else
            {
                ClubCreateViewModel club = new ClubCreateViewModel();
                club.allCompetitions = _competitionContainer.GetAllCompetitions();
                return View(club);
            }
        }

        // GET: ClubController/EditName/5
        public ActionResult EditName(int id)
        {
            return View();
        }

        // POST: ClubController/EditName/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditName(int id, IFormCollection collection)
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

        // GET: ClubController/EditCompetition/5
        public ActionResult EditCompetition(int id)
        {
            return View();
        }

        // POST: ClubController/EditCompetition/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCompetition(int id, IFormCollection collection)
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
            Club clubById = _competition.GetClubById(id);
            ClubCreateViewModel club = new ClubCreateViewModel();
            club.clubId = clubById.clubId;
            club.competitionId = clubById.competitionId;
            club.clubName = clubById.clubName;
            club.allCompetitions = _competitionContainer.GetAllCompetitions();
            return View(club);
        }

        // POST: ClubController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ClubCreateViewModel club)
        {
            if (id == 0)
            {
                return View(club);
            }
            else
            {
                _competition.DeleteClub(id);
                return RedirectToAction("Index");
            }
        }
    }
}
