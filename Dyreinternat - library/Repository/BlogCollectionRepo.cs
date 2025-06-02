using System.Diagnostics;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class BlogCollectionRepo : IBlogRepo //implementerer et interface
    {
        public List<Blog> _blog; //en liste der indenholder objecterne fra "Blog" klassen

        public BlogCollectionRepo() //en konstruktør der initialiserer _blog som en ny tom liste
        {
            _blog = new List<Blog>();

        }

        public virtual void Add(Blog blog) //virtuel tiladder denne metode at blive "overriden" i en subklasse
        {
            Debug.WriteLine("add blog");
            _blog.Add(blog); //tilføjer et "Blog" objekt til "_blog" listen
        }

        public List<Blog> GetAll() //returnere hele "_blog" listen
        {
            return _blog;
        }
        public virtual void Delete(int id) //fjerner en blog fra listen baseret på id
        {
            Blog blogToRemove = null; // initialiserer "blogToRemove" som "null"

            foreach (Blog d in _blog) //løber igennem hver "Blog" objekt i "_blog" listen. det valgte objekt bliver forløbeligt navngivet "d"
            {
                if (d.BlogID == id) //tjekker om det valgte id matcher med det i parametren
                {
                    blogToRemove = d; //hvis det gør, 
                    break; //stopper den med at løbe igennem.
                }
            }

            if (blogToRemove != null) //hvis en matching blog blev fundet,
            {
                _blog.Remove(blogToRemove); //bliver den slettet fra listen.
            }
        }
    }
}
