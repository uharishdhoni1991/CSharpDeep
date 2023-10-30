using System;

namespace Bosscoder.Week_8_LinkedList.HomeWork_Questions
{
    public class MaxUnitsOnATruck
    {
        /*Copy paste - REvisit and Revise*/
        /*- Sort the array
         - Iterate through the array*/
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            Array.Sort(boxTypes, (a, b) => b[1] - a[1]);
            var res = 0;

            foreach (var box in boxTypes)
            {
                if (truckSize >= box[0])
                {
                    res += box[0] * box[1];
                    truckSize -= box[0];
                }
                else
                {
                    res += truckSize * box[1];
                    break;
                }
            }

            return res;
        }
    }
}
