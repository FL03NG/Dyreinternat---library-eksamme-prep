using dyreinternat___library.Repository;
using dyreinternat___library.Models;
using System.Security.Cryptography.X509Certificates;
namespace dyreinternat___library.Services
{
    public class AnimalService
    {
        private IAnimalRepo _animalrepo;

        public AnimalService(IAnimalRepo animalRepo)
        {
            _animalrepo = animalRepo;
        }

        // Tilføjer et nyt dyr via repository-laget
        public void Add(Animal animal)
        {
            _animalrepo.Add(animal);
        }


        // Henter alle dyr fra repository-laget
        public List<Animal> GetAll()
        {
            return _animalrepo.GetAll();
        }

        // Sletter et dyr ud fra dets ID
        public void Delete(int id)
        {
            _animalrepo.Delete(id);
        }
    }
}
