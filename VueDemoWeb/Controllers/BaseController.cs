using System.Web.Mvc;
using System.Web.Routing;
using VueDemoWeb.Models.ViewModel;

namespace VueDemoWeb.Controllers
{
    public class BaseController : Controller
    {
        private string currentController;
        private string currentAction;
        private string currentId;
        private AccountViewModels _UserInfo;

        public AccountViewModels UserInfo
        {
            get
            {
                if (Session["VueLogin"] != null)
                {
                    return (AccountViewModels)Session["VueLogin"];
                }
                return null;
            }
            set
            {
                _UserInfo = value;
            }
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            currentController = this.RouteData.Values["Controller"].ToString();
            currentAction = this.RouteData.Values["Action"].ToString();
            currentId = this.RouteData.Values["Id"] == null ? "" : this.RouteData.Values["Id"].ToString();
        }

        /// <summary>
        /// 各臺灣城市未來3天天氣預報
        /// </summary>
        /// <param name="strCountry"></param>
        public void GetThreeDayTempData(string strCountry)
        {
            string strTitle = string.Empty;
            string strUrl = string.Empty;
            switch (strCountry)
            {
                case "KLU": //基隆市
                    strTitle = "基隆市未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-049?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "TPH": //新北市(臺北縣)
                    strTitle = "新北市未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-069?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "KYC": //桃園市
                    strTitle = "桃園市未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-005?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "HSC": //新竹市
                    strTitle = "新竹市未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-053?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "HSH": //新竹縣
                    strTitle = "新竹縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-009?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "MAL": //苗栗縣
                    strTitle = "苗栗縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-013?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "TXG": //臺中市
                    strTitle = "臺中市未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-073?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "CWH": //彰化縣
                    strTitle = "彰化縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-017?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "NTO": //南投縣
                    strTitle = "南投縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-021?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "YUN": //雲林縣
                    strTitle = "雲林縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-025?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "CYI": //嘉義市
                    strTitle = "嘉義市未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-057?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "CHY": //嘉義縣
                    strTitle = "嘉義縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-029?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "TNN": //臺南市
                    strTitle = "臺南市未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-077?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "KHH": //高雄市
                    strTitle = "高雄市未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-065?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "PCH": //屏東縣
                    strTitle = "屏東縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-033?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "ILN": //宜蘭縣
                    strTitle = "宜蘭縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-001?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "TTT": //臺東縣
                    strTitle = "臺東縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-037?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "HUA": //花蓮縣
                    strTitle = "花蓮縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-041?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "PEH": //澎湖縣
                    strTitle = "澎湖縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-045?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "LNN": //連江縣
                    strTitle = "連江縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-081?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "KMN": //金門縣
                    strTitle = "金門縣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-085?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "TWN": //臺灣
                    strTitle = "臺灣未來3天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-089?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                default: //TPE 臺北市
                    strTitle = "臺北市未來2天天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-061?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
            }
            TempData["Temp_VueDemoTitle"] = strTitle;
            TempData["Temp_VueDemoUrl"] = strUrl;
            TempData["Temp_VueDemoCountry"] = !string.IsNullOrEmpty(strCountry) ? "TPE" : strCountry;
        }

        /// <summary>
        /// 各臺灣城市未來1週天氣預報
        /// </summary>
        /// <param name="strCountry">各臺灣城市代碼</param>
        public void GetOneWeekTempData(string strCountry)
        {
            string strTitle = string.Empty;
            string strUrl = string.Empty;
            switch (strCountry)
            {
                case "KLU": //基隆市
                    strTitle = "基隆市未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-051?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "TPH": //新北市(臺北縣)
                    strTitle = "新北市未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-071?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "KYC": //桃園市
                    strTitle = "桃園市未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-007?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "HSC": //新竹市
                    strTitle = "新竹市未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-055?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "HSH": //新竹縣
                    strTitle = "新竹縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-011?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "MAL": //苗栗縣
                    strTitle = "苗栗縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-015?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "TXG": //臺中市
                    strTitle = "臺中市未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-075?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "CWH": //彰化縣
                    strTitle = "彰化縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-019?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "NTO": //南投縣
                    strTitle = "南投縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-023?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "YUN": //雲林縣
                    strTitle = "雲林縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-027?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "CYI": //嘉義市
                    strTitle = "嘉義市未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-059?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "CHY": //嘉義縣
                    strTitle = "嘉義縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-031?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "TNN": //臺南市
                    strTitle = "臺南市未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-079?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "KHH": //高雄市
                    strTitle = "高雄市未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-067?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "PCH": //屏東縣
                    strTitle = "屏東縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-035?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "ILN": //宜蘭縣
                    strTitle = "宜蘭縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-003?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "TTT": //臺東縣
                    strTitle = "臺東縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-039?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "HUA": //花蓮縣
                    strTitle = "花蓮縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-043?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "PEH": //澎湖縣
                    strTitle = "澎湖縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-047?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "LNN": //連江縣
                    strTitle = "連江縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-083?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "KMN": //金門縣
                    strTitle = "金門縣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-087?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                case "TWN": //臺灣
                    strTitle = "臺灣未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-091?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
                default: //TPE 臺北市
                    strTitle = "臺北市未來1週天氣預報";
                    strUrl = "https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-063?Authorization=CWB-47ED5C39-AA7A-4475-A494-DA398493609E&format=JSON&elementName=T";
                    break;
            }
            TempData["Temp_VueDemoTitle"] = strTitle;
            TempData["Temp_VueDemoUrl"] = strUrl;
            TempData["Temp_VueDemoCountry"] = !string.IsNullOrEmpty(strCountry) ? "TPE" : strCountry;
        }
    }
}