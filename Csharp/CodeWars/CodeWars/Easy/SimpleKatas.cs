using System;
using System.Collections.Generic;
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
            return false;
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


        //Sum all the numbers of the array(in F# and Haskell you get a list) except the highest and the lowest element (the value, not the index!).
        //(The highest/lowest element is respectively only one element at each edge, even if there are more than one with the same value!)
        //Example:
        //{ 6, 2, 1, 8, 10 } => 16
        //{ 1, 1, 11, 2, 3 } => 6
        //If array is empty, null or None, or if only 1 Element exists, return 0.
        public static int Sum(int[] numbers)
        {
            if(numbers == null || numbers.GetLength(0) <= 1)
                return 0;
           var sortedArray =  numbers.OrderBy(x => x).ToArray<int>();
            int sum = 0;
           for(int i=1;i<sortedArray.GetLength(0)-1;i++)
            {
                sum += sortedArray[i];
            }

            return sum;
        }


        //In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

        //Example:

        //Kata.HighAndLow("1 2 3 4 5"); // return "5 1"
        //Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
        //Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
        //Notes:

        //All numbers are valid Int32, no need to validate them.
        //There will always be at least one number in the input string.
        //Output string must be two numbers separated by a single space, and highest number is first.
        public static string HighAndLow(string numbers)
        {
            var numArray =numbers.Split(' ').Select(x=> int.Parse(x));
            return string.Format("{0} {1}",numArray.Max(),numArray.Min());
        }

        
        //Given an array, find the int that appears an odd number of times.
        //There will always be only one integer that appears an odd number of times.
        public static int find_it(int[] seq)
        {
            Dictionary<int,int> dict = new Dictionary<int, int>();
            for(int i = 0;i<seq.GetLength(0);i++)
            {
                int key = seq[i];
                if(dict.ContainsKey(key))
                {
                    dict[key] += 1;
                }
                else
                {
                    dict.Add(key, 1);
                }
            }

            foreach(var key in dict.Keys)
            {
                if(dict[key] % 2 != 0)
                    return key;
            }

            return 1;
        }
    }
}
