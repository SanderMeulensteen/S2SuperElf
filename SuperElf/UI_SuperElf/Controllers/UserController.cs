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
        private readonly IUser user = User_Factory.CreateUser();
        private readonly IUserContainer userContainer = UserContainer_Factory.CreateUserContainer();
        // GET: UserController
        public ActionResult Index()
        {
            UserPipeline userPipeline = new UserPipeline();
            List<IUser> users = userContainer.GetAllUsers();
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
            IUser userById = userContainer.GetUserById(id);
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
                if (userContainer.EmailCheck(newUser.emailaddress))
                {
                    if (userContainer.UserNameCheck(newUser.userName))
                    {
                        userContainer.AddUser(newUser.emailaddress, newUser.userName, newUser.firstName, newUser.lastName,
                            newUser.password, newUser.isAdmin, newUser.isModerator);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.error = "This username is already in use!";
                        return View(newUser);
                    }
                }
                else
                {
                    ViewBag.error = "This email address is already in use!";
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
                if (userContainer.EmailCheck(newUser.emailaddress))
                {
                    if(userContainer.UserNameCheck(newUser.userName))
                    {
                        userContainer.AddUser(newUser.emailaddress, newUser.userName, newUser.firstName, newUser.lastName, newUser.password, newUser.isAdmin, newUser.isModerator);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.error = "This username is already in use!";
                        return View(newUser);
                    }
                }
                else
                {
                    ViewBag.error = "This email address is already in use!";
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
            IUser userById = userContainer.GetUserById(id);
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
        public ActionResult EditEmail(int id, UserEditViewModel updatedUser)
        {
            if (ModelState.IsValid)
            {
                string newEmail = updatedUser.emailaddress;
                if (userContainer.EmailCheck(newEmail))
                {
                    user.UpdateEmail(id, newEmail);
                    return RedirectToAction("Details", new { id = id });
                }
                else
                {
                    ViewBag.error = "This email address is already in use!";
                    updatedUser.userId = id;
                    return View(updatedUser);
                }
            }
            else
            {
                updatedUser.userId = id;
                return View(updatedUser);
            }
        }
        // GET: UserController/EditName/5
        public ActionResult EditName(int id)
        {
            IUser userById = userContainer.GetUserById(id);
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
        public ActionResult EditName(int id, UserEditViewModel updatedUser)
        {
            if (ModelState.IsValid)
            {
                string newFirstName = updatedUser.firstName;
                string newLastName = updatedUser.lastName;
                user.UpdateName(id, newFirstName, newLastName);
                return RedirectToAction("Details", new { id = id });
            }
            else
            {
                updatedUser.userId = id;
                return View(updatedUser);
            }
        }
        // GET: UserController/EditPermissions/5
        public ActionResult EditPermissions(int id)
        {
            IUser userById = userContainer.GetUserById(id);
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
        public ActionResult EditPermissions(int id, UserEditViewModel updatedUser)
        {
            if (ModelState.IsValid)
            {
                bool isAdmin = updatedUser.isAdmin;
                bool isModerator = updatedUser.isModerator;
                user.UpdatePermissions(id, isAdmin, isModerator);
                return RedirectToAction("Details", new { id = id });
            }
            else
            {
                updatedUser.userId = id;
                return View(updatedUser);
            }
        }
        // GET: UserController/EditUserName/5
        public ActionResult EditUserName(int id)
        {
            IUser userById = userContainer.GetUserById(id);
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
        public ActionResult EditUserName(int id, UserEditViewModel updatedUser)
        {
            if (ModelState.IsValid)
            {
                string newUserName = updatedUser.userName;
                if (userContainer.UserNameCheck(newUserName))
                {
                    user.UpdateUserName(id, newUserName);
                    return RedirectToAction("Details", new { id = id });
                }
                else
                {
                    ViewBag.error = "This username is already in use!";
                    updatedUser.userId = id;
                    return View(updatedUser);
                }
            }
            else
            {
                updatedUser.userId = id;
                return View(updatedUser);
            }
        }
        // GET: UserController/EditPassword/5
        public ActionResult EditPassword(int id)
        {
            IUser userById = userContainer.GetUserById(id);
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
        public ActionResult EditPassword(int id, UserEditViewModel updatedUser)
        {
            if (ModelState.IsValid)
            {
                string newPassword = updatedUser.password;
                user.UpdatePassword(id, newPassword);
                return RedirectToAction("", new { id = id });
            }
            else
            {
                updatedUser.userId = id;
                return View(updatedUser);
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            IUser userById = userContainer.GetUserById(id);
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
                userContainer.DeleteUser(id);
                return RedirectToAction("Index");
            }
        }
    }
}
