using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleWorld.Hackerrank.Algorithms.Warmup
{
    public class DiagonalDifference
    {
        public static  void Solution()
        {
            var rawData = Console.ReadLine();
            int arrayLength;
            int.TryParse(rawData, out arrayLength);
            int[,] squareArray = new int[arrayLength, arrayLength];

            for (int arrayRow = 0; arrayRow < arrayLength; arrayRow++)
            {
                rawData = Console.ReadLine();
                int columnCount = 0;
                foreach (string s in rawData.Split(' '))
                {
                    int currentValue;
                    int.TryParse(s, out currentValue);
                    squareArray[arrayRow, columnCount] = currentValue;
                    columnCount++;
                }
            }
            //Get Diagonal Difference
            long result = GetDiagonalDifference( squareArray);

            Console.WriteLine(result.ToString());

            Console.Read();
        }

        public static long GetDiagonalDifference( int[,] squareArray)
        {
            long diagonalLeft = 0;
            long diagonalRight = 0;
            int arrayLength = squareArray.GetLength(0) ;
            for (int i = 0; i < arrayLength; i++)
            {
                diagonalRight += squareArray[i, i];
                diagonalLeft += squareArray[arrayLength - i - 1, i];
            }
            //Console.WriteLine("R " + diagonalRight);
            //Console.WriteLine("L " + diagonalLeft);

            long result = Math.Abs(diagonalRight - diagonalLeft);
            return result;
        }

        private static int ConsoleReadIntValue()
        {
            int number;
            int.TryParse(Console.ReadLine(), out number);
            return number;
        }
        
        public static void SolutionWithoutArrays()
        {
            int arrayLength = ConsoleReadIntValue();
            long diagonalLeft = 0;
            long diagonalRight = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j< arrayLength; j++)
                {
                    int newNumber = ConsoleReadIntValue();
                    if (i == j)
                        diagonalRight += newNumber;

                    if (i + j == (arrayLength - 1))
                        diagonalLeft += newNumber;
                }
            }

            long result = Math.Abs(diagonalRight - diagonalLeft);
            Console.WriteLine(result.ToString());
        }
    }
}
