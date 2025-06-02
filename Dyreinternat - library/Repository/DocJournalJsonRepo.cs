using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    // Repository der håndterer lagring og hentning af lægelogs (DocJournal) fra en JSON-fil
    public class DocJournalJsonRepo : DocJournalCollectionRepo
    {
        // Constructor der loader lægelogs fra JSON ved oprettelse
        public DocJournalJsonRepo()
        {
            LoadFile();
        }

        // Indlæser DocJournal-data fra JSON-filen og deserialiserer til _docJournal-listen
        private void LoadFile()
        {
            string path = "DocJournal.Json";
            string json = File.ReadAllText(path);
            _docJournal = JsonSerializer.Deserialize<List<DocJournal>>(json);
        }

        // Tilføjer en lægelog og gemmer den i JSON-filen
        public override void Add(dyreinternat___library.Models.DocJournal docJournal)
        {
            Debug.WriteLine("gemmer blog fil");
            base.Add(docJournal);
            SaveFile();
        }

        // Gemmer hele listen af DocJournal til JSON-filen
        private void SaveFile()
        {
            Debug.WriteLine("gemmer docJournal fil");
            string path = "DocJournal.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_docJournal));
        }

        // Sletter en lægelog og opdaterer JSON-filen
        public override void Delete(int id)
        {
            base.Delete(id);
            SaveFile();
        }
    }
}

