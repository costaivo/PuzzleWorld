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
            long diagonalLeft = 0;
            long diagonalRight = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                diagonalRight += squareArray[i, i];
                diagonalLeft += squareArray[arrayLength - i - 1, i];
            }
            //Console.WriteLine("R " + diagonalRight);
            //Console.WriteLine("L " + diagonalLeft);

            long result = Math.Abs(diagonalRight - diagonalLeft);
            Console.WriteLine(result.ToString());

            //Console.WriteLine("Printing Array");
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    Console.WriteLine(" ");
            //    for (int j = 0; j < arrayLength; j++)
            //    {
            //        Console.Write(" " + squareArray[i, j]);
            //    }
            //}
            //Console.Read();
        }
    }
}
