using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Logic_Factories_SuperElf;
using Logic_Interfaces_SuperElf;
using Microsoft.AspNetCore.Http;
using UI_SuperElf.Models;

namespace UI_SuperElf.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUser _user = User_Factory.CreateUser();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            try
            {
                HomeViewModel home = new HomeViewModel();
                int? sessionId = HttpContext.Session.GetInt32("_SessionUserId");
                string sessionIdString = sessionId.ToString();
                int id = Int32.Parse(sessionIdString);
                List<IPlayer> players = _user.GetPlayersFromTeam(id);
                home.teamOfTheWeek = players.OrderBy(x => x.position).ToList();
                return View(home);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }
        
        public ActionResult Error()
        {
            return View();
        }
    }
}
