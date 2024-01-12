using System;

namespace Bosscoder.Week_12_Greedy.Assignment_Questions
{
    public class GFG_AssignMiceToHoles
    {
        public int Solve(int[] input1, int[] input2)
        {
            if (input1.Length != input2.Length)
                return -1;

            Array.Sort(input1);
            Array.Sort(input2);

            int res = int.MinValue;

            for(int i = 0; i < input1.Length; i++)
            {
                res = Math.Max(res, Math.Abs(input1[i] - input2[i]));
            }

            return res;
        }
    }
}