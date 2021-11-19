using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL_Interfaces_SuperElf;
using Logic_Factories_SuperElf;
using Logic_Interfaces_SuperElf;
using Microsoft.EntityFrameworkCore;
using UI_SuperElf.Models;

namespace UI_SuperElf.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClub _club = Club_Factory.CreateClub();
        private readonly ICompetition _competition = Competition_Factory.CreateCompetition();
        private readonly ICompetitionContainer _competitionContainer =
            CompetitionContainer_Factory.CreateCompetitionContainer();
        // GET: ClubController
        public ActionResult Index()
        {
            ClubPipeline clubPipeline = new ClubPipeline();
            List<IClub> clubs = _competition.GetAllClubs();
            foreach (IClub club in clubs)
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
            return ClubCreateViewModelById(id);
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
            if (!ModelState.IsValid)
            {
                ClubCreateViewModel club = new ClubCreateViewModel();
                club.allCompetitions = _competitionContainer.GetAllCompetitions();
                return View(club);
            }

            _competition.AddClub(newClub.clubId, newClub.competitionId, newClub.clubName);
            return RedirectToAction("Index");
        }

        // GET: ClubController/EditName/5
        public ActionResult EditName(int id)
        {
            return ClubCreateViewModelById(id);
        }

        // POST: ClubController/EditName/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditName(int clubId, ClubCreateViewModel updatedClub)
        {
            if (!ModelState.IsValid)
            {
                return ReturnToClub(clubId);
            }

            string newClubName = updatedClub.clubName;
            _club.UpdateClubName(clubId, newClubName);
            return RedirectToAction("Details", new {id = clubId});
        }

        // GET: ClubController/EditCompetition/5
        public ActionResult EditCompetition(int id)
        {
            return ClubCreateViewModelById(id);
        }

        // POST: ClubController/EditCompetition/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCompetition(int clubId, ClubCreateViewModel updatedClub)
        {
            if (!ModelState.IsValid)
            {
                return ReturnToClub(clubId);
            }

            int newCompetition = updatedClub.competitionId;
            _club.UpdateCompetition(clubId, newCompetition);
            return RedirectToAction("Details", new {id = clubId});
        }
        // GET: ClubController/Delete/5
        public ActionResult Delete(int id)
        {
            return ClubCreateViewModelById(id);
        }

        // POST: ClubController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ClubCreateViewModel club)
        {
            if (id == 0)
            {
                ModelState.AddModelError("", "Delete could not be processed, try again later.");
                return RedirectToAction("Index");
            }

            _competition.DeleteClub(id);
            return RedirectToAction("Index");
        }
        // Create clubCreateViewModel by id
        private ActionResult ClubCreateViewModelById(int id)
        {
            IClub clubById = _competition.GetClubById(id);
            ClubCreateViewModel club = new ClubCreateViewModel();
            club.clubId = clubById.clubId;
            club.competitionId = clubById.competitionId;
            club.clubName = clubById.clubName;
            club.allCompetitions = _competitionContainer.GetAllCompetitions();
            return View(club);
        }
        // Return correct club to view when an error occurs
        private ActionResult ReturnToClub(int playerId)
        {
            ModelState.AddModelError("", "Update could not be processed, try again later.");
            return ClubCreateViewModelById(playerId);
        }
    }
}
