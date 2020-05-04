using System.Collections.Generic;
using VueDemoWeb.Models.DataBase;
using VueDemoWeb.Models.Interface.Reposoitory;
using VueDemoWeb.Models.Interface.Service;
using VueDemoWeb.Models.Repository;
namespace VueDemoWeb.Models.Service
{
    public class OneWeekDataService : IOneWeekDataService
    {
        private IOneWeekDataRepo _iOneWeekDataRepo;

        public OneWeekDataService()
        {
            _iOneWeekDataRepo = new OneWeekDataRepo();
        }

        public int AddRange(List<OneWeekData> list)
        {
            return _iOneWeekDataRepo.AddRange(list);
        }
    }
}