using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace addressbook_web_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            Square s3 = s1;

            Assert.AreEqual(s1.getSize(), 5);
            Assert.AreEqual(s1.getSize(), 10);
            Assert.AreEqual(s1.getSize(), 5);
        }
    }
}
