using System.Collections.Generic;

namespace Bosscoder.Week_5.Assignment_Questions
{
    public class AnagramString
    {
        public bool Solve(string s1, string s2)
        {
            int s1Length = s1.Length;
            int s2Length = s2.Length;
            int matchingCount = 0;

            if (s1Length != s2Length)
                return false;

            HashSet<int> s1Hash = new HashSet<int>();

            foreach(var ele in s1)
            {
                s1Hash.Add(ele);
            }

            foreach(var ele in s2)
            {
                if (s1Hash.Contains(ele))
                    matchingCount++;
            }

            return matchingCount == s1Length;
        }
    }
}