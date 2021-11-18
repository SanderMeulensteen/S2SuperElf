using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic_Factories_SuperElf;
using Logic_Interfaces_SuperElf;
using UI_SuperElf.Models;

namespace UI_SuperElf.Controllers
{
    public class LoginLogoutController : Controller
    {
        private readonly IUserContainer _userContainer = UserContainer_Factory.CreateUserContainer();
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
            if (_userContainer.LoginCheck(login.emailaddress, login.password))
            {
                //session
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.error = "Email and/or password incorrect";
                return View(login);
            }

        }
    }
}
