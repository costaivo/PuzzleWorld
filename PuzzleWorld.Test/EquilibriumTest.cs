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
            int[] A = new int[] { -1, 1, 0 };
            int i = Equilibrium.Solution.GetEquilibriumPosition(A);
            Assert.AreEqual(i, 2);
        }

        [TestMethod]
        public void TestUnInitializedArray()
        {
            int[] A = null;
            int i = Equilibrium.Solution.GetEquilibriumPosition(A);
            Assert.AreEqual(i, -1);
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            int[] A = new int[0];
            int i = Equilibrium.Solution.GetEquilibriumPosition(A);
            Assert.AreEqual(i, -1);
        }
    }
}
