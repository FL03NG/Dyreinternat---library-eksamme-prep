using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Repository
{
    public class ActivityJsonRepo : ActivityCollectionRepo // Den arver fra "ActivityCollectionRepo"
    {
        // Constructor der automatisk loader data fra JSON-filen ved oprettelse
        public ActivityJsonRepo()
        {
            LoadFile();
        }

        // Indlæser aktivitetslisten fra JSON-filen og deserialiserer til _activity
        private void LoadFile()
        {
            string path = "Activity.Json";
            string json = File.ReadAllText(path);
            _activity = JsonSerializer.Deserialize<List<dyreinternat___library.Models.Activity>>(json);
        }

        // Overskriver Add-metoden og tilføjer en aktivitet samt gemmer den til JSON
        public override void Add(Models.Activity activity)
        {
            Debug.WriteLine("gemmer fil");
            base.Add(activity);
            SaveFile();
        }

        // Gemmer den aktuelle _activity-liste til JSON-filen
        private void SaveFile()
        {
            Debug.WriteLine("gemmer fil");
            string path = "Activity.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_activity));
        }

        // Overskriver Update-metoden og gemmer derefter ændringerne til JSON
        public override void Update(Models.Activity updatedActivity) // tilmeld
        {
            base.Update(updatedActivity);
            SaveFile();
        }

        // Overskriver Delete-metoden og gemmer derefter ændringerne til JSON
        public override void Delete(int id)
        {
            base.Delete(id);
            SaveFile();
        }
    }

}
