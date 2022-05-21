using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Lab_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_1.Tests
{
    [TestClass()]
    public class VectorTests
    {
        [TestMethod()]
        public void NormTest()
        {
            double a = 4.1, b = -3.8;
            Vector expected = new Vector();
            expected.A = 0.7334302966199309;
            expected.B = -0.679764665159936;
            Vector testVector = new Vector();
            testVector.A = a; testVector.B = b;
            Vector actual = testVector.Norm();
            Assert.AreEqual(expected.A, actual.A);
            Assert.AreEqual(expected.B, actual.B);
        }
    }
}