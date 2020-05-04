using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueDemoWeb.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
	}
}