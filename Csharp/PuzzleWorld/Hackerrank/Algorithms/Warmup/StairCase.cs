using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleWorld.Hackerrank.Algorithms.Warmup
{
    class StairCase
    {
        public static void Solution()
        {
            var numberOfStaircases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStaircases; i++)
            {
                var string1 = "".PadLeft(i + 1, '#');
                Console.WriteLine(string1.PadLeft(numberOfStaircases, ' '));
            }
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
