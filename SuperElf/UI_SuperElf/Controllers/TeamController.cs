using Microsoft.AspNetCore.Http;
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

        // GET: TeamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamController/Create
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
