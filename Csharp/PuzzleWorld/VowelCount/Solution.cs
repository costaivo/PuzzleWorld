using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleWorld.VowelCount
{
    /// <summary>
    /// This Problem describes the best use of writing an optimized code using the most of the lanaguage syntax you are working on. 
    /// </summary>
    public class Solution
    {
        public static int GetVowelCount(string str)
        {
            return str.ToLower().Count(c => "aeiou".IndexOf(c) != -1);
        }
    }

    #region Alternative Solution
    public static class SolutionWithExtensionMethofs
    {
        public static int GetVowelCount(this string str)
        {
            return str.ToLower().Count(c => "aeiou".IndexOf(c) != -1);
        }
    }
    #endregion
}


