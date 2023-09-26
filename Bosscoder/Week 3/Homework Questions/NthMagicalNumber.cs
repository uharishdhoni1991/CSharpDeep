using System;

namespace Bosscoder.Week_3.Homework_Questions
{
    public class NthMagicalNumber
    {
        /*
         * Approach :
         * - Find GCD of a and b to find the number which will have high chances
         *   divide the number completely.
         * - Also known fact using LCM --> Value / a + Value / b - Value / LCM
         * - Then do Dichotomy 
         * 
         * Revist and Revise
         */

        public int FindGCD(int a, int b)
        {
            int Remainder;

            while (a != 0)
            {
                Remainder = b % a;
                b = a;
                a = Remainder;
            }

            return b;
        }

        private static long Guess(long value, int a, int b, int lcm) =>
           value / a + value / b - value / lcm;


        public int GetNthMagicalNumber(int n, int a, int b)
        {
            long left = 1;
            long right = ((long)n + 1) * a;
            int lcm = a * b / FindGCD(a, b);

            while (right - left > 1)
            {
                long middle = (left + right) / 2;

                if (Guess(middle, a, b, lcm) >= n)
                    right = middle;
                else
                    left = middle;
            }

            return (int)(right % 1_000_000_007);

        }
    }
}
