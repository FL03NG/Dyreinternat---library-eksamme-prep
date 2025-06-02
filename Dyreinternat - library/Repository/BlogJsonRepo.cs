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
    // Repository der håndterer lagring og hentning af blogindlæg fra en JSON-fil
    public class BlogJsonRepo : BlogCollectionRepo
    {
        // Constructor der loader blogdata fra JSON ved oprettelse
        public BlogJsonRepo()
        {
            LoadFile();
        }

        // Indlæser blogindlæg fra JSON-filen og deserialiserer til _blog-listen
        private void LoadFile()
        {
            string path = "Blog.Json";
            string json = File.ReadAllText(path);
            _blog = JsonSerializer.Deserialize<List<Blog>>(json);
        }

        // Tilføjer et blogindlæg og gemmer det i JSON-filen
        public override void Add(Blog blog)
        {
            Debug.WriteLine("gemmer blog fil");
            base.Add(blog);
            SaveFile();
        }

        // Gemmer hele listen af blogindlæg til JSON-filen
        private void SaveFile()
        {
            Debug.WriteLine("gemmer blog fil");
            string path = "Blog.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_blog));
        }

        // Sletter et blogindlæg og opdaterer JSON-filen
        public override void Delete(int id)
        {
            base.Delete(id);
            SaveFile();
        }
    }
}
