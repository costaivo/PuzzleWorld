using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleWorld
{
   public class Program
    {
        public static void Main(string[] args)
        {
            // Equilibrium Problem
            Console.WriteLine("Equilibrium Problem");
            int[] inputArray = new int[] { -1, 1, 0 };
            int equilibriumPosition = Equilibrium.Solution.GetEquilibriumPosition(inputArray);

            Console.WriteLine(equilibriumPosition.ToString());
            Console.ReadLine();
        }
    }
}
