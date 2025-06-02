using dyreinternat___library.Models;
using dyreinternat___library.Repository;

namespace dyreinternat___library.Services
{
    public class BookingService


    {
        private IBookingRepo _bookingRepo;

        public BookingService(IBookingRepo bookingrepoRepo)
        {
            _bookingRepo = bookingrepoRepo;
        }

        public void Add(Booking booking)
        {
            _bookingRepo.Add(booking);
        }

        public List<Booking> GetAll()
        {
            return _bookingRepo.GetAll();
        }

        public void Delete(int animalID)
        {
            _bookingRepo.Delete(animalID);
        }

    }
}

