using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using Logic_Interfaces_SuperElf;
using Logic_SuperElf;
using UI_SuperElf.Models;

namespace UI_SuperElf.Controllers
{
    public class PlayerController : Controller
    {
        private readonly Player _player = new Player("", 0, 0);
        private readonly Team _team = new Team(0, 0, 0);
        private readonly ClubContainer _clubContainer = new ClubContainer();
        
        //public PlayerController(IPlayer player)
        //{
        //    _player = player;
        //}

        // GET: PlayerController
        public ActionResult Index()
        {
            PlayersPipeline playersPipeline = new PlayersPipeline();
            List<Player> players = _player.GetAllPlayers();

            foreach (Player player in players)
            {
                PlayerViewModel playerViewModel = new PlayerViewModel();
                playerViewModel.playerName = player.playerName;
                playerViewModel.position = player.position;
                playerViewModel.club = player.club;
                playersPipeline.Players.Add(playerViewModel);
            }
            playersPipeline.Clubs = _clubContainer.GetAllClubs();
            return View(playersPipeline);
        }

        // GET: PlayerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlayerController/Create
        public ActionResult Create()
        {
            PlayerCreateViewModel player = new PlayerCreateViewModel();
            player.allClubs = _clubContainer.GetAllClubs();
            return View(player);
        }

        // POST: PlayerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlayerViewModel playerViewModel)
        {
            if (ModelState.IsValid)
            {
                Player player = new Player(playerViewModel.playerName, playerViewModel.position, playerViewModel.club);
                _team.AddPlayer(player);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: PlayerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlayerController/Edit/5
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

        // GET: PlayerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlayerController/Delete/5
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
