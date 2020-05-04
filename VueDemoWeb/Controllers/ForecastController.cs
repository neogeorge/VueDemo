using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VueDemoWeb.Models.DataBase;
using VueDemoWeb.Models.Interface.Service;
using VueDemoWeb.Models.Service;

namespace VueDemoWeb.Controllers
{
    public class ForecastController : BaseController
    {
        private IThreeDayDataService _iThreeDayDataService;
        private IOneWeekDataService _iOneWeekDataService;

        public ForecastController()
        {
            _iThreeDayDataService = new ThreeDayDataService();
            _iOneWeekDataService = new OneWeekDataService();
        }

        /// <summary>
        /// 未來3天天氣預報
        /// </summary>
        /// <param name="country">各臺灣城市代碼</param>
        /// <returns></returns>
        [HttpGet]
        [VueAuthorize]
        public ActionResult ThreeDay(string country = "")
        {
            GetThreeDayTempData(country);
            return View();
        }

        [HttpPost]
        public ActionResult ThreeDaySave(List<ThreeDayData> list)
        {
            int iCount = _iThreeDayDataService.AddRange(list);
            return Json(iCount);
        }

        /// <summary>
        /// 未來1週天氣預報
        /// </summary>
        /// <param name="country">各臺灣城市代碼</param>
        /// <returns></returns>
        [HttpGet]
        [VueAuthorize]
        public ActionResult OneWeek(string country = "")
        {
            GetOneWeekTempData(country);
            return View();
        }

        [HttpPost]
        public ActionResult OneWeekSave(List<OneWeekData> list)
        {
            int iCount = _iOneWeekDataService.AddRange(list);
            return Json(iCount);
        }
    }
}