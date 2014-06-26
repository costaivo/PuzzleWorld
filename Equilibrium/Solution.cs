
namespace Equilibrium
{
    using System;

    public class Solution
    {

        public static void Main()
        {
            int[] A = new int[] { -1, 1, 0 };
            int i = GetEquilibriumPosition(A);

            Console.WriteLine(i.ToString());
            Console.ReadLine();

        }

        public static int GetEquilibriumPosition(int[] A)
        {
            if (A ==null || A.Length == 0)
                return -1;

            long totalSum = 0;
            long leftSum = 0;

            for (int i = 0; i < A.Length; i++)
                totalSum += A[i];

            for (int i = 0; i < A.Length; i++)
            {
                long rightSum = totalSum - leftSum - A[i];
                if (rightSum == leftSum)
                    return i;
                leftSum += A[i];
            }
            return -1;
        }


       
    }
}
