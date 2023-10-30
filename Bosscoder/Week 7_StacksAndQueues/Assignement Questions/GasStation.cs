namespace Bosscoder.Week_7_StacksAndQueues.Assignement_Questions
{
    public class GasStation
    {
        /*Simple loop with no use of Queue*/
        /*Copy paste need to f revise shit*/
        public  int Solve(int[] gas, int[] cost)
        {        
            var total = 0;
            var start = -1;
            var pre = 1;
            for (var x = 0; x < gas.Length; x++)
            {
                var cur = gas[x] - cost[x];

                if (cur >= 0 && total <= pre)
                {
                    start = x;
                    pre = total;
                }
                total += cur;
            }

            return total >= 0 ? start : -1;
        }
    }
}
