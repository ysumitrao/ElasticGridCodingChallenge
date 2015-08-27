using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;
using System.Text;

namespace UtilitiesTest
{
    [TestClass]
    public class UnitTest
    {
        #region Requirement 1 Test Cases
        [TestMethod]
        public void IsNullOrEmptyScenarioNull()
        {
            string strInput = null;
            Assert.AreEqual(true, Helper.IsNullOrEmpty(strInput));
        }

        [TestMethod]
        public void IsNullOrEmptyScenarioA()
        {
            string strInput = "a";
            Assert.AreEqual(false, Helper.IsNullOrEmpty(strInput));
        }

        [TestMethod]
        public void IsNullOrEmptyScenarioEmptyString()
        {
            string strInput = "";
            Assert.AreEqual(true, Helper.IsNullOrEmpty(strInput));
        }

        [TestMethod]
        public void IsNullOrEmptyScenarioEmptyStringWithSpace()
        {
            string strInput = " ";
            Assert.AreEqual(true, Helper.IsNullOrEmpty(strInput));
        }

        [TestMethod]
        public void IsNullOrEmptyScenarioString()
        {
            string strInput = "null";
            Assert.AreEqual(false, Helper.IsNullOrEmpty(strInput));
        }
        #endregion

        #region Requirement 2 Test Cases
        [TestMethod]
        public void PositiveDivisorsof60()
        {
            int inputNo = 60;
            StringBuilder outputStr = new StringBuilder("1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60").Replace(" ", "");
            Assert.AreEqual(outputStr.ToString(), Helper.PositiveDivisors(inputNo).ToString());
        }

        [TestMethod]
        public void PositiveDivisorsof42()
        {
            int inputNo = 42;
            StringBuilder outputStr = new StringBuilder("1, 2, 3, 6, 7, 14, 21, 42").Replace(" ", "");
            Assert.AreEqual(outputStr.ToString(), Helper.PositiveDivisors(inputNo).ToString());
        }
        #endregion

        #region Requirement 3 Test Cases
        [TestMethod]
        public void AreaOfTriangleSuccess()
        {
            int sideA = 3;
            int sideB = 4;
            int sideC = 5;
            Assert.AreEqual(6, Helper.AreaOfTriangle(sideA, sideB, sideC));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "InvalidTriangleException: Traingle sides cannot be less than or equal to 0.")]
        public void AreaOfTriangleNegativeValues()
        {
            int sideA = -3;
            int sideB = 4;
            int sideC = 5;
            Helper.AreaOfTriangle(sideA, sideB, sideC);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "InvalidTriangleException: Cannot form a triangle with these sides.")]
        public void AreaOfTriangleInvalidSides()
        {
            int sideA = 3;
            int sideB = 4;
            int sideC = 7;
            Helper.AreaOfTriangle(sideA, sideB, sideC);
        }
        #endregion

        #region Requirement 4 Test Cases
        [TestMethod]
        public void MostCommonIntegersScenario1()
        {
            int[] inputArr = { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 };
            int[] expectedArr = { 5, 4 };
            int[] outputArr = Helper.MostCommonIntegers(inputArr);            

            for (var i = 0; i < outputArr.Length; i++)
            {
                Assert.AreEqual(expectedArr[i], outputArr[i]);
            }
        }

        [TestMethod]
        public void MostCommonIntegersScenario2()
        {
            int[] inputArr = { 1, 2, 3, 4, 5, 1, 6, 7 };
            int[] expectedArr = { 1 };
            int[] outputArr = Helper.MostCommonIntegers(inputArr);            

            for (var i = 0; i < outputArr.Length; i++)
            {
                Assert.AreEqual(expectedArr[i], outputArr[i]);
            }
        }

        [TestMethod]
        public void MostCommonIntegersScenario3()
        {
            int[] inputArr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] expectedArr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] outputArr = Helper.MostCommonIntegers(inputArr);

            for (var i = 0; i < outputArr.Length; i++)
            {
                Assert.AreEqual(expectedArr[i], outputArr[i]);
            }
        }
        #endregion
    }
}
