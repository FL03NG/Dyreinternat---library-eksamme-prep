
using System.Diagnostics;
using System.Reflection.Metadata;
using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public class AnimalCollectionRepo : IAnimalRepo //implementerer et interface
    {
        public List<Animal> _animals; //en liste der indenholder objecterne fra Animal klassen

        public AnimalCollectionRepo() //en konstruktør der initialiserer _animals som en ny tom liste
        {
            _animals = new List<Animal>();
            
        }

        public virtual void Add(Animal animal) //virtuel tiladder denne metode at blive "overriden" i en subklasse
        {
            Debug.WriteLine("add2"); 
            _animals.Add(animal); //tilføjer et "Animals" objekt til "_animals" listen
        }

        public virtual void Delete(int id) //fjerner et dyr fra listen baseret på id
        {
            Animal animalToRemove = null; // initialiserer "animalToRemove" som "null"

            foreach (Animal d in _animals) //løber igennem hver "Animal" objekt i "_animals" listen. det valgte objekt bliver forløbeligt navngivet "d"
            {
                if (d.AnimalID == id) //tjekker om det valgte id matcher med det i parametren
                {
                    animalToRemove = d; //hvis det gør 
                    break; //stopper den med at løbe igennem
                }
            }

            if (animalToRemove != null) //hvis et matching animal blev fundet
            {
                _animals.Remove(animalToRemove); //bliver den slettet fra listen
            }
        }

        public List<Animal> GetAll() //returnere hele "_animals" listen
        {
            return _animals;
        }

        

    }
}
