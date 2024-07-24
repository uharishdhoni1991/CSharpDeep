using System.Collections.Generic;

namespace Bosscoder.List.HomeWork_Questions
{
    /*Revisit and Revise*/
    public class LetterCombinationInPhoneNumber
    {
        public IList<string> res = new List<string>();
        Dictionary<char, char[]> keyPad;

        public IList<string> Solve(string s)
        {
            keyPad = new Dictionary<char, char[]>()
            {
                ['2'] = new char[] { 'a', 'b', 'c' },
                ['3'] = new char[] { 'd', 'e', 'f' },
                ['4'] = new char[] { 'g', 'h', 'i' },
                ['5'] = new char[] { 'j', 'k', 'l' },
                ['6'] = new char[] { 'm', 'n', 'o' },
                ['7'] = new char[] { 'p', 'q', 'r', 's' },
                ['8'] = new char[] { 't', 'u', 'v' },
                ['9'] = new char[] { 'w', 'x', 'y', 'z' }
            };          

            return GetCombinations(s);
        }

        private IList<string> GetCombinations(string s)
        {
            if (s.Length > 0)
                Repeat("", s, 0);

            return res;
        }

        private void Repeat(string current, string digits, int index)
        {
            if (index == digits.Length)
                res.Add(current);
            else
            {
                char[] chars = keyPad[digits[index]];

                foreach (char c in chars)
                    Repeat(current + c, digits, index + 1);
            }
        }
    }
}
