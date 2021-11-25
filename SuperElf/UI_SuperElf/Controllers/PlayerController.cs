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
    public class PlayerController : Controller
    {
        private readonly IClub _club = Club_Factory.CreateClub();
        private readonly ICompetition _competition = Competition_Factory.CreateCompetition();
        
        // GET: PlayerController
        public ActionResult Index()
        {
            PlayersPipeline playersPipeline = new PlayersPipeline();
            List<IPlayer> players = _club.GetAllPlayers();

            foreach (IPlayer player in players)
            {
                PlayerViewModel playerViewModel = new PlayerViewModel();
                playerViewModel.playerId = player.playerId;
                playerViewModel.playerName = player.playerName;
                playerViewModel.position = player.position;
                playerViewModel.club = player.club;
                playersPipeline.Players.Add(playerViewModel);
            }
            playersPipeline.Clubs = _competition.GetAllClubs();
            return View(playersPipeline);
        }

        // GET: PlayerController/Details/5
        public ActionResult Details(int id)
        {
            return PlayerCreateViewModelById(id);
        }

        // GET: PlayerController/Create
        public ActionResult Create()
        {
            PlayerCreateViewModel player = new PlayerCreateViewModel();
            player.allClubs = _competition.GetAllClubs();
            return View(player);
        }

        // POST: PlayerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlayerViewModel playerViewModel)
        {
            if (!ModelState.IsValid)
            {
                PlayerCreateViewModel player = new PlayerCreateViewModel();
                player.allClubs = _competition.GetAllClubs();
                return View(player);
            }

            _club.AddPlayer(playerViewModel.playerId, playerViewModel.playerName, (int) playerViewModel.position,
                playerViewModel.club);
            return RedirectToAction("Index");
        }

        // GET: PlayerController/EditName/5
        public ActionResult EditName(int id)
        {
            return PlayerCreateViewModelById(id);
        }

        // POST: PlayerController/EditName/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditName(int playerId, PlayerViewModel updatedPlayer)
        {
            if (!ModelState.IsValid)
            {
                return ReturnToPlayer(playerId);
            }
            IPlayer player = _club.GetPlayerById(playerId);
            string newPlayerName = updatedPlayer.playerName;
            player.UpdatePlayerName(player, newPlayerName);
            return RedirectToAction("Details", new {id = playerId});
        }

        // GET: PlayerController/EditPosition/5
        public ActionResult EditPosition(int id)
        {
            return PlayerCreateViewModelById(id);
        }

        // POST: PlayerController/EditPosition/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPosition(int playerId, PlayerViewModel updatedPlayer)
        {
            if (!ModelState.IsValid)
            {
                return ReturnToPlayer(playerId);
            }
            IPlayer player = _club.GetPlayerById(playerId);
            int newPlayerPosition = (int) updatedPlayer.position;
            player.UpdatePlayerPosition(player, newPlayerPosition);
            return RedirectToAction("Details", new {id = playerId});
        }

        // GET: PlayerController/EditClub/5
        public ActionResult EditClub(int id)
        {
            return PlayerCreateViewModelById(id);
        }

        // POST: PlayerController/EditClub/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditClub(int playerId, PlayerViewModel updatedPlayer)
        {
            if (!ModelState.IsValid)
            {
                return ReturnToPlayer(playerId);
            }
            IPlayer player = _club.GetPlayerById(playerId);
            int newClub = updatedPlayer.club;
            player.UpdatePlayerClub(player, newClub);
            return RedirectToAction("Details", new {id = playerId});
        }

        // GET: PlayerController/Delete/5
        public ActionResult Delete(int id)
        {
            return PlayerCreateViewModelById(id);
        }

        // POST: PlayerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PlayerViewModel player)
        {
            if (id == 0)
            {
                ModelState.AddModelError("", "Delete could not be processed, try again later.");
                return RedirectToAction("Index");
            }

            _club.DeletePlayer(id);
            return RedirectToAction("Index");
        }
        // Create PlayerCreateViewModel
        private ActionResult PlayerCreateViewModelById(int playerId)
        {
            IPlayer playerById = _club.GetPlayerById(playerId);
            PlayerCreateViewModel player = new PlayerCreateViewModel();
            player.playerId = playerById.playerId;
            player.playerName = playerById.playerName;
            player.position = playerById.position;
            player.club = playerById.club;
            player.allClubs = _competition.GetAllClubs();
            return View(player);
        }

        // Return correct player to view when an error occurs
        private ActionResult ReturnToPlayer(int playerId)
        {
            ModelState.AddModelError("", "Update could not be processed, try again later.");
            return PlayerCreateViewModelById(playerId);
        }
    }
}
