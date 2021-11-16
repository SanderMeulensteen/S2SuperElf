﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL_Interfaces_SuperElf;
using Logic_Factories_SuperElf;
using Logic_Interfaces_SuperElf;
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
            IClub clubById = _competition.GetClubById(id);
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
                _competition.AddClub(newClub.clubId, newClub.competitionId, newClub.clubName);
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
            IClub clubById = _competition.GetClubById(id);
            ClubCreateViewModel club = new ClubCreateViewModel();
            club.clubId = clubById.clubId;
            club.competitionId = clubById.competitionId;
            club.clubName = clubById.clubName;
            club.allCompetitions = _competitionContainer.GetAllCompetitions();
            return View(club);
        }

        // POST: ClubController/EditName/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditName(int id, ClubViewModel updatedClub)
        {
            if (ModelState.IsValid)
            {
                string newClubName = updatedClub.clubName;
                _club.UpdateClubName(id, newClubName);
                return RedirectToAction("Details", new { id = id });
            }
            else
            {
                ClubCreateViewModel club = new ClubCreateViewModel();
                club.allCompetitions = _competitionContainer.GetAllCompetitions();
                return View(club);
            }
        }

        // GET: ClubController/EditCompetition/5
        public ActionResult EditCompetition(int id)
        {
            IClub clubById = _competition.GetClubById(id);
            ClubCreateViewModel club = new ClubCreateViewModel();
            club.clubId = clubById.clubId;
            club.competitionId = clubById.competitionId;
            club.clubName = clubById.clubName;
            club.allCompetitions = _competitionContainer.GetAllCompetitions();
            return View(club);
        }

        // POST: ClubController/EditCompetition/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCompetition(int id, ClubViewModel updatedClub)
        {
            if (ModelState.IsValid)
            {
                int newCompetition = updatedClub.competitionId;
                _club.UpdateCompetition(id, newCompetition);
                return RedirectToAction("Details", new { id = id });
            }
            else
            {
                ClubCreateViewModel club = new ClubCreateViewModel();
                club.allCompetitions = _competitionContainer.GetAllCompetitions();
                return View(club);
            }
        }
        // GET: ClubController/Delete/5
        public ActionResult Delete(int id)
        {
            IClub clubById = _competition.GetClubById(id);
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
