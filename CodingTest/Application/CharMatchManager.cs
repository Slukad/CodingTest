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

/*
 * abc -> bca = true
aab -> baa = true
aab  -> abc = false
abc -> abd = false
abc -> abcd = false
ab -> abab = false
 */