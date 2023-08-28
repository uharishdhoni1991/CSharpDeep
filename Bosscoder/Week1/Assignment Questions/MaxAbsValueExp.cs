using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week1.Assignment_Questions
{
    public class MaxAbsValueExp
    {
        public int MaxAbsValExpr(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return 0;

            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;
            int max4 = int.MinValue;
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;
            int min3 = int.MaxValue;
            int min4 = int.MaxValue;

            for (int i = 0; i < arr1.Length; i++)
            {
                max1 = Math.Max(arr1[i] + arr2[i] + i, max1);
                min1 = Math.Min(arr1[i] + arr2[i] + i, min1);
                max2 = Math.Max(i - arr1[i] - arr2[i], max2);
                min2 = Math.Min(i - arr1[i] - arr2[i], min2);
                max3 = Math.Max(arr1[i] - arr2[i] + i, max3);
                min3 = Math.Min(arr1[i] - arr2[i] + i, min3);
                max4 = Math.Max(arr2[i] - arr1[i] + i, max4);
                min4 = Math.Min(arr2[i] - arr1[i] + i, min4);
            }
            return Math.Max(Math.Max(max1 - min1, max2 - min2), Math.Max(max3 - min3, max4 - min4));
        }
    }
}