using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleJenkins
{
    [TestClass]
    public class Jenkins
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("hello world", Program.createMessage());
        }
        
    }
}
