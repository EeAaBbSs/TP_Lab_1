using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Lab_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_1.Tests
{
    [TestClass()]
    public class TruncatedPyramidTests
    {
        [TestMethod()]
        public void VolumeTest()
        {
            double s1 = 3.0, s2 = 5.0, h = 4.0, expected = 15.83;
            TruncatedPyramid testPyr = new TruncatedPyramid(s1, s2, h);
            double actual = testPyr.Volume();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SideSurfTest()
        {
            double s1 = 3.0, s2 = 5.0, expected = 4;
            float c = 60.0f;
            TruncatedPyramid testPyr = new TruncatedPyramid(s1, s2, c);
            double actual = testPyr.SideSurf();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgExceptionTest1()
        {
            double s1 = 0.0, s2 = 5.0, h = 4.0;
            TruncatedPyramid testPyr = new TruncatedPyramid(s1, s2, h);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgExceptionTest2()
        {
            double s1 = 1.0, s2 = 0.0, h = 4.0;
            TruncatedPyramid testPyr = new TruncatedPyramid(s1, s2, h);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgExceptionTest3()
        {
            double s1 = 1.0, s2 = 1.0, h = 4.0;
            TruncatedPyramid testPyr = new TruncatedPyramid(s1, s2, h);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgExceptionTest4()
        {
            double s1 = 1.0, s2 = 1.0, h = 0.0;
            TruncatedPyramid testPyr = new TruncatedPyramid(s1, s2, h);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgExceptionTest5()
        {
            double s1 = 1.0, s2 = 1.0, c = 0.0f;
            TruncatedPyramid testPyr = new TruncatedPyramid(s1, s2, c);
        }
    }
}