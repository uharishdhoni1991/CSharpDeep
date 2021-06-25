using System;
using System.Collections.Generic;

namespace TechGig.Practice
{
    internal class NumberTypeResolver : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Find if its a ArmStrong/Narcisstic number , 370 - 370 = 3^3+7^3+0^23 (Armstrong), 1654 - 1654 = 1 ^ noOfDigits + .. (Narcisstic");
            int number = Convert.ToInt32(Console.ReadLine());
            int calcNumber = 0;
            calcNumber = CalcNumType(number);

            if (calcNumber == number)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        private static int CalcNumType(int number)
        {
            int result = 0;
            int tmp = 0;
            int noOfDigits = 0;
            List<int> digitArray = new List<int>();

            while (number > 0)
            {
                tmp = number % 10;
                digitArray.Add(tmp);
                number /= 10;
                noOfDigits++;
            }

            int digitArrayCount = digitArray.Count;
            foreach (var digit in digitArray)
            {
                int poweredDigit = (int)Math.Pow(digit, digitArrayCount);
                result += poweredDigit;
            }

            return result;
        }
    }
}