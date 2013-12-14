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
            Triangle tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(tri.isEquilateral());
        }

        [TestMethod]
        public void isIsoscelesTest()
        {
            Triangle tri = new Triangle(2.0, 3.0, 3.0);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void isScaleneTest()
        {
            Triangle tri = new Triangle(2.0, 3.0, 4.0);
            Assert.IsTrue(tri.isScalene());
        }
    }
}
