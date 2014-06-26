using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equilibrium
{
    public class Solution
    {
        public static void Main()
        {
            int[] A = new int[] { -1, 1, 0 };
            int i = solution(A);

            Console.WriteLine(i.ToString());
            Console.ReadLine();

        }

        public static int optimizedSolution(int[] A)
        {
            if (A.Length == 0)
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


        public static int solution(int[] A)
        {
            if (A.Length == 0)
                return -1;
            if (A.Length == 1)
                return 0;

            long leftSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i + 1 < A.Length)
                {
                    long rigthSum = AddArray(i + 1, A);
                    if (leftSum == rigthSum)
                        return i;
                    leftSum += A[i];
                }

            }
            leftSum = AddArray(0, A);

            leftSum -= A[A.Length - 1];

            if (leftSum == 0)
                return A.Length - 1;

            return -1;
        }

        public static long AddArray(int startIndex, int[] array)
        {
            long sum = 0;
            for (int i = startIndex; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
