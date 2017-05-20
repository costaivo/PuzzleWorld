using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzleWorld.Hackerrank.Algorithms.Warmup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleWorld.Test
{
    [TestClass]
   public class DiagonalDifferenceTest
    {

        [TestMethod]
        public void Test_WithProblemData()
        {
            int[,] inputArray = new int[3, 3] { { 11, 2, 4}, { 4, 5, 6 }, { 10, 8,-12 } };
            var result = DiagonalDifference.GetDiagonalDifference(inputArray);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Test_3x3_2()
        {
            int[,] inputArray = new int[3, 3] { { 1, 0, 0 }, {0,1,0 },{0,0,1 } };
            var result = DiagonalDifference.GetDiagonalDifference(inputArray);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test_3x3_0()
        {
            int[,] inputArray = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            var result = DiagonalDifference.GetDiagonalDifference( inputArray);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_4x4_0()
        {
            int[,] inputArray = new int[4, 4] { { 1, 0, 0,0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            var result = DiagonalDifference.GetDiagonalDifference( inputArray);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test_LargeIntValues()
        {
            int[,] inputArray = new int[4, 4] { { Int32.MaxValue, 0, 0,0 }, { 0, Int32.MaxValue, 0,0 }, { 0, 0, Int32.MaxValue, 0 }, { 0, 0, 0, Int32.MaxValue } };
            var result = DiagonalDifference.GetDiagonalDifference(inputArray);
            long expectedResult = Math.Abs( ((long)int.MaxValue * 4));
            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void Test_LowIntValues()
        {
            int[,] inputArray = new int[4, 4] { { Int32.MinValue, 0, 0, 0 }, { 0, Int32.MinValue, 0, 0 }, { 0, 0, Int32.MinValue, 0 }, { 0, 0, 0, Int32.MinValue } };
            var result = DiagonalDifference.GetDiagonalDifference(inputArray);
            long expectedResult =Math.Abs( ((long)int.MinValue *4));
            Assert.AreEqual(expectedResult, result);
        }
    }
}
