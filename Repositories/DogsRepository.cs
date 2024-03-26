using csharp_dog_api.Models;

namespace csharp_dog_api.Repositories;

public class DogsRepository
{
    private readonly IDbConnection _db;
    public DogsRepository(IDbConnection db)
    {
        _db = db;
    }

    public List<Dog> GetDogs()
    {
        string sql = "SELECT * FROM dogs;";

        List<Dog> dogs = _db.Query<Dog>(sql).ToList();

        return dogs;
    }
}