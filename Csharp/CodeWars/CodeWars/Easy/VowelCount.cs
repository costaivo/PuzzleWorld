using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Return the number(count) of vowels in the given string.

We will consider a, e, i, o, and u as vowels for this Kata.
*/
namespace CodeWars.Easy
{
    public class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            string vowels ="aeiou";
           vowelCount = str.Count(x => vowels.Contains(x));

        return vowelCount;
        }
    }
}
