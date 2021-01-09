using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCWebApp.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Members model)
        {
            Employeecontext _DbCon = new Employeecontext();
            bool isValid = _DbCon.userset.Any(x => x.Username == model.Username && x.Password == model.Password);
            if (isValid)
            {
                FormsAuthentication.SetAuthCookie(model.Username, false);
                return RedirectToAction("Create", "Home");
            }
            else
            {
                ViewBag.Message = "Enter valid Email or Password";
            }
            return View();
        }


    }
}