using System;

namespace TechGig.Practice
{
    internal class PrimeNoInRange : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Prime nos between a range");
            int rangeLower = Convert.ToInt32(Console.ReadLine());
            int rangeHigher = Convert.ToInt32(Console.ReadLine());
            int primeNoCount = 0;

            for (int i = rangeLower; i <= rangeHigher; i++)
            {
                if (i - 1 == 0)
                    continue;

                if (i + 1 == 100000)
                    break;

                int counter = i - 1;
                bool isPrime = true;

                while (true)
                {
                    if (counter == 1)
                        break;

                    int number = i;

                    if (i % counter == 0)
                    {
                        isPrime = false;
                        break;
                    }

                    counter--;
                }

                if (isPrime)
                    primeNoCount++;
            }

            Console.WriteLine(primeNoCount);
            Console.ReadLine();
        }
    }
}