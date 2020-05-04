using System.Web.Mvc;
using VueDemoWeb.Models.ViewModel;

namespace VueDemoWeb.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet]
        [VueAuthorize]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LogOut(string fromController, string fromAction, string fromId)
        {
            var login = (AccountViewModels)Session["GHLogin"];
            if (login != null)
            {
                var userHostAddress = Request.UserHostAddress;
                var xForwardedFor = Request.ServerVariables["X_FORWARDED_FOR"];
                string ip = IPHelper.GetClientIpAddress(userHostAddress, xForwardedFor);
            }

            Session.RemoveAll();

            string redirectUrl = "";
            if (!TempData.ContainsKey("RedirectUrl"))
            {
                redirectUrl = string.Format("/{0}/{1}", fromController, fromAction);
                if (!string.IsNullOrEmpty(fromId))
                {
                    redirectUrl = string.Concat(redirectUrl, "/", fromId);
                }
                TempData["RedirectUrl"] = redirectUrl;
            }

            return RedirectToAction("Login", "Account");
        }
    }
}