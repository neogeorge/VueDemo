using System.Collections.Generic;
using System.Linq;
using VueDemoWeb.Models.DataBase;
using VueDemoWeb.Models.Interface.Reposoitory;

namespace VueDemoWeb.Models.Repository
{
    public class ThreeDayDataRepo : BaseRepo, IThreeDayDataRepo
    {
        public int AddRange(List<ThreeDayData> list)
        {
            db.ThreeDayData.AddRange(list);
            var result = db.SaveChanges();
            return result;
        }
    }
}