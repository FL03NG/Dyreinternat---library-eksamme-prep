using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Services
{
    public class DocJournalService
    {
        private IDocJournalRepo _docJournalRepo;

        public DocJournalService(IDocJournalRepo docJournalRepo)
        {
            _docJournalRepo = docJournalRepo; 
        }
        public void Add(DocJournal docJournal)
        {
            _docJournalRepo.Add(docJournal);
        }
        public List<DocJournal> GetAll()
        {
            return _docJournalRepo.GetAll();
        }
        public void Delete(int animalID)
        {
            _docJournalRepo.Delete(animalID);
        }

    }
}
