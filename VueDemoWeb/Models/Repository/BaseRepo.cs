using VueDemoWeb.Models.DataBase;

namespace VueDemoWeb.Models.Repository
{
    public class BaseRepo
    {
        public VueDemoDBEntities _db;

        public VueDemoDBEntities db
        {
            get
            {
                if (_db == null)
                {
                    _db = new VueDemoDBEntities();
                }
                return _db;
            }
            set
            {
                _db = value;
            }
        }
    }
}