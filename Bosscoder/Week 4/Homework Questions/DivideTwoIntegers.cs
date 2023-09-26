using System;

namespace Bosscoder.Week_4.Homework_Questions
{
    public class DivideTwoIntegers
    {
        /*Intuition
         * If we cannot use multiplication, division and mod then the only thing left is addition and subtraction.Fortunately the intuition is pretty easy to understand for calculating the quotient.Simply keep removing the value of the divisor from the dividend and count how many times you did that - that's your quotient value!
         * To add the sign without using the multiplication and division, we use the same technique of subtracting.To get the negative value of the quotient we simply subtract from it 2 times its value - the way we do that is by using nested loops.
         */

        /*Revise and Revisit*/
        public double GetQuotient(int dividend, int divisor)
        {
            if (dividend == 0)
            {
                return 0;
            }

            bool isResultPositive = (divisor > 0 && dividend > 0) || (divisor < 0 && dividend < 0);

            if (divisor == 1 && dividend == int.MaxValue) return int.MaxValue;
            if (divisor == -1 && dividend == int.MaxValue) return -int.MaxValue;
            if (divisor == 1 && dividend == int.MinValue) return int.MinValue;
            if (divisor == -1 && dividend == int.MinValue) return int.MaxValue;

            Int64 toDivide = dividend;
            Int64 byWhat = divisor;

            toDivide = Math.Abs(toDivide);
            byWhat = Math.Abs(byWhat);

            Int64 quotient = 0;
            while (toDivide > 0)
            {
                if (toDivide - byWhat < 0)
                {
                    break;
                }
                toDivide -= byWhat;
                quotient++;
            }

            if (!isResultPositive)
            {
                // add the sign
                int addSignCount = 2;
                Int64 quotientSignCount = quotient;
                while (addSignCount > 0)
                {
                    for (int i = 0; i < quotientSignCount; i++)
                    {
                        quotient--;
                    }
                    addSignCount--;
                }
            }

            return (int)quotient;
        }
    }
}
