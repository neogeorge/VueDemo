using System.Collections.Generic;
using VueDemoWeb.Models.DataBase;

namespace VueDemoWeb.Models.Interface.Reposoitory
{
    public interface IOneWeekDataRepo
    {
        int AddRange(List<OneWeekData> list);
    }
}
