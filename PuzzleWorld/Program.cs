using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // #region Equilibrium Problem
            // Console.WriteLine("Equilibrium Problem");
            // int[] inputArray = new int[] { -1, 1, 0 };
            // int equilibriumPosition = Equilibrium.Solution.GetEquilibriumPosition(inputArray);

            // Console.WriteLine(equilibriumPosition.ToString());
            // Console.ReadLine();
            //#endregion


            //Hackerrank.Algorithms.Warmup.SimpleArraySum.Solution.GetSolution();
            //Console.ReadKey();

            //Hackerrank.Algorithms.Warmup.DiagonalDifference.Solution();

           // Hackerrank.Algorithms.Warmup.DiagonalDifference.SolutionWithoutArrays();

           // PuzzleWorld.Hackerrank.Algorithms.Warmup.PlusMinus.Solution();\

           // Hackerrank.Algorithms.Warmup.StairCase.Solution();
          


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
