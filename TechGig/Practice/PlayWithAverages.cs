using System;

namespace TechGig.Practice
{
    internal class PlayWithAverages : IExecute
    {
        /*
         * Play With Average (100 Marks)
           For this challenge, you need to take number of elements as input on one line and array elements as an input on another line.
           You need to find the average of even numbers, then the average of odd numbers and add them (round the averages to the nearest integers).

           Constraints
           1 < N < 10^5
           1 < A[i] < 10^5

           Output Format
           You will print the value after addition of the two averages to the stdout. 
            
           Sample TestCase 1
           Input 
           6
           11 22 33 44 55 66
        
           Output
           77
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

            int oddSum = 0;
            int odds = 0;
            int evens = 0;
            int evenSum = 0;

            for (int i = 0; i < noofElements; i++)
            {
                if (elementArray[i] % 2 == 0)
                {
                    evenSum += elementArray[i];
                    evens++;
                }
                else
                {
                    oddSum += elementArray[i];
                    odds++;
                }
            }

            double evenAverage = odds == 0 ? 0 : (double)oddSum / (double)odds;
            double oddAverage = evens == 0 ? 0 : (double)evenSum / (double)evens;

            Console.WriteLine(Math.Round(evenAverage) + Math.Round(oddAverage));
            Console.ReadLine();
        }
    }
}