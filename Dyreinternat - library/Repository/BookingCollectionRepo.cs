using System.Diagnostics;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class BookingCollectionRepo : IBookingRepo //implementerer et interface
    {
        public List<Booking> _bookings; //en liste der indenholder objecterne fra "Booking" klassen

        public BookingCollectionRepo() //en konstruktør der initialiserer _bookings som en ny tom liste
        {
            _bookings = new List<Booking>();

        }

        public virtual void Add(Booking booking) //virtuel tiladder denne metode at blive "overriden" i en subklasse
        {
            _bookings.Add(booking); //tilføjer et "Booking" objekt til "_bookings" listen
        }

        public List<Booking> GetAll() //returnere hele "_bookings" listen
        {
            return _bookings;
        }
        public virtual void Delete(int animalID) //fjerner en booking fra listen baseret på animalID
        {
            Booking bookingToRemove = null; // initialiserer "bookingToRemove" som "null"

            for (int i = 0; i < _bookings.Count; i++) //et for-loop som løber igennem hver objekt i "_bookings" listen pr index
            {
                if (_bookings[i].AnimalID == animalID) //tjekker om det valgte id matcher med det i parametren
                {
                    bookingToRemove = _bookings[i]; //hvis det gør 
                    break; //stopper den med at løbe igennem
                }
            }

            if (bookingToRemove != null) //hvis en matching booking blev fundet
            {
                _bookings.Remove(bookingToRemove); //bliver den slettet fra listen
            }
        }
    }
}
