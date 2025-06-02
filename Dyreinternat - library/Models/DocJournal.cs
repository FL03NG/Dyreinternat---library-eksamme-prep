using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyreinternat___library.Models
{
    public class DocJournal
    {
        public int DocJournalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Treatment { get; set; }

        public DocJournal (int docjournalid, string name, string species, string treatment)
        {
            DocJournalID = DocJournalID;
            Name = name;
            Species = species;
            Treatment = treatment;
        }

        public DocJournal()
        {

        }

    }
}
