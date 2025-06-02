using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public interface IMemberRepo
    {
        public List<Account> GetAll();

        public void Add(Account account);
        public void Delete(int id);
    }
}
