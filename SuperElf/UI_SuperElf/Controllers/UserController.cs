using Microsoft.AspNetCore.Http;
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
    public class UserController : Controller
    {
        private readonly IUser _user = User_Factory.CreateUser();
        private readonly IUserContainer _userContainer = UserContainer_Factory.CreateUserContainer();
        // GET: UserController
        public ActionResult Index()
        {
            UserPipeline userPipeline = new UserPipeline();
            List<IUser> users = _userContainer.GetAllUsers();
            foreach (IUser user in users)
            {
                UserViewModel userViewModel = new UserViewModel();
                userViewModel.userId = user.userId;
                userViewModel.firstName = user.firstName;
                userViewModel.lastName = user.lastName;
                userViewModel.userName = user.userName;
                userViewModel.emailaddress = user.emailaddress;
                userViewModel.password = user.password;
                userViewModel.isAdmin = user.isAdmin;
                userViewModel.isModerator = user.isModerator;
                userPipeline.Users.Add(userViewModel);
            }
            return View(userPipeline);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: UserController/Create
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
