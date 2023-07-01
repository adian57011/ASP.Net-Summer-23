using FormValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormValidation.Controllers
{
    public class HomeController : Controller
    {
       [HttpGet]
       public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserDto user)
        {
            if(ModelState.IsValid)
            {
               return RedirectToAction("Home");
            }
            return View(user);
        }

        public ActionResult Home(UserDto user)
        {
            return View(user);
        }
    }
}