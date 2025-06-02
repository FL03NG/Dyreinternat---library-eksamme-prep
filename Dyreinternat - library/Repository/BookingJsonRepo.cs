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
    // Repository der håndterer lagring og hentning af bookinger fra en JSON-fil
    public class BookingJsonRepo : BookingCollectionRepo
    {
        // Constructor der loader bookingdata fra JSON ved oprettelse
        public BookingJsonRepo()
        {
            LoadFile();
        }

        // Indlæser bookinger fra JSON-filen og deserialiserer til _bookings-listen
        private void LoadFile()
        {
            string path = "Booking.Json";
            string json = File.ReadAllText(path);
            _bookings = JsonSerializer.Deserialize<List<Booking>>(json);
        }

        // Tilføjer en booking og gemmer det i JSON-filen
        public override void Add(dyreinternat___library.Models.Booking booking)
        {
            Debug.WriteLine("gemmer booking fil");
            base.Add(booking);
            SaveFile();
        }

        // Gemmer hele listen af bookinger til JSON-filen
        private void SaveFile()
        {
            Debug.WriteLine("gemmer booking fil");
            string path = "Booking.Json";
            File.WriteAllText(path, JsonSerializer.Serialize(_bookings));
        }

        // Sletter en booking og opdaterer JSON-filen
        public override void Delete(int id)
        {
            base.Delete(id);
            SaveFile();
        }
    }
}

