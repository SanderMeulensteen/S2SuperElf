using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic_Factories_SuperElf;
using Logic_Interfaces_SuperElf;
using Microsoft.AspNetCore.Http;
using UI_SuperElf.Models;

namespace UI_SuperElf.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserContainer _userContainer = UserContainer_Factory.CreateUserContainer();
        string SessionName = "_SessionName";
        string SessionIsAdmin = "_SessionIsAdmin";
        string SessionIsMod = "_SessionIsMod";
        string SessionUserId = "_SessionUserId";
        [HttpGet]
        public ActionResult Login()
        {
            LoginViewModel login = new LoginViewModel();
            return View(login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel login)
        {
            IUser user = _userContainer.LoginCheck(login.emailaddress, login.password);
            if (user != null)
            {
                HttpContext.Session.SetString(SessionName, user.firstName);
                HttpContext.Session.SetString(SessionIsAdmin, user.isAdmin.ToString());
                HttpContext.Session.SetString(SessionIsMod, user.isModerator.ToString());
                HttpContext.Session.SetInt32(SessionUserId, user.userId);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Username and/or Password is wrong.");
                return View(login);
            }
        }
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Remove(SessionName);
            HttpContext.Session.Remove(SessionUserId);
            HttpContext.Session.Remove(SessionIsAdmin);
            HttpContext.Session.Remove(SessionIsMod);
            return RedirectToAction("Login", "Login");
        }
    }
}
