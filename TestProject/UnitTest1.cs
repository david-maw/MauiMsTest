using Microsoft.VisualStudio.TestTools.UnitTesting;
using MauiMsTest;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, MauiProgram.Add1(2));
        }
    }
}
