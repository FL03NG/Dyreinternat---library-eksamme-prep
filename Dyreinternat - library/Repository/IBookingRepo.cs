using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public interface IBookingRepo
    {

        public List<Booking> GetAll();

        public void Add(Booking booking);

      

       
        public void Delete(int animalID);
    }
}
