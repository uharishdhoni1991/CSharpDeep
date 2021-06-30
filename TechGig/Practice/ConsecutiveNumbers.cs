using System;
using System.Linq;

namespace TechGig.Practice
{
    internal class ConsecutiveNumbers : IExecute
    {
        public void Execute()
        {
            int noofElements = Convert.ToInt32(Console.ReadLine());
            int[] elementArray = new int[noofElements];

            string[] inputElementArray = Console.ReadLine().Split(' ');

            for (int i = 0; i < noofElements; i++)
            {
                elementArray[i] = Convert.ToInt32(inputElementArray[i]);
            }

            elementArray = elementArray.OrderBy(element => element).ToArray();

            int expectedDiff = 1;
            bool isConsecutive = true;

            for(int i = 0; i< noofElements-1; i++)
            {
                if (i == noofElements)
                    return;                

                
                int currentdiff = elementArray[i + 1] - elementArray[i];

                isConsecutive = isConsecutive && currentdiff == expectedDiff;
            }

            Console.WriteLine(isConsecutive);
            Console.ReadLine();
        }
    }
}