using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Services
{
    // Serviceklasse der håndterer logik for aktiviteter og kommunikerer med repository via interface
    public class ActivityService
    {
        // Repository-interface til aktiviteter
        private IActivityRepo _activityrepo;

        // Constructor der modtager et repository via dependency injection
        public ActivityService(IActivityRepo activityrepo)
        {
            _activityrepo = activityrepo;
        }

        // Tilføjer en aktivitet via repository
        public void Add(Activity events)
        {
            _activityrepo.Add(events);
        }

        // Henter alle aktiviteter via repository
        public List<Activity> GetAll()
        {
            return _activityrepo.GetAll();
        }

        // Henter en specifik aktivitet via ID
        public Activity Get(int id)
        {
            return _activityrepo.Get(id);
        }

        // Opdaterer en aktivitet via repository
        public void Update(Activity activity)
        {
            _activityrepo.Update(activity);
        }

        // Sletter en aktivitet via ID
        public void Delete(int id)
        {
            _activityrepo.Delete(id);
        }
    }
}
