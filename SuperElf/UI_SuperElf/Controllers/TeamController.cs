﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic_Factories_SuperElf;
using Logic_Interfaces_SuperElf;
using SharedFiles;
using UI_SuperElf.Models;

namespace UI_SuperElf.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeam _team = Team_Factory.CreateTeam();
        private readonly IUser _user = User_Factory.CreateUser();
        private readonly IClub _club = Club_Factory.CreateClub();
        // GET: TeamController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeamController/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        public ActionResult MyTeam(int id)
        {
            MyTeamViewModel myTeam = new MyTeamViewModel();
            ITeam teamDetails = _user.GetTeamDetailsById(id);
            List<IPlayer> players = _user.GetPlayersFromTeam(id);
            List<IPlayer> sortedPlayers = players.OrderBy(x => x.position).ToList();
            if (players.Count != 0)
            {
                foreach (IPlayer player in sortedPlayers)
                {
                    myTeam.Players.Add(player);
                }
            }
            myTeam.formations = _team.GetAllFormations();
            myTeam.formation = teamDetails.formationId;
            myTeam.teamPoints = teamDetails.teamPoint;
            return View(myTeam);
        }

        // Get formation for create team
        public ActionResult ChooseTeamFormation()
        {
            MyTeamViewModel myTeamViewModel = new MyTeamViewModel();
            myTeamViewModel.formations = _team.GetAllFormations();
            return View(myTeamViewModel);
        }

        // GET: TeamController/Create
        public ActionResult Create(int id)
        {
            TeamCreateViewModel teamCreateViewModel = new TeamCreateViewModel();
            teamCreateViewModel.keepers = _club.GetAllKeepers();
            teamCreateViewModel.defenders = _club.GetAllDefenders();
            teamCreateViewModel.midfielders = _club.GetAllMidfielders();
            teamCreateViewModel.forwards = _club.GetAllForwards();
            teamCreateViewModel.formationId = id;
            return View(teamCreateViewModel);
        }

        // POST: TeamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeamAddModel newTeam)
        {
            if (!ModelState.IsValid)
            {
                TeamCreateViewModel teamCreateViewModel = new TeamCreateViewModel();
                teamCreateViewModel.keepers = _club.GetAllKeepers();
                teamCreateViewModel.defenders = _club.GetAllDefenders();
                teamCreateViewModel.midfielders = _club.GetAllMidfielders();
                teamCreateViewModel.forwards = _club.GetAllForwards();
                teamCreateViewModel.formationId = newTeam.formationId;
                ModelState.AddModelError("", "Select for each position a player.");
                return View(teamCreateViewModel);
            }
            List<int> players = new List<int>();
            players.Add(newTeam.playerId1);
            players.Add(newTeam.playerId2);
            players.Add(newTeam.playerId3);
            players.Add(newTeam.playerId4);
            players.Add(newTeam.playerId5);
            players.Add(newTeam.playerId6);
            players.Add(newTeam.playerId7);
            players.Add(newTeam.playerId8);
            players.Add(newTeam.playerId9);
            players.Add(newTeam.playerId10);
            players.Add(newTeam.playerId11);
            int teamId = _user.AddTeam(newTeam.userId, newTeam.formationId);
            _user.AddPlayersToTeam(teamId, players);
            return RedirectToAction("MyTeam");
        }

        // GET: TeamController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeamController/Edit/5
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

        // GET: TeamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeamController/Delete/5
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
