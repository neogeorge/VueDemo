using System.Configuration;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VueDemoWeb
{
    public class VueAuthorize : AuthorizeAttribute
    {
        private string gotoController, gotoAction, gotoId, rountAction;
        private bool successAuthorize = false;
        private bool gotoHome = false;

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //return base.AuthorizeCore(httpContext);

            gotoHome = false;

            if ((httpContext.Session["VueLogin"] != null
                && !string.IsNullOrEmpty(httpContext.Session["VueLogin"].ToString()))
                || ConfigurationManager.AppSettings["IsNeedLogin"].ToString() == "N")
            {
                successAuthorize = true;
            }
            else
            {
                successAuthorize = false;
            }

            return successAuthorize;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            gotoController = filterContext.RouteData.Values["Controller"].ToString();
            gotoAction = filterContext.RouteData.Values["Action"].ToString();
            gotoId = filterContext.RouteData.Values["Id"] == null ? "" : filterContext.RouteData.Values["Id"].ToString();

            base.OnAuthorization(filterContext);

            if (gotoHome || ConfigurationManager.AppSettings["IsNeedLogin"].ToString() == "N")
            {
                rountAction = "Index";
            }
            else
            {
                rountAction = "LogOut";
            }

            if (!successAuthorize)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(
                    new
                    {
                        controller = "Home",
                        action = rountAction,
                        fromController = gotoController,
                        fromAction = gotoAction,
                        fromId = gotoId
                    }
                ));
            }
        }
    }
}