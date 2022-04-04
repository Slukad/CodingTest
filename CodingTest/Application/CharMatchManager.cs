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
        {
            _logger.LogInformation("The length of the input {InputLength} is different to the length of the search {SearchLength}", input.Length, search.Length);
            return false;
        }

        var inputChars = input.OrderBy(i => i).ToList();
        var searchChars = search.OrderBy(i => i).ToList();

        for (var i = 0; i < inputChars.Count(); i++)
        {
            if (inputChars[i] != searchChars[i])
            {
                return false;
            }
        }
        
        
        return true;
    }
}