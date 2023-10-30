using System.Collections.Generic;

namespace Bosscoder.Week_7_StacksAndQueues.Assignement_Questions
{
    /*Using Stack Tuple Approach*/
    public class DailyTemperatures
    {
        public int[] Solve(int[] temperatures)
        {
            if (temperatures == null || temperatures.Length == 0)
                return new int[] { 0 };

            Stack<(int, int)> stack = new Stack<(int, int)>();
            int[] res = new int[temperatures.Length];

            for(int i =0; i < temperatures.Length; i++)
            {
                while(stack.Count > 0 && temperatures[i] > stack.Peek().Item1)
                {
                    int removedIdx = stack.Pop().Item2;
                    res[removedIdx] = i - removedIdx;
                }

                stack.Push((temperatures[i], i));
            }

            return res;
        }
    }
}
