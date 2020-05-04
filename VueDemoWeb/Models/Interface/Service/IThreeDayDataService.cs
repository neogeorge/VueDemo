using System.Collections.Generic;
using VueDemoWeb.Models.DataBase;

namespace VueDemoWeb.Models.Interface.Service
{
    public interface IThreeDayDataService
    {
        int AddRange(List<ThreeDayData> list);
    }
}
