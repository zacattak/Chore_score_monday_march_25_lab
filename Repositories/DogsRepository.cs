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

    internal Dog CreateDog(Dog dogData)
    {
        string badSqlThatWillGetYouInTrouble = @$"
        INSERT INTO
        dogs(stray, color, name, size)
        VALUES({dogData.Stray}, {dogData.Color}, {dogData.Name}, {dogData.Size}),
        SELECT * FROM dogs WHERE id = LAST_INSERT_ID()";

        string goodSql = @"
        INSERT INTO 
        dogs(stray, color, name, size)
        VALUES(@Stray, @Color, @Name, @Size);

        SELECT * FROM dogs WHERE id = LAST_INSERT_ID()
        ";

        Dog dog = _db.Query<Dog>(goodSql, dogData).FirstOrDefault();
        return dog;
    }
}