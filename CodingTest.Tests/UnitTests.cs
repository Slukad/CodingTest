using CodingTest.Application;
using FluentAssertions;
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

        result.Should().BeTrue();
    }
    
    [TestMethod]
    public void TestStringAreSimilarFail()
    {
        var input = "abc";
        var search = "bcaa";

        var manager = new CharMatchManager(NullLogger<CharMatchManager>.Instance);
        var result = manager.StringIsSimilar(input, search);

        result.Should().BeFalse();
    }
    
    [TestMethod]
    public void TestStringAreSimilarFail2()
    {
        var input = "abc";
        var search = "baa";

        var manager = new CharMatchManager(NullLogger<CharMatchManager>.Instance);
        var result = manager.StringIsSimilar(input, search);

        result.Should().BeFalse();
    }
    
    [TestMethod]
    public void TestStringAreSimilarFail3()
    {
        var input = "aac"; //aac
        var search = "abc"; // abc

        var manager = new CharMatchManager(NullLogger<CharMatchManager>.Instance);
        var result = manager.StringIsSimilar(input, search);

        result.Should().BeFalse();
    }
}