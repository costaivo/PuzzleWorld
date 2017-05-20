namespace PuzzleWorld.Equilibrium
{
    using System;

    public class Solution
    {
        public static int GetEquilibriumPosition(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
            {
                return -1;
            }

            long totalSum = 0;
            long leftSum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                totalSum += inputArray[i];
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                long rightSum = totalSum - leftSum - inputArray[i];
                if (rightSum == leftSum)
                {
                    return i;
                }

                leftSum += inputArray[i];
            }

            return -1;
        }
    }
}
