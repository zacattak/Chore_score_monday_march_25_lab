using csharp_dog_api.Models;
using csharp_dog_api.Repositories;

namespace csharp_dog_api.Services;
public class DogsService

{

    private readonly DogsRepository _repository;

    public DogsService(DogsRepository repository)
    {
        _repository = repository;
    }
    public List<Dog> GetDogs()

    {
        // return new List<Dog>();
        List<Dog> dogs = _repository.GetDogs();
        return dogs;
    }
}