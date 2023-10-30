using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week_7_StacksAndQueues.Assignement_Questions
{
    /*Copy paste - Revisit and Revise*/
    public class LongestValidParantheses
    {
        public int Solve(string s)
        {
            Stack<int> index = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    index.Push(i);
                }
                else
                {
                    if (index.Any() && s[index.Peek()] == '(')
                    {
                        index.Pop();
                    }
                    else
                    {
                        index.Push(i);
                    }
                }
            }
            if (!index.Any())
            {
                return s.Length;
            }
            int length = s.Length, unwanted = 0;
            int result = 0;
            while (index.Any())
            {
                unwanted = index.Peek();
                index.Pop();
                result = Math.Max(result, length - unwanted - 1);
                length = unwanted;
            }
            result = Math.Max(result, length);
            return result;
        }
    }
}
