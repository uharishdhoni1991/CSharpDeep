using System;
using System.Collections.Generic;

namespace TechGig.Practice
{
    internal class BinaryToDecimal : IExecute
    {
        public void Execute()
        {
            int binaryNumber = Convert.ToInt32(Console.ReadLine());
            Decimal decimalNum = 0;

            Dictionary<int, int> digitArray = new Dictionary<int, int>();
            int tmp = 0;
            int index = 0;

            while (binaryNumber > 0)
            {
                tmp = binaryNumber % 10;
                digitArray[index] = tmp;
                binaryNumber /= 10;
                index++;
            }           

            foreach(var digit in digitArray)
            {
                decimalNum += Convert.ToDecimal(digit.Value * Math.Pow(2, digit.Key));
            }
        }
    }
}