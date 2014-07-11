using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Equilibrium Pronlem
            Console.WriteLine("Equilibrium Problem");
            int[] A = new int[] { -1, 1, 0 };
            int i =  Equilibrium.Solution.GetEquilibriumPosition(A);

            Console.WriteLine(i.ToString());
            Console.ReadLine();
            #endregion 
        }
    }
}
