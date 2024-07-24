using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.List.HomeWork_Questions
{
    public class MaxProfitAssignment
    {
        /*Code submitted to Leetcode as Sln*/
        public int GetMaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
        {
            int maxProfit = 0;

            if (difficulty.Length == 0 || profit.Length == 0 || difficulty.Length != profit.Length)
                return maxProfit;

            List<KeyValuePair<int, int>> dict = new List<KeyValuePair<int, int>>();

            for(int i = 0;i < difficulty.Length; i++)
            {
                dict.Add(new KeyValuePair<int, int>(profit[i] , difficulty[i]));
            }

            var orderedD = dict.OrderByDescending(x => x.Key).ToList();

            List<KeyValuePair<int, bool>> workerVisited = new List<KeyValuePair<int, bool>>();

            for(int i =0; i < worker.Length;i++)
            {
                workerVisited.Add(new KeyValuePair<int, bool>(worker[i], false));
            }

            foreach(var dictVal in orderedD.ToList())
            {
                for(int i = 0; i < workerVisited.Count; i++)
                {
                    if (dictVal.Value > workerVisited[i].Key)
                        continue;

                    if (workerVisited[i].Value)
                        continue;

                    maxProfit += dictVal.Key;                    
                    workerVisited[i]= new KeyValuePair<int, bool>(workerVisited[i].Key, true);
                }
            }

            return maxProfit;
        }
    }
}
