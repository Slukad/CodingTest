namespace CodingTest.Application;

public class CharMatchManager : ICharMatchManager
{
    private readonly ILogger<CharMatchManager> _logger;
    public CharMatchManager(ILogger<CharMatchManager> logger)
    {
        _logger = logger;
    }
    
    public bool StringIsSimilar(string input, string search)
    {
        
        return true;
    }
}