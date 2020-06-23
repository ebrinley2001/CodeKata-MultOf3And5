using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultOf3And5Prod.Tests
{
    [TestClass()]
    public class ProdCodeTests
    {
        [TestMethod()]
        public void MultOf3And5Test()
        {
            Assert.IsNotNull(ProdCode.MultOf3And5(1));
        }

        [DataTestMethod]

        [DataRow(10, 33)]
        [DataRow(15, 60)]
        [DataRow(20, 98)]
        [DataRow(30, 225)]
        [DataRow(999, 233168)]
        public void Value_Mult_Check(int a, int b)
        {
            Assert.AreEqual(b, ProdCode.MultOf3And5(a));
        }
    }
}