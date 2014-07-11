using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PuzzleWorld.Test
{
    [TestClass]
    public class EquilibriumTest
    {
        [TestMethod]
        public void Test()
        {
            int[] inputArray = new int[] { -1, 1, 0 };
            int i = Equilibrium.Solution.GetEquilibriumPosition(inputArray);
            Assert.AreEqual(i, 2);
        }

        [TestMethod]
        public void TestUnInitializedArray()
        {
            int[] inputArray = null;
            int i = Equilibrium.Solution.GetEquilibriumPosition(inputArray);
            Assert.AreEqual(i, -1);
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            int[] inputArray = new int[0];
            int i = Equilibrium.Solution.GetEquilibriumPosition(inputArray);
            Assert.AreEqual(i, -1);
        }
    }
}
