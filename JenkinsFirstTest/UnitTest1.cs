using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsFirst;

namespace JenkinsFirstTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.createMessage());
        }
    }
}
