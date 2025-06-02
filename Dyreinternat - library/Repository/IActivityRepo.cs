using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    // Interface til håndtering af aktiviteter i et repository
    public interface IActivityRepo
    {
        // Returnerer en liste med alle aktiviteter
        public List<Activity> GetAll();

        // Tilføjer en ny aktivitet til repository
        public void Add(Activity events);

        // Returnerer en specifik aktivitet ud fra ID
        public Activity Get(int id);

        // Sletter en aktivitet ud fra ID
        public void Delete(int id);

        // Opdaterer en eksisterende aktivitet
        void Update(Activity updatedActivity);
    }
}

