using Bosscoder.Models;
using System.Collections.Generic;

namespace Bosscoder.List.Homework_Questions
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(Node head)
        {
            List<int> values = new List<int>();

            while(head != null)
            {
                values.Add(head.Val);
                head = head.Next;
            }

            for(int i=0,j=values.Count - 1; i <= values.Count/2  && j >= values.Count / 2; i++, j--)
            {
                if (!(values[i] == values[j]))
                    return false;
            }

            return true;
        }
    }
}
