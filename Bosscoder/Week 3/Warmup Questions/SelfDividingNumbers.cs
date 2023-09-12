using System.Collections.Generic;

namespace Bosscoder.Week_3.Warmup_Questions
{
    public class SelfDividingNumbers
    {
        public IList<int> ExtractSelfDividingNumbers(int left, int right)
        {
            /*Dry run : {1,2,3,4,5}
            left = 1, right = 5, temp = 1, allDivisible = false
            remain = 1 % 10 = 1 , quotient = 0
            allDivisible = 1 % 1 == 0 - self.Add

            temp = 1/10 = 0
            exit loop
            */
            List<int> self = new List<int>();

            for (int i = left; i <= right; i++)
            {
                CheckDivisible(i, self);
            }

            return self;
        }

        private void CheckDivisible(int number, List<int> self)
        {
            int temp = number;
            bool allDivisible = true;

            while (temp != 0)
            {
                int remainder = temp % 10;

                if (remainder == 0)
                {
                    allDivisible = false;
                    break;
                }

                int quotient = temp / 10;
                allDivisible = allDivisible && (number % remainder == 0);

                temp = temp / 10;
            }

            if (allDivisible)
                self.Add(number);
        }
    }
}
