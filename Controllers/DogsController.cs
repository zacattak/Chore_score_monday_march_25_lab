using csharp_dog_api.Models;
using csharp_dog_api.Services;

namespace csharp_dog_api.Controllers;

[ApiController]
[Route("api/[controller]")]



public class DogsController : ControllerBase

{
    private readonly DogsService _dogsService;

    public DogsController(DogsService dogsService)

    {
        _dogsService = dogsService;
    }


    [HttpGet("test")]
    public ActionResult<string> TestApi()
    {
        try
        {
            return Ok("API IS UP");
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpGet]
    public ActionResult<List<Dog>> GetDogs()
    {
        try
        {
            List<Dog> dogs = _dogsService.GetDogs();
            return Ok(dogs);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
}

