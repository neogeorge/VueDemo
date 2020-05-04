using System.Collections.Generic;
using VueDemoWeb.Models.DataBase;
using VueDemoWeb.Models.Interface.Reposoitory;
using VueDemoWeb.Models.Interface.Service;
using VueDemoWeb.Models.Repository;

namespace VueDemoWeb.Models.Service
{
    public class ThreeDayDataService : IThreeDayDataService
    {
        private IThreeDayDataRepo _iThreeDayDataRepo;

        public ThreeDayDataService()
        {
            _iThreeDayDataRepo = new ThreeDayDataRepo();
        }

        public int AddRange(List<ThreeDayData> list)
        {
            return _iThreeDayDataRepo.AddRange(list);
        }
    }
}