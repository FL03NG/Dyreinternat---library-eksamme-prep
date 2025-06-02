using System.Diagnostics;
using System.Text.Json;
using dyreinternat___library.Models;
//using dyreinternat___web.Pages;

using System.Diagnostics;
using System.Text.Json;
using dyreinternat___library.Models;
//using dyreinternat___web.Pages;

namespace dyreinternat___library.Repository
{
    // Repository der håndterer lagring og hentning af dyr fra en JSON-fil
    public class AnimalJsonRepo : AnimalCollectionRepo
    {
        // Constructor der automatisk loader data fra JSON ved oprettelse
        public AnimalJsonRepo()
        {
            LoadFile();
        }

        // Indlæser dyr fra JSON-filen og deserialiserer til _animals-listen
        private void LoadFile()
        {
            string path = "Animal.Json";
            string json = File.ReadAllText(path);
            _animals = JsonSerializer.Deserialize<List<Animal>>(json);
        }

        // Tilføjer et dyr til listen og gemmer det i JSON-filen
        public override void Add(Animal animal)
        {
            Debug.WriteLine("gemmer fil");
            base.Add(animal);
            SaveFile();
        }

        // Gemmer hele listen af dyr til JSON-filen
        private void SaveFile()
        {
            Debug.WriteLine("gemmer fil");
            string path = "Animal.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_animals));
        }

        // Sletter et dyr og opdaterer JSON-filen
        public override void Delete(int id)
        {
            base.Delete(id);
            SaveFile();
        }
    }
}

