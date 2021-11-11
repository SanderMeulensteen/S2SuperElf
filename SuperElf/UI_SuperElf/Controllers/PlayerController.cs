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
        private readonly Player _player = new Player(0,"", 0, 0);
        private readonly Club _club = new Club(0, "", 0);
        private readonly ClubContainer _clubContainer = new ClubContainer();
        
        //public PlayerController(IPlayer player)
        //{
        //    _player = player;
        //}

        // GET: PlayerController
        public ActionResult Index()
        {
            PlayersPipeline playersPipeline = new PlayersPipeline();
            List<Player> players = _club.GetAllPlayers();

            foreach (Player player in players)
            {
                PlayerViewModel playerViewModel = new PlayerViewModel();
                playerViewModel.playerId = player.playerId;
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
            Player playerById = _club.GetPlayerById(id);
            PlayerCreateViewModel player = new PlayerCreateViewModel();
            player.playerId = playerById.playerId;
            player.playerName = playerById.playerName;
            player.position = playerById.position;
            player.club = playerById.club;
            player.allClubs = _clubContainer.GetAllClubs();
            return View(player);
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
                Player player = new Player(playerViewModel.playerId, playerViewModel.playerName, playerViewModel.position, playerViewModel.club);
                _club.AddPlayer(player);
                return RedirectToAction("Index");
            }
            else
            {
                PlayerCreateViewModel player = new PlayerCreateViewModel();
                player.allClubs = _clubContainer.GetAllClubs();
                return View(player);
            }
        }

        // GET: PlayerController/Edit/5
        public ActionResult Edit(int id)
        {
            Player playerById = _club.GetPlayerById(id);
            PlayerCreateViewModel player = new PlayerCreateViewModel();
            player.playerId = playerById.playerId;
            player.playerName = playerById.playerName;
            player.position = playerById.position;
            player.club = playerById.club;
            player.allClubs = _clubContainer.GetAllClubs();
            return View(player);
        }

        // POST: PlayerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PlayerViewModel playerViewModel)
        {
            if (ModelState.IsValid)
            {
                Player player = new Player(playerViewModel.playerId, playerViewModel.playerName, playerViewModel.position, playerViewModel.club);
                _player.UpdatePlayer(player);
                return RedirectToAction("Index");
            }
            else
            {
                PlayerCreateViewModel player = new PlayerCreateViewModel();
                player.allClubs = _clubContainer.GetAllClubs();
                return View(player);
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
