using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using Logic_Interfaces_SuperElf;
using Logic_SuperElf;
using SharedFiles;
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

        // GET: PlayerController/EditName/5
        public ActionResult EditName(int id)
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

        // POST: PlayerController/EditName/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditName(int playerId, PlayerViewModel updatedPlayer)
        {
            if (ModelState.IsValid)
            {
                string newPlayerName = updatedPlayer.playerName;
                _player.UpdatePlayerName(playerId, newPlayerName);
                return RedirectToAction("Details", new { id = playerId });
            }
            else
            {
                PlayerCreateViewModel player = new PlayerCreateViewModel();
                player.allClubs = _clubContainer.GetAllClubs();
                return View(player);
            }
        }
        // GET: PlayerController/EditPosition/5
        public ActionResult EditPosition(int id)
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
                player.allClubs = _clubContainer.GetAllClubs();
                return View(player);
            }
        }

        // GET: PlayerController/EditClub/5
        public ActionResult EditClub(int id)
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
                player.allClubs = _clubContainer.GetAllClubs();
                return View(player);
            }
        }

        // GET: PlayerController/Delete/5
        public ActionResult Delete(int id)
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
