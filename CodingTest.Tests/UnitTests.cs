using CodingTest.Application;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingTest.Tests;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void TestStringAreSimilarSuccess()
    {
        var input = "abc";
        var search = "bca";

        var manager = new CharMatchManager(NullLogger<CharMatchManager>.Instance);
        var result = manager.StringIsSimilar(input, search);
        
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void TestStringAreSimilarFail()
    {
        var input = "abc";
        var search = "bcaa";

        var manager = new CharMatchManager(NullLogger<CharMatchManager>.Instance);
        var result = manager.StringIsSimilar(input, search);
        
        Assert.IsFalse(result);
    }
}