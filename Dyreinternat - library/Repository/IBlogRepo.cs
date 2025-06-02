using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public interface IBlogRepo
    {


        public List<Blog> GetAll();

        public void Add(Blog blog);

        public void Delete(int id);

    }
}
