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
        if (input.Length != search.Length)
            return false;

        var inputChars = input.OrderBy(e => e).ToList();
        var searchChars = search.OrderBy(e => e).ToList();

        var successCounter = 0;
        
        for (int i = 0; i < inputChars.Count; i++)
        {
            if (inputChars.ElementAt(i) == searchChars.ElementAt(i))
            {
                successCounter++;
            }
        }

        return successCounter == input.Length;
    }
}

/*
 * abc -> bac = true
aab -> aba = true
abc -> abd = false
ab -> abc = false
abc -> ab = false 
 */