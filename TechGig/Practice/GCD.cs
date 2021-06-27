using System;
using System.Collections.Generic;

namespace TechGig.Practice
{
    internal class GCD : IExecute
    {
        public void Execute()
        {
            string continueStr = "";

            while (continueStr != "N")
            {
                string[] inputArray = Console.ReadLine().Split(' ');
                int numberOne = Convert.ToInt32(inputArray[0]);
                int numberTwo = Convert.ToInt32(inputArray[1]);

                int arrayCounter = numberOne > numberTwo ? numberOne : numberTwo;
                int[] commonFactors = new int[arrayCounter];

                for (int i = 1; i <= arrayCounter; i++)
                {
                    if (numberOne % i == 0
                      && numberTwo % i == 0)
                        commonFactors[i - 1] = i;
                }

                Array.Sort(commonFactors);
                Array.Reverse(commonFactors);

                Console.WriteLine(commonFactors[0]);
                Console.WriteLine("Do u want to continue ?type Y for, N for No");
                continueStr = Console.ReadLine();
            }
        }
    }
}