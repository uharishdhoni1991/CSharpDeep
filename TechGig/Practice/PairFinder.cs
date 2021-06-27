
using System;

namespace TechGig.Practice
{
    internal class PairFinder : IExecute
    {
        public void Execute()
        {
            string input = Console.ReadLine();
            int inputArrayLength = Convert.ToInt32(input);

            int[] inputArray = new int[inputArrayLength];
            string[] inputStringArray = Console.ReadLine().Split(' ');

            for (int i = 0; i < inputArrayLength; i++)
            {
                inputArray[i] = Convert.ToInt32(inputStringArray[i]);
            }

            int pairToCheck = Convert.ToInt32(Console.ReadLine());
            bool pairFound = false;

            for (int i = 0; i < inputArrayLength; i++)
            {
                if (pairFound)
                    break;

                for (int j = i + 1; j < inputArrayLength; j++)
                {
                    if (pairFound)
                        break;

                    if (inputArray[i] + inputArray[j] == pairToCheck)
                    {
                        Console.WriteLine("True");
                        pairFound = true;
                    }

                }
            }
        }
    }
}