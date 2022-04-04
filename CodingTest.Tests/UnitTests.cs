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
}