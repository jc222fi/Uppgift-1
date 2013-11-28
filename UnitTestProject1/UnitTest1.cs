using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isEquilateralTest()
        {
            Triangle triangle = new Triangle(3.0, 3.0, 3.0);
            Assert.IsTrue(triangle.isEquilateral());
        }
    }
}
