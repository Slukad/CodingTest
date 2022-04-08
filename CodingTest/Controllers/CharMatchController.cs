using CodingTest.Application;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers;

[ApiController]
[Route("[controller]")]
public class CharMatchController : ControllerBase
{
    private readonly ILogger<CharMatchController> _logger;
    private readonly ICharMatchManager _charMatchManager;

    public CharMatchController(ILogger<CharMatchController> logger, ICharMatchManager charMatchManager)
    {
        _logger = logger;
        _charMatchManager = charMatchManager;
    }
    
    [HttpGet("{input}/{search}")]
    public bool Get(string input, string search)
    {
        _logger.LogInformation("Se inicia comparacion {InputString}", input);
        return _charMatchManager.StringIsSimilar(input, search);
    }
}