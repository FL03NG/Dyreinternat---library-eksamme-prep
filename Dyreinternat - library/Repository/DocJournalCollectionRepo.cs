using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class DocJournalCollectionRepo : IDocJournalRepo //implementerer et interface
    {
        public List<DocJournal> _docJournal; //en liste der indenholder objecterne fra "DocJournal" klassen

        public DocJournalCollectionRepo() //en konstruktør der initialiserer "_docJournal" som en ny tom liste
        {
            _docJournal = new List<DocJournal>();

        }

        public virtual void Add(DocJournal docJournal) //virtuel tiladder denne metode at blive "overriden" i en subklasse
        {
            Debug.WriteLine("add docJournal");
            _docJournal.Add(docJournal); //tilføjer et "DocJournal" objekt til "_docJournal" listen
        }

        public List<DocJournal> GetAll() //returnere hele "_docJournal" listen
        {
            return _docJournal;
        }
        public virtual void Delete(int id) //fjerner en DocJournal fra listen baseret på id
        {
            DocJournal DocLogToRemove = null; // initialiserer "DocLogToRemove" som "null"

            foreach (DocJournal d in _docJournal)  //løber igennem hver "DocJournal" objekt i "_docJournal" listen. det valgte objekt bliver forløbeligt navngivet "d"
            {
                if (d.DocJournalID == id) //tjekker om det valgte id matcher med det i parametren
                {
                    DocLogToRemove = d; //hvis det gør 
                    break; //stopper den med at løbe igennem
                }
            }

            if (DocLogToRemove != null) //hvis en matching DocJournal blev fundet
            {
                _docJournal.Remove(DocLogToRemove); //bliver den slettet fra listen
            }
        }


    }
}
