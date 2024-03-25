namespace csharp_dog_api.Controllers;

[ApiController]
[Route("api/[controller]")]



public class DogsController : ControllerBase

{
    [HttpGet]
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
}

