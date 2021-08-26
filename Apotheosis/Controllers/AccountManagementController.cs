using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apotheosis.Controllers
{
    public class AccountManagementController : Controller
    {
        // GET: AccountManagement
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogIn(FormCollection formCollection)
        {

            return Redirect("Home/Index");
        }
    }
}