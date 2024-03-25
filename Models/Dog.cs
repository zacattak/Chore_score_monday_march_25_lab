namespace csharp_dog_api.Models;

public class Dog
{
    public int Id { get; set; }
    public bool Stray { get; set; }
    public string Color { get; set; }
    public string Name { get; set; }

    public string Size { get; set; }
}