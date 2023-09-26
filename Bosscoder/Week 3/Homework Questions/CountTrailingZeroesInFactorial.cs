using System;

namespace Bosscoder.Week_3.Homework_Questions
{
    public class CountTrailingZeroesInFactorial
    {
        public int TrailingZeroes(int n)
        {           
            /*Trick here is the number of prime factors in a factorial is the sum of quotient 
             of each of the powers of the prime number while diving the factorial number
            
             Ex: 10! = 10*9*8*7*6*5*4*3*2*1
                       = 2*5*9*2^3*7*2*3*5*2^2*3*2*1
                       = 2^8 * 5^2 * 7
            
             Here to find trailing zeroes we need to find the pairs of 2 and 5 which potentially generate
            a zero.
            
             --> To find number of 2's which divides N factorial we use the trick as
                10/ 2 ^ 1 = 5 - Five 2's 
                10/ 2^ 2 = 2 - Two 2's
                10/ 2 ^ 3 = 1  - One 2's
                
                Totally 8 */

            int countTwo = 0;
            int countFive = 0;
            int i = 1;
            
            while(Math.Pow(2,i) <= n && Math.Pow(5,i) <= n)
            {
                double powerTwo = Math.Pow(2, i);
                double powerFive = Math.Pow(5, i);

                if ((int)(n / powerTwo) > 0)
                    countTwo += (int)(n / powerTwo);

                if ((int)(n / powerFive) > 0)
                    countFive += (int)(n / powerFive);

                i++;
            }

            if (countFive == countTwo)
                return countTwo;
            else if (countFive < countTwo)
                return countFive;
            else
                return countTwo;            
        }       
    }
}
