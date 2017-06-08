using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = UnitTestExamples.Operations.Add(2, 3);
            Assert.IsTrue(result == 5);

            var result2 = UnitTestExamples.Operations.Subtract(2, 3);
            Assert.IsTrue(result2 == -1);
        }
    }
}
