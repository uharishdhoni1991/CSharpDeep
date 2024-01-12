using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    //Revise and Revisit
    public class LT91_DecodeWays
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        public int NumDecodings(string s)
        {
            return Recurse(s, 0);
        }

        [Recursion]
        private int Recurse(string s, int index)
        {
            // Base case: if the index reaches the end of the string
            if (index >= s.Length)
            {
                return 1; // This is a valid decoding
            }

            // Check for leading zero
            if (s[index] == '0')
            {
                return 0; // This decoding is invalid
            }

            // Decode single digit
            int ways = Recurse(s, index + 1);

            // Decode two digits if possible
            if (index + 1 < s.Length && ((s[index] == '1' && s[index + 1] <= '9') || (s[index] == '2' && s[index + 1] < '7')))
            {
                ways += Recurse(s, index + 2);
            }

            return ways;
        }

        [Memoization]
        private int RecurseMemo(string s, int index)
        {
            if (dict.ContainsKey(index))
                return dict[index];

            // Base case: if the index reaches the end of the string
            if (index >= s.Length)
            {
                return 1; // This is a valid decoding
            }

            // Check for leading zero
            if (s[index] == '0')
            {
                return 0; // This decoding is invalid
            }

            // Decode single digit
            int ways = RecurseMemo(s, index + 1);

            // Decode two digits if possible
            if (index + 1 < s.Length && ((s[index] == '1' && s[index + 1] <= '9') || (s[index] == '2' && s[index + 1] < '7')))
            {
                ways += RecurseMemo(s, index + 2);
            }

            dict[index] = ways;

            return ways;
        }
    }
}