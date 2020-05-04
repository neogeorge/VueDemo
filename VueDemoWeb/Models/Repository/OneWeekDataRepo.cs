using System.Collections.Generic;
using System.Linq;
using VueDemoWeb.Models.DataBase;
using VueDemoWeb.Models.Interface.Reposoitory;

namespace VueDemoWeb.Models.Repository
{
    public class OneWeekDataRepo : BaseRepo, IOneWeekDataRepo
    {
        public int AddRange(List<OneWeekData> list)
        {
            db.OneWeekData.AddRange(list);
            var result = db.SaveChanges();
            return result;
        }
    }
}