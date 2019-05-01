using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Divar.Core.Services;
using Divar.Core.Interfaces;
using Divar.Core.ViewModels;

namespace Divar.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private IUser _iuser;

        public ProfileController(IUser iuser)
        {
            _iuser = iuser;
        }

        public IActionResult Index()
        {
            ViewBag.MyId = _iuser.GetUserId(User.Identity.Name);

            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel change)
        {
            if (ModelState.IsValid)
            {
                string userName = User.Identity.Name;
                
                if (_iuser.ChangePassword(userName, change.CurrentPassword, change.Password))
                {
                    return RedirectToAction("SignOut", "Account");
                }
                else
                {
                    ModelState.AddModelError("CurrentPassword", "کلمه عبور جاری صحیح نمی باشد");

                    return View(change);
                }
            }
            else
            {
                return View(change);
            }
        }
    }
}