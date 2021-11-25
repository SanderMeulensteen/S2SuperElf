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
            return UserViewModelById(id);
        }
        // GET: UserController/MyProfile/5
        public ActionResult MyProfile(int id)
        {
            return UserProfileViewModelById(id);
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
            if (!ModelState.IsValid)
            {
                RegisterViewModel user = new RegisterViewModel();
                return View();
            }
            if (!_userContainer.EmailCheck(newUser.emailaddress))
            {
                ModelState.AddModelError("", "This email is already in use.");
                return View(newUser);
            }
            if (!_userContainer.UserNameCheck(newUser.userName))
            {
                ModelState.AddModelError("", "This username is already in use.");
                return View(newUser);
            }
            _userContainer.AddUser(newUser.emailaddress, newUser.userName, newUser.firstName,
                newUser.lastName, newUser.password, newUser.isAdmin, newUser.isModerator);
            return RedirectToAction("Login","Login");
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
            if (!ModelState.IsValid)
            {
                RegisterViewModel user = new RegisterViewModel();
                return View();
            }
            if (!_userContainer.EmailCheck(newUser.emailaddress))
            {
                ModelState.AddModelError("", "This email is already in use.");
                return View(newUser);
            }
            if (!_userContainer.UserNameCheck(newUser.userName))
            {
                ModelState.AddModelError("", "This username is already in use.");
                return View(newUser);
            }
            _userContainer.AddUser(newUser.emailaddress, newUser.userName, newUser.firstName,
                newUser.lastName, newUser.password, newUser.isAdmin, newUser.isModerator);
            return RedirectToAction("Index");
        }

        // GET: UserController/EditEmail/5
        public ActionResult EditEmail(int id)
        {
            return UserEditViewModelById(id);
        }

        // POST: UserController/EditEmail/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEmail(int userId, UserEditViewModel updatedUser)
        {
            if (!ModelState.IsValid)
            {
                return ReturnToUser(userId);
            }
            string newEmail = updatedUser.emailaddress;
            if (!_userContainer.EmailCheck(newEmail))
            {
                ModelState.AddModelError("", "This email is already in use.");
                return ReturnToUser(userId);
            }
            IUser user = _userContainer.GetUserById(userId);
            user.UpdateEmail(user, newEmail);
            if (userId == HttpContext.Session.GetInt32("_SessionUserId"))
            {
                return RedirectToAction("MyProfile", new {id = userId});
            }
            return RedirectToAction("Details", new {id = userId});
        }
        // GET: UserController/EditName/5
        public ActionResult EditName(int id)
        {
            return UserEditViewModelById(id);
        }

        // POST: UserController/EditName/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditName(int userId, UserEditViewModel updatedUser)
        {
            if (!ModelState.IsValid)
            {
                return ReturnToUser(userId);
            }

            string newFirstName = updatedUser.firstName;
            string newLastName = updatedUser.lastName;
            IUser user = _userContainer.GetUserById(userId);
            user.UpdateName(user, newFirstName, newLastName);
            if (userId == HttpContext.Session.GetInt32("_SessionUserId"))
            {
                return RedirectToAction("MyProfile", new {id = userId});
            }
            return RedirectToAction("Details", new {id = userId});
        }
        // GET: UserController/EditPermissions/5
        public ActionResult EditPermissions(int id)
        {
            return UserEditViewModelById(id);
        }

        // POST: UserController/EditPermissions/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPermissions(int userId, UserEditViewModel updatedUser)
        {
            if (!ModelState.IsValid)
            {
                return ReturnToUser(userId);
            }

            bool isAdmin = updatedUser.isAdmin;
            bool isModerator = updatedUser.isModerator;
            IUser user = _userContainer.GetUserById(userId);
            user.UpdatePermissions(user, isAdmin, isModerator);
            return RedirectToAction("Details", new {id = userId});
        }
        // GET: UserController/EditUserName/5
        public ActionResult EditUserName(int id)
        {
            return UserEditViewModelById(id);
        }

        // POST: UserController/EditUserName/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditUserName(int userId, UserEditViewModel updatedUser)
        {
            if (!ModelState.IsValid)
            {
                return ReturnToUser(userId);
            }
            string newUserName = updatedUser.userName;
            if (!_userContainer.UserNameCheck(newUserName))
            {
                ModelState.AddModelError("", "This username is already in use.");
                return ReturnToUser(userId);
            }
            IUser user = _userContainer.GetUserById(userId);
            user.UpdateUserName(user, newUserName);
            if (userId == HttpContext.Session.GetInt32("_SessionUserId"))
            {
                return RedirectToAction("MyProfile", new { id = userId });
            }
            return RedirectToAction("Details", new {id = userId});
        }
        // GET: UserController/EditPassword/5
        public ActionResult EditPassword(int id)
        {
            return UserEditViewModelById(id);
        }

        // POST: UserController/EditPassword/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPassword(int userId, UserEditViewModel updatedUser)
        {
            if (!ModelState.IsValid)
            {
                return ReturnToUser(userId);
            }

            string newPassword = updatedUser.password;
            IUser user = _userContainer.GetUserById(userId);
            user.UpdatePassword(user, newPassword);
            return RedirectToAction("MyProfile", new {id = userId});
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return UserViewModelById(id);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, UserViewModel user)
        {
            if (id == 0)
            {
                ModelState.AddModelError("", "Delete could not be processed, try again later.");
                return RedirectToAction("Index");
            }

            _userContainer.DeleteUser(id);
            return RedirectToAction("Index");
        }
        // Get userViewModel by id
        private ActionResult UserViewModelById(int id)
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
        // Get userEditViewModel by id
        private ActionResult UserEditViewModelById(int id)
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
        // Get UserProfileViewModel by id
        private ActionResult UserProfileViewModelById(int userId)
        {
            IUser userById = _userContainer.GetUserById(userId);
            UserProfileViewModel user = new UserProfileViewModel();
            user.userId = userById.userId;
            user.emailaddress = userById.emailaddress;
            user.userName = userById.userName;
            user.firstName = userById.firstName;
            user.lastName = userById.lastName;
            user.myTeam = userById.GetPlayersFromTeam(userById.userId).OrderBy(x => x.position).ToList();
            return View(user);
        }
        // Return correct user to view when an error occurs
        private ActionResult ReturnToUser(int userId)
        {
            ModelState.AddModelError("", "Update could not be processed, try again later.");
            return UserEditViewModelById(userId);
        }
    }
}
