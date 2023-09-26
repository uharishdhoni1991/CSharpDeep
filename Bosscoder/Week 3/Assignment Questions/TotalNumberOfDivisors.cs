namespace Bosscoder.Week_3.Assignment_Questions
{
    public class TotalNumberOfDivisors
    {
        /*Need to understand how primes are calculated*/
        public int GetTotalNumberoFDivisors(int n)
        {
            bool[] primeFactors = new bool[n + 1];

            for(int i = 2; i*i < n; i++)
            {
                if (primeFactors[i])
                    continue;
                
                for(int j = i*i; j < n; j+=i)
                {
                    primeFactors[j] = true;
                }
            }

            int noOfDivisors = 1;

            for(int i =2; i < primeFactors.Length; i++)
            {
                if (primeFactors[i])
                    continue;

                if (n % i != 0)
                    continue;

                int count = 0;

                while(n % i == 0)
                {
                    n = n / i;
                    count++;
                }

                noOfDivisors = noOfDivisors * (count + 1);
            }

            return noOfDivisors;
        }
    }
}
