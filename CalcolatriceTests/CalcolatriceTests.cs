using Calcolatrice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcolatriceTests
{
    [TestClass]
    public class CalcolatriceTests
    {
        [TestMethod]

        [ExpectedException(typeof(ArgumentNullException))]
        public void CalcolatriceTestAdd_3Par()
        {
            //ARRANGE
            int[] addendi = { 4, 5, 6 };
            int expected = 15;
            //ACT
            SommaAlgebrica sum = new SommaAlgebrica();
            int res = sum.Add(addendi);
            //ASSERT
            Assert.IsTrue(expected == res);
        }
    }
}
