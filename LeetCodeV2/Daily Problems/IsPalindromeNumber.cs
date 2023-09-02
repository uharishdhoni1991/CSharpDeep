using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeV2.Daily_Problems
{
    public class IsPalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            bool isPalindrome = false;

            if (x < 0)
                return isPalindrome;

            int actualNumber = x;
            List<int> number = new List<int>();

            while (x != 0)
            {
                int currentDigit = x % 10;
                x = x / 10;
                number.Add(currentDigit);
            }

            double reversedNumber = 0;
            int j = number.Count() - 1;
            for (int i = 0; i < number.Count(); i++)
            {
                reversedNumber += number[i] * Math.Pow(10, j);
                j--;
            }

            isPalindrome = actualNumber - reversedNumber == 0;

            return isPalindrome;
        }
    }
}
