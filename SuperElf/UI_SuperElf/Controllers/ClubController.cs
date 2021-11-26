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
        private readonly ICompetition _competition = Competition_Factory.CreateCompetition();
        private readonly ICompetitionContainer _competitionContainer =
            CompetitionContainer_Factory.CreateCompetitionContainer();
        // GET: ClubController
        public ActionResult Index()
        {
            try
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
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: ClubController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return ClubCreateViewModelById(id);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: ClubController/Create
        public ActionResult Create()
        {
            try
            {
                ClubCreateViewModel club = new ClubCreateViewModel();
                club.allCompetitions = _competitionContainer.GetAllCompetitions();
                return View(club);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: ClubController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClubViewModel newClub)
        {
            try
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
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: ClubController/EditName/5
        public ActionResult EditName(int id)
        {
            try
            {
                return ClubCreateViewModelById(id);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: ClubController/EditName/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditName(int clubId, ClubCreateViewModel updatedClub)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return ReturnToClub(clubId);
                }

                IClub club = _competition.GetClubById(clubId);
                string newClubName = updatedClub.clubName;
                club.UpdateClubName(club, newClubName);
                return RedirectToAction("Details", new {id = clubId});
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // GET: ClubController/EditCompetition/5
        public ActionResult EditCompetition(int id)
        {
            try
            {
                return ClubCreateViewModelById(id);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: ClubController/EditCompetition/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCompetition(int clubId, ClubCreateViewModel updatedClub)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return ReturnToClub(clubId);
                }

                IClub club = _competition.GetClubById(clubId);
                int newCompetition = updatedClub.competitionId;
                club.UpdateCompetition(club, newCompetition);
                return RedirectToAction("Details", new {id = clubId});
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }
        // GET: ClubController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                return ClubCreateViewModelById(id);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: ClubController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ClubCreateViewModel club)
        {
            try
            {
                if (id == 0)
                {
                    ModelState.AddModelError("", "Delete could not be processed, try again later.");
                    return RedirectToAction("Index");
                }

                _competition.DeleteClub(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
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
