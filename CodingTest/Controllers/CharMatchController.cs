using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers;

[ApiController]
[Route("[controller]")]
public class CharMatchController : ControllerBase
{
    private readonly ILogger<CharMatchController> _logger;

    public CharMatchController(ILogger<CharMatchController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet("{input}/{search}")]
    public bool Get(string input, string search)
    {
        
        return true;
    }
}