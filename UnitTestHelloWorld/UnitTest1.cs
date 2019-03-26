using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace UnitTestHelloWorld
{
    [TestClass]
    public class HelloWorld
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.createMessage());
        }
    }
}