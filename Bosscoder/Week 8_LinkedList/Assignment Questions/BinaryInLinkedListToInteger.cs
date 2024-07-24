using Bosscoder.Models;
using System;
using System.Collections.Generic;

namespace Bosscoder.List.Assignment_Questions
{
    public class BinaryInLinkedListToInteger
    {
        public int Solve(Node head)
        {
            List<int> bits = new List<int>();

            while (head != null)
            {
                bits.Add(head.Val);
                head = head.Next;
            }

            double result = 0;
            for (int i = 0, j = bits.Count - 1; i <= bits.Count - 1 && j >= 0; j--, i++)
            {
                result += bits[j] * Math.Pow(2, i);
            }

            return Convert.ToInt32(result);
        }
    }
}
