using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public interface IDocJournalRepo
    {
        public List<DocJournal> GetAll();

        public void Add(DocJournal docJournal);

        public void Delete(int id);



    }
}
