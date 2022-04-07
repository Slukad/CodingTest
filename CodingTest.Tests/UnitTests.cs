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

       
    }
    
    [TestMethod]
    public void TestStringAreSimilarFail()
    {
        var input = "abc";
        var search = "bcaa";

       
    }
   
    [TestMethod]
    public void TestStringAreSimilarFail2()
    {
        var input = "aab";
        var search = "abc";

       
    }
    [TestMethod]
    public void TestStringAreSimilarFail3()
    {
        var input = "abc";
        var search = "abd";

       
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