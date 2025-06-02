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
    public class MemberJsonRepo : MemberCollectionRepo
    {
        public MemberJsonRepo()
        {
            LoadFile();
        }
        private void LoadFile()
        {
            string path = "Member.Json";
            string json = File.ReadAllText(path);
            _account = JsonSerializer.Deserialize<List<Account>>(json);
        }

        public override void Add(dyreinternat___library.Models.Account account)
        {
            Debug.WriteLine("gemmer member fil");
            base.Add(account);
            SaveFile();

        }

        private void SaveFile()
        {
            Debug.WriteLine("gemmer member fil");
            string path = "Member.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_account));
        }
        public override void Delete(int id)
        {
            base.Delete(id);
            SaveFile();
        }



    }
}
