using System;

namespace TechGig.Practice
{
    internal class MulOfOddAndEven : IExecute
    {
        /* Multiplication between odd and even 
         * For this challenge, you need to take number of elements as input on one line and array elements as an input on another line. 
         * You need to find the numbers that are odd, add them. find the numbers that are even add them and then multiply the two values that you get after addition of even numbers and that of addition of odd numbers.
         * 
         * Input
            6
            11 22 33 44 55 66
           Output
            13068
         */

        public void Execute()
        {
            int noofElements = Convert.ToInt32(Console.ReadLine());
            int[] elementArray = new int[noofElements];

            string[] inputElementArray = Console.ReadLine().Split(' ');

            for (int i = 0; i < noofElements; i++)
            {
                elementArray[i] = Convert.ToInt32(inputElementArray[i]);
            }

            int evenAdd = 0;
            int oddAdd = 0;

            for (int i = 0; i < noofElements; i++)
            {
                if (elementArray[i] % 2 == 0)
                    evenAdd += elementArray[i];
                else
                    oddAdd += elementArray[i];
            }

            Console.WriteLine(evenAdd * oddAdd);
        }
    }
}