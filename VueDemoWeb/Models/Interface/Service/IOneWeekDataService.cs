using System.Collections.Generic;
using VueDemoWeb.Models.DataBase;

namespace VueDemoWeb.Models.Interface.Service
{
    public interface IOneWeekDataService
    {
        int AddRange(List<OneWeekData> list);
    }
}
