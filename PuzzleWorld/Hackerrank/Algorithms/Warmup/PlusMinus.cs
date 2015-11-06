using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleWorld.Equilibrium;

namespace PuzzleWorld.Hackerrank.Algorithms.Warmup
{
    class PlusMinus
    {
        public static void Solution()
        {
         //Read number of rows from console
            var inputNumber = ReadNumberFromConsole();

            int numberCount = 0;
            int positiveNumberCount = 0;
            int negativeNumberCount = 0;
            int zeroNumberCount = 0;

 
                var inputData = Console.ReadLine();
         
                foreach (var value in inputData.Split(' '))
                {
                    int dataValue;
                    int.TryParse(value, out dataValue);
                    if (dataValue > 0)
                    {
                        positiveNumberCount++;
                    }
                    else if (dataValue < 0)
                    {
                        negativeNumberCount++;
                    }
                    else
                    {
                        zeroNumberCount++;

                    }
                    numberCount++;
                }
   

            Console.WriteLine(""+(float)positiveNumberCount/numberCount);
            Console.WriteLine("" + (float)negativeNumberCount / numberCount);
            Console.WriteLine("" + (float)zeroNumberCount / numberCount);
            Console.Read();
        }

        private static int ReadNumberFromConsole()
        {
            var rawData = Console.ReadLine();
            int number = 0;
            int.TryParse(rawData, out number);
            return number;
        }
    }
}
