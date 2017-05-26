using System;
using System.Linq;

namespace CodeWars.Easy
{
    public  class SimpleKatas
    {
        public static string Longest(string s1, string s2)
        {
            var newString = (s1 + s2).Distinct().OrderBy(x=>x);


            return new string(newString.ToArray());
        }

        
        //
        //You get an array of numbers, return the sum of all of the positives ones.
        //  Example [1,-4,7,12] => 1 + 7 + 12 = 20
        //  Note: array ma
        //  y be empty, in this case return 0.
        public static int PositiveSum(int[] arr)
        {
           var positiveNumbers = arr.Where(x => x > 0);
            return positiveNumbers.Sum();
        }

        // Create a function isDivisible(n,x,y) that checks if a number n is divisible by two numbers x AND y
        public static Boolean isDivisible(long n, long x, long y)
        {
            // your code
        }

        //Invert values
        //Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.
        public static int[] InvertValues(int[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] * -1;
            }
            return input;
        }

        //Even or Odd
        //Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
        public static string EvenOrOdd(int number)
        {
            if(number % 2 == 0)
                return "Even";
            else
                return "False";
        }
    }
}
