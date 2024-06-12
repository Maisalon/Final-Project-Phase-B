using Microsoft.AspNetCore.Mvc;
using Server.Services;
using SharedLibrary;
namespace Server.Controllers;

[ApiController]
[Route("[Controller]")]
public class PlayerController : ControllerBase
{
    private readonly PlayerService _playerService;
    public PlayerController(PlayerService playerService)
    {
        _playerService = playerService;
    }
    [HttpGet]

    public Player Get([FromQuery] int id)
    {
        var player = new Player() { Id = id };
        _playerService.DoSomething();
        return player;
    }
    [HttpPost]
    public Player Post(Player player)
    {
        Console.WriteLine("Player hase been added to the database");

        return player;
    }
}
