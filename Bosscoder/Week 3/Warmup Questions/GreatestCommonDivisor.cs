using System.Linq;

namespace Bosscoder.Week_3.Warmup_Questions
{
    public class GreatestCommonDivisor
    {
        /*
         arr = {i, i+1, i+2 , .... n}
        2,5,6,9,10
        min = 2
        max = 10
        2 |-| 10 
           5 , remain = 0*/
        public int FindGreatestCommonDivisor(int[] arr)
        {
            int min = arr.Min();
            int max = arr.Max();

            while(min != 0)
            {
                int temp = min;
                min = max % min;
                max = temp;
            }

            return max;
        }
    }
}
