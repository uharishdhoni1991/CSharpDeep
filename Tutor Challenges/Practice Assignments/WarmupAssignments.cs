using System;
using System.Collections.Generic;

namespace Tutor_Challenges.Practice_Assignments
{
    public class WarmupAssignments
    {
        public double PrintSum(int[] array)
        {
            double sum = 0;

            for(int i =0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public int FindIndex(int[] array ,int n)
        {
            int singlePivot = 0;
            int doublePivot = 0;

            for(int i =0; i < array.Length/2; i++)
            {
                if (array[i] == array[singlePivot])
                    return singlePivot;

                if (array[i] == array[doublePivot])
                    return doublePivot;

                singlePivot++;
                doublePivot = doublePivot + 2;
            }

            return -1;
        }

        public int FindElementCountLessThanOrEqualTo(int[]  array, int n)
        {
            int singlePivot = 0;
            int reversePivot = array.Length - 1;
            int matchingCount = 0;

            for(int i = 0; i < array.Length/2; i++)
            {
                if (array[singlePivot] == n)
                    matchingCount++;

                if (array[reversePivot] == n)
                    matchingCount++;

                singlePivot++;
                reversePivot--;
            }

            return matchingCount;
        }

        public int[] PrintAlternateOrder(int[] array)
        {
            List<int> alternateOrdered = new List<int>();

            for(int i = 0; i < array.Length; i++)
            {
                alternateOrdered.Add(array[i]);
                ++i;
            }

            return alternateOrdered.ToArray();
        }

        public int[] IndexEqualToValue(int[] array)
        {
            List<int> indexeqValue = new List<int>();

            for(int i = 0; i < array.Length; i++)
            {
                if (i + 1 == array[i])
                    indexeqValue.Add(array[i]);
            }

            return indexeqValue.ToArray();
        }

        public string CheckAndPrintIfPerfectArray(int[] array)
        {
            bool isPerfect = false;

            for(int i =0; i < array.Length/2; i++)
            {
                isPerfect &= array[i] == array[array.Length - 1 - i];
            }

            if (isPerfect)
                return "PERFECT";
            else
                return "NOT PERFECT";
        }

        public string FindMiddleElement(int[] array)
        {
            //Remove Max Element 
            //Remove Min Element

            Array.Sort(array);
            Array.Reverse(array);

            for(int i = 0; i < array.Length/2; i++)
            {
                array[i] = array[i + 1];
                array[array.Length - i - 1] = array[array.Length - i - 2];
            }

            return "";
        }
    }
}
