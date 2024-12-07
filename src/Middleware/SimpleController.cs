using Microsoft.AspNetCore.Mvc;

namespace Middleware;

[ApiController]
[Route("api/simple")]
public class SimpleController : ControllerBase
{
    public record UserRequest(string Username, string Password);

    [HttpPost]
    public IActionResult Post([FromBody] UserRequest request)
    {
        Console.WriteLine($"User: {request.Username}, Password: {request.Password}");
        return Ok();
    }
}
