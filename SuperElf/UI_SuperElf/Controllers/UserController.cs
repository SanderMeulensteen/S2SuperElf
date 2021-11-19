﻿using Microsoft.AspNetCore.Http;
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
                userViewModel.isAdmin = user.isAdmin;
                userViewModel.isModerator = user.isModerator;
                userPipeline.Users.Add(userViewModel);
            }
            return View(userPipeline);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            IUser userById = _userContainer.GetUserById(id);
            UserViewModel user = new UserViewModel();
            user.userId = userById.userId;
            user.emailaddress = userById.emailaddress;
            user.userName = userById.userName;
            user.firstName = userById.firstName;
            user.lastName = userById.lastName;
            user.isAdmin = userById.isAdmin;
            user.isModerator = userById.isModerator;
            return View(user);
        }

        // GET: UserController/Register
        public ActionResult Register()
        {
            RegisterViewModel registerUser = new RegisterViewModel();
            return View(registerUser);
        }

        // POST: UserController/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                if (_userContainer.EmailCheck(newUser.emailaddress))
                {
                    if (_userContainer.UserNameCheck(newUser.userName))
                    {
                        _userContainer.AddUser(newUser.emailaddress, newUser.userName, newUser.firstName, newUser.lastName,
                            newUser.password, newUser.isAdmin, newUser.isModerator);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "This username is already in use.");
                        return View(newUser);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "This email is already in use.");
                    return View(newUser);
                }
            }
            else
            {
                return View(newUser);
            }
        }
        // GET: UserController/Create
        public ActionResult Create()
        {
            RegisterViewModel registerUser = new RegisterViewModel();
            return View(registerUser);
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                if (_userContainer.EmailCheck(newUser.emailaddress))
                {
                    if(_userContainer.UserNameCheck(newUser.userName))
                    {
                        _userContainer.AddUser(newUser.emailaddress, newUser.userName, newUser.firstName, newUser.lastName, newUser.password, newUser.isAdmin, newUser.isModerator);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "This username is already in use.");
                        return View(newUser);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "This email is already in use.");
                    return View(newUser);
                }
            }
            else
            {
                return View(newUser);
            }
        }

        // GET: UserController/EditEmail/5
        public ActionResult EditEmail(int id)
        {
            IUser userById = _userContainer.GetUserById(id);
            UserEditViewModel user = new UserEditViewModel();
            user.userId = userById.userId;
            user.emailaddress = userById.emailaddress;
            user.userName = userById.userName;
            user.firstName = userById.firstName;
            user.lastName = userById.lastName;
            user.isAdmin = userById.isAdmin;
            user.isModerator = userById.isModerator;
            user.password = "";
            return View(user);
        }

        // POST: UserController/EditEmail/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEmail(int userId, UserEditViewModel updatedUser)
        {
            if (ModelState.IsValid)
            {
                string newEmail = updatedUser.emailaddress;
                if (_userContainer.EmailCheck(newEmail))
                {
                    _user.UpdateEmail(userId, newEmail);
                    return RedirectToAction("Details", new { id = userId });
                }
                else
                {
                    ModelState.AddModelError("", "This email is already in use.");
                    updatedUser.userId = userId;
                    return View(updatedUser);
                }
            }
            else
            {
                updatedUser.userId = userId;
                return View(updatedUser);
            }
        }
        // GET: UserController/EditName/5
        public ActionResult EditName(int id)
        {
            IUser userById = _userContainer.GetUserById(id);
            UserEditViewModel user = new UserEditViewModel();
            user.userId = userById.userId;
            user.emailaddress = userById.emailaddress;
            user.userName = userById.userName;
            user.firstName = userById.firstName;
            user.lastName = userById.lastName;
            user.isAdmin = userById.isAdmin;
            user.isModerator = userById.isModerator;
            user.password = "";
            return View(user);
        }

        // POST: UserController/EditName/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditName(int userId, UserEditViewModel updatedUser)
        {
            if (ModelState.IsValid)
            {
                string newFirstName = updatedUser.firstName;
                string newLastName = updatedUser.lastName;
                _user.UpdateName(userId, newFirstName, newLastName);
                return RedirectToAction("Details", new { id = userId });
            }
            else
            {
                updatedUser.userId = userId;
                return View(updatedUser);
            }
        }
        // GET: UserController/EditPermissions/5
        public ActionResult EditPermissions(int id)
        {
            IUser userById = _userContainer.GetUserById(id);
            UserEditViewModel user = new UserEditViewModel();
            user.userId = userById.userId;
            user.emailaddress = userById.emailaddress;
            user.userName = userById.userName;
            user.firstName = userById.firstName;
            user.lastName = userById.lastName;
            user.isAdmin = userById.isAdmin;
            user.isModerator = userById.isModerator;
            user.password = "";
            return View(user);
        }

        // POST: UserController/EditPermissions/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPermissions(int userId, UserEditViewModel updatedUser)
        {
            if (ModelState.IsValid)
            {
                bool isAdmin = updatedUser.isAdmin;
                bool isModerator = updatedUser.isModerator;
                _user.UpdatePermissions(userId, isAdmin, isModerator);
                return RedirectToAction("Details", new { id = userId });
            }
            else
            {
                updatedUser.userId = userId;
                return View(updatedUser);
            }
        }
        // GET: UserController/EditUserName/5
        public ActionResult EditUserName(int id)
        {
            IUser userById = _userContainer.GetUserById(id);
            UserEditViewModel user = new UserEditViewModel();
            user.userId = userById.userId;
            user.emailaddress = userById.emailaddress;
            user.userName = userById.userName;
            user.firstName = userById.firstName;
            user.lastName = userById.lastName;
            user.isAdmin = userById.isAdmin;
            user.isModerator = userById.isModerator;
            user.password = "";
            return View(user);
        }

        // POST: UserController/EditUserName/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditUserName(int userId, UserEditViewModel updatedUser)
        {
            if (ModelState.IsValid)
            {
                string newUserName = updatedUser.userName;
                if (_userContainer.UserNameCheck(newUserName))
                {
                    _user.UpdateUserName(userId, newUserName);
                    return RedirectToAction("Details", new { id = userId });
                }
                else
                {
                    ModelState.AddModelError("", "This username is already in use.");
                    updatedUser.userId = userId;
                    return View(updatedUser);
                }
            }
            else
            {
                updatedUser.userId = userId;
                return View(updatedUser);
            }
        }
        // GET: UserController/EditPassword/5
        public ActionResult EditPassword(int id)
        {
            IUser userById = _userContainer.GetUserById(id);
            UserEditViewModel user = new UserEditViewModel();
            user.userId = userById.userId;
            user.emailaddress = userById.emailaddress;
            user.userName = userById.userName;
            user.firstName = userById.firstName;
            user.lastName = userById.lastName;
            user.isAdmin = userById.isAdmin;
            user.isModerator = userById.isModerator;
            user.password = "";
            return View(user);
        }

        // POST: UserController/EditPassword/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPassword(int userId, UserEditViewModel updatedUser)
        {
            if (ModelState.IsValid)
            {
                string newPassword = updatedUser.password;
                _user.UpdatePassword(userId, newPassword);
                return RedirectToAction("", new { id = userId });
            }
            else
            {
                updatedUser.userId = userId;
                return View(updatedUser);
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            IUser userById = _userContainer.GetUserById(id);
            UserViewModel user = new UserViewModel();
            user.userId = userById.userId;
            user.emailaddress = userById.emailaddress;
            user.userName = userById.userName;
            user.firstName = userById.firstName;
            user.lastName = userById.lastName;
            user.isAdmin = userById.isAdmin;
            user.isModerator = userById.isModerator;
            return View(user);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, UserViewModel user)
        {
            if (id == 0)
            {
                return View(user);
            }
            else
            {
                _userContainer.DeleteUser(id);
                return RedirectToAction("Index");
            }
        }
    }
}
