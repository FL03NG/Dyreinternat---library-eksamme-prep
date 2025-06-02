using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Services
{
    public class MemberService
    {
        private IMemberRepo _accountRepo;

        public MemberService(IMemberRepo accountRepo)
        {
            _accountRepo = accountRepo;
        }
        public void Add(Account accountRepo)
        {
            _accountRepo.Add(accountRepo);
        }
        public List<Account> GetAll()
        {
            return _accountRepo.GetAll();
        }
        public void Delete(int accountID)
        {
            _accountRepo.Delete(accountID);
        }





    }
}
