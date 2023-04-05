using System;
using System.Collections.Generic;

namespace TechGig.Practice
{
    public class Semornilap : IExecute
    {
        public void Execute()
        {
            var o_p = GetSPStrings(new string[] { "po", "li", "op", "il" });
        }

        [TimeN2]
        public List<List<string>> GetSPStrings(string[] input)
        {
            if (input == null || input.Length == 0)
                return null;

            HashSet<string> wordset = new HashSet<string>(input);
            List<List<string>> semornilap = new List<List<string>>();            

            foreach(var item in input)
            {
                string reverse = GetRev(item);
                if (wordset.Contains(reverse) && !reverse.Equals(item))
                {
                    List<string> semordnilapPair = new List<string>()
                    {
                        item, reverse
                    };

                    semornilap.Add(semordnilapPair);
                    wordset.Remove(item);
                    wordset.Remove(reverse);
                }
            }

            return semornilap;
        }

        private string GetRev(string input)
        {
            string reversedString = string.Empty;

            for (int i = input.ToCharArray().Length - 1; i > -1; i--)
            {                
                reversedString += input.ToCharArray()[i];
            }

            return reversedString;
        }
    }
}
