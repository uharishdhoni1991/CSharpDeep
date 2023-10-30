using System.Collections.Generic;

namespace Bosscoder.Week_6.Homework_Questions
{
    public class FindPairSumInArray
    {
        public List<List<int>> Solve(int[] arr)
        {
            HashSet<int> input = new HashSet<int>();
            List<List<int>> res = new List<List<int>>();

            foreach(var item in arr)
            {
                input.Add(item);
            }

            for(int i =0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (input.Contains(arr[i] + arr[j]))
                        res.Add(new List<int>() { arr[i], arr[j] });
                }
            }

            return res;
        }
    }
}
