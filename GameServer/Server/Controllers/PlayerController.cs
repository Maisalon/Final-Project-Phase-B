using Microsoft.AspNetCore.Mvc;
using SharedLibrary;
namespace Server.Controllers;

[ApiController]
[Route("[Controller]")]
public class PlayerController : ControllerBase
{
    [HttpGet]

    public Player Get([FromQuery] int id)
    {
        var player = new Player() { Id = id };
        return player;
    }
    [HttpPost]
    public Player Post(Player player)
    {
        Console.WriteLine("Player hase been added to the database");
        return player;
    }
}
