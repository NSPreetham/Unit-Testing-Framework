using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    [TestCategory("LoginFeature")]
    public class UnitTest1
    {
        private int a;
        [TestInitialize]
        public void RunBeforeEveryTest()
        {
            a = 1;
        }
        
        [TestMethod]
        [TestCategory("Positive")]
        [Description("these are demo unit tests")]
        public void TestMethod1()
        {
          
            var b = 2;
            Assert.AreEqual(3, a + b);
        }
        [TestMethod]
        public void TestMethod2()
        {
           
            Assert.IsTrue(a == 1);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
          Assert.AreNotEqual(1, a);
        }
    }
}
