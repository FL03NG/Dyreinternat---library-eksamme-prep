using System.Diagnostics;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class MemberCollectionRepo : IMemberRepo //implementerer et interface
    {
        public List<Account> _account; //en liste der indenholder objecterne fra "Account" klassen

        public MemberCollectionRepo() //en konstruktør der initialiserer "_account" som en ny tom liste
        {
            _account = new List<Account>();

        }

        public virtual void Add(Account account) //virtuel tiladder denne metode at blive "overriden" i en subklasse
        {
            Debug.WriteLine("add account");
            _account.Add(account); //tilføjer et "Account" objekt til "_account" listen
        }

        public List<Account> GetAll() //returnere hele "_account" listen
        {
            return _account;
        }

        public virtual void Delete(int id) //fjerner et medlem fra listen baseret på id
        {
            Account accountToRemove = null; // initialiserer "accountToRemove" som "null"

            foreach (Account d in _account) //løber igennem hver "Account" objekt i "_account" listen. det valgte objekt bliver forløbeligt navngivet "d"
            {
                if (d.AccountID == id) //tjekker om det valgte id matcher med det i parametren
                {
                    accountToRemove = d; //hvis det gør 
                    break; //stopper den med at løbe igennem
                }
            }

            if (accountToRemove != null) //hvis en matching Account blev fundet
            {
                _account.Remove(accountToRemove); //bliver den slettet fra listen
            }
        }
    }
}
