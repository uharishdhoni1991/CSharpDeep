using System;

namespace TechGig.Practice
{
    internal class SmallestSubArraySort : IExecute
    {
        /*
         Prob : For this challenge, Given an unsorted array arr[0..n-1] of size n, find the minimum length subarray arr[s..e] such that sorting this subarray makes the whole array sorted.

         Algo:

         --> Find the max and min number of the input array
         --> Find the index at which the number is less than the Max and closest to it in terms of value - nearest Max
         --> Find the index at which the number is greater than the Min and closest to it in terms of value - nearest Min
         --> Find the index at which this nearest Min element will properly be placed
         --> Find the index at which this nearest Max element will properly be placed

         * Input
           13
           1 2 4 7 10 11 7 12 3 7 16 18 19
         * Output
           4 7 10 11 7 12 3 7
         */
        public void Execute()
        {
            Console.WriteLine("Smallest subarray length to sort");
            int inputArrayLength = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = new int[inputArrayLength];

            string[] inputStringArray = Console.ReadLine().Split(' ');
            int leftIndex = -1, rightIndex = -1;

            for (int i = 0; i < inputArrayLength; i++)
            {
                inputArray[i] = Convert.ToInt32(inputStringArray[i]);
            }

            // Find Max so far
            int maxSoFar = int.MinValue;
            for (int i = 0; i < inputArrayLength; i++)
            {
                if (maxSoFar < inputArray[i])
                {
                    maxSoFar = inputArray[i];
                }

                //Find the final index that is less than the maximum so far
                if (inputArray[i] < maxSoFar)
                {
                    rightIndex = i;
                }
            }

            // Find Max so far
            int minSoFar = int.MaxValue;
            for (int i = inputArrayLength - 1; i >= 0; i--)
            {
                if (minSoFar > inputArray[i])
                {
                    minSoFar = inputArray[i];
                }

                //Find the final index that is greater than the minimum so far
                if (inputArray[i] > minSoFar)
                {
                    leftIndex = i;
                }
            }

            for (int i = leftIndex; i <= rightIndex; i++)
            {
                Console.Write(inputArray[i]);

                if (i == rightIndex)
                    break;

                Console.Write(" ");

            }

            Console.ReadLine();           

        }
    }
}