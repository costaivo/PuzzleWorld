using System;

namespace PuzzleWorld.Hackerrank.Algorithms.Warmup.SimpleArraySum
{
   public  class Solution
    {
       public static void GetSolution()
       {
           Console.WriteLine("Very Simple Sum");
           var rawData = Console.ReadLine();
           int noOfIntergers;
           int.TryParse(rawData, out  noOfIntergers);
           rawData = Console.ReadLine();
           int sum = 0;
           foreach (string s in rawData.Split(' '))
           {
               int currentValue;
               int.TryParse(s, out currentValue);
               sum += currentValue;
           }
           Console.WriteLine("Sum " + sum);
       }
    }
}
