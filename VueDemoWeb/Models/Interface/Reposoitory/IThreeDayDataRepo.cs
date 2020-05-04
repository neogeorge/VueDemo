using System.Collections.Generic;
using VueDemoWeb.Models.DataBase;

namespace VueDemoWeb.Models.Interface.Reposoitory
{
    public interface IThreeDayDataRepo
    {
        int AddRange(List<ThreeDayData> list);
    }
}
