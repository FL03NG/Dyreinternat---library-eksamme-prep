using System.Diagnostics;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class ActivityCollectionRepo : IActivityRepo //implementerer et interface
    {
        public List<Models.Activity> _activity; //en liste der indenholder objecterne fra Activity klassen

        public ActivityCollectionRepo() //en konstruktør der initialiserer _activity som en ny tom liste 
        {
            _activity = new List<Models.Activity>(); 

        }

        public virtual void Add(Models.Activity activity) //virtuel tiladder denne metode at blive "overriden" i en subklasse
        {
            Debug.WriteLine("add2");
            _activity.Add(activity); //tilføjer et "Activity" objekt til "_activity" listen
        }

        public List<Models.Activity> GetAll() //returnere hele "_activity" listen
        {
            return _activity;
        }
        public Models.Activity Get(int id) //søger listen for et matchende id og returnerer det eller null hvis intet er fundet. Dette bliver brugt til tilmeld
        {
            foreach (Models.Activity activity in _activity)
            {
                if (id == activity.ID)
                {
                    return activity;
                }
            }
            return null;
        }
        public virtual void Delete(int id) //fjerner en aktivitet fra listen baseret på id
        {
            Models.Activity activityToRemove = null; // initialiserer "activityToRemove" som "null"

            foreach (Models.Activity d in _activity) //løber igennem hver "Activity" objekt i "_activity" listen. det valgte objekt bliver forløbeligt sat til "d"
            {
                if (d.ID == id) //tjekker om det valgte id matcher med det i parametren 
                {
                    activityToRemove = d; //hvis det gør,  
                    break; //stopper den med at løbe igennem.
                }
            }

            if (activityToRemove != null) //hvis en matching aktivitet blev fundet,
            {
                _activity.Remove(activityToRemove); //bliver den slettet fra listen.
            }
        }
        public virtual void Update(Models.Activity updatedActivity) // virtual tillader override //erstatter den activity med det samme id med den nye "updatedActivity"
        {
            for (int i = 0; i < _activity.Count; i++)
            {
                if (_activity[i].ID == updatedActivity.ID)
                {
                    _activity[i] = updatedActivity;
                    break;
                }
            }
        }
    }
}
