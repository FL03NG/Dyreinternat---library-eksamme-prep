using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Services
{
    public class BlogService
    {

        private IBlogRepo _blogrepo;

        public BlogService(IBlogRepo blogRepo)
        {
            _blogrepo = blogRepo;
        }

        public void Add(Blog blog)
        {
            _blogrepo.Add(blog);
        }

        public List<Blog> GetAll()
        {
            return _blogrepo.GetAll();
        }

        public void Delete(int id)
        {
            _blogrepo.Delete(id);
        }

    }
}
