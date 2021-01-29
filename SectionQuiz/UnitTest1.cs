using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SectionQuiz
{
    [TestClass]
    public class SectionQ
    {
        [TestMethod]
        public void Convert_F_To_C()
        {
            double C = (64 - 32) * .5556;
            Console.WriteLine(C);
            Assert.AreEqual(C, 17.779, 0.001);

        }
        [TestMethod]
        public void Convert_C_To_F()
        {
            double F = (64 /.5556) + 32;
            Console.WriteLine(F);
            Assert.AreEqual(F, 147.190, 0.001);

        }


    }
}
