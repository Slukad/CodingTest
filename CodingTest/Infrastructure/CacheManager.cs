using CodingTest.Application;

namespace CodingTest.Infrastructure;

public class CacheManager : ICacheManager
{
    public async Task AddValue(string key, string value)
    {
        await Task.CompletedTask;
    }
}