namespace CodingTest.Application;

public interface ICacheManager
{
    public Task AddValue(string key, string value);
}