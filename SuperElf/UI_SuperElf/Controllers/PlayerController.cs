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
        private readonly IPlayer _player = Player_Factory.CreatePlayer();
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
            IPlayer playerById = _club.GetPlayerById(id);
            PlayerCreateViewModel player = new PlayerCreateViewModel();
            player.playerId = playerById.playerId;
            player.playerName = playerById.playerName;
            player.position = playerById.position;
            player.club = playerById.club;
            player.allClubs = _competition.GetAllClubs();
            return View(player);
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
            if (ModelState.IsValid)
            {
                _club.AddPlayer(playerViewModel.playerId, playerViewModel.playerName, (int) playerViewModel.position, playerViewModel.club);
                return RedirectToAction("Index");
            }
            else
            {
                PlayerCreateViewModel player = new PlayerCreateViewModel();
                player.allClubs = _competition.GetAllClubs();
                return View(player);
            }
        }

        // GET: PlayerController/EditName/5
        public ActionResult EditName(int id)
        {
            IPlayer playerById = _club.GetPlayerById(id);
            PlayerCreateViewModel player = new PlayerCreateViewModel();
            player.playerId = playerById.playerId;
            player.playerName = playerById.playerName;
            player.position = playerById.position;
            player.club = playerById.club;
            player.allClubs = _competition.GetAllClubs();
            return View(player);
        }

        // POST: PlayerController/EditName/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditName(int playerId, PlayerViewModel updatedPlayer)
        {
            if (!ModelState.IsValid)
            {
                return returnToPlayer();
            }

            string newPlayerName = updatedPlayer.playerName;
            _player.UpdatePlayerName(playerId, newPlayerName);
            return RedirectToAction("Details", new {id = playerId});
        }

        private ActionResult returnToPlayer()
        {
            PlayerCreateViewModel player = new PlayerCreateViewModel();
            player.allClubs = _competition.GetAllClubs();
            return View(player);
        }

        // GET: PlayerController/EditPosition/5
        public ActionResult EditPosition(int id)
        {
            IPlayer playerById = _club.GetPlayerById(id);
            PlayerCreateViewModel player = new PlayerCreateViewModel();
            player.playerId = playerById.playerId;
            player.playerName = playerById.playerName;
            player.position = playerById.position;
            player.club = playerById.club;
            player.allClubs = _competition.GetAllClubs();
            return View(player);
        }

        // POST: PlayerController/EditPosition/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPosition(int playerId, PlayerViewModel updatedPlayer)
        {
            if (ModelState.IsValid)
            {
                int newPlayerPosition = (int) updatedPlayer.position;
                _player.UpdatePlayerPosition(playerId, newPlayerPosition);
                return RedirectToAction("Details", new { id = playerId });
            }
            else
            {
                PlayerCreateViewModel player = new PlayerCreateViewModel();
                player.allClubs = _competition.GetAllClubs();
                return View(player);
            }
        }

        // GET: PlayerController/EditClub/5
        public ActionResult EditClub(int id)
        {
            IPlayer playerById = _club.GetPlayerById(id);
            PlayerCreateViewModel player = new PlayerCreateViewModel();
            player.playerId = playerById.playerId;
            player.playerName = playerById.playerName;
            player.position = playerById.position;
            player.club = playerById.club;
            player.allClubs = _competition.GetAllClubs();
            return View(player);
        }

        // POST: PlayerController/EditClub/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditClub(int playerId, PlayerViewModel updatedPlayer)
        {
            if (ModelState.IsValid)
            {
                int newClub = updatedPlayer.club;
                _player.UpdatePlayerClub(playerId, newClub);
                return RedirectToAction("Details", new { id = playerId });
            }
            else
            {
                PlayerCreateViewModel player = new PlayerCreateViewModel();
                player.allClubs = _competition.GetAllClubs();
                return View(player);
            }
        }

        // GET: PlayerController/Delete/5
        public ActionResult Delete(int id)
        {
            IPlayer playerById = _club.GetPlayerById(id);
            PlayerCreateViewModel player = new PlayerCreateViewModel();
            player.playerId = playerById.playerId;
            player.playerName = playerById.playerName;
            player.position = playerById.position;
            player.club = playerById.club;
            player.allClubs = _competition.GetAllClubs();
            return View(player);
        }

        // POST: PlayerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PlayerCreateViewModel player)
        {
            if (id == 0)
            {
                return View(player);
            }
            else
            {
                _club.DeletePlayer(id);
                return RedirectToAction("Index");
            }
        }
    }
}
