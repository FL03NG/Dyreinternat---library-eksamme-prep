using dyreinternat___library.Models;

namespace dyreinternat___library.Repository
{
    public interface IAnimalRepo
    {
        public List<Animal> GetAll();

        public void Add(Animal animal);

        public void Delete(int id);

    }
}
