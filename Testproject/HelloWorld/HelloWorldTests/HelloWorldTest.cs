using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 aNewForm = new Form1();
            Assert.IsNotNull(aNewForm);
        }
    }
}
