using Bosscoder.Models;
using System;

namespace Bosscoder.Mentorship
{
    public class SortArrayWithTwoNumbers
    {        
        [TimeN]
        public int[] SortedArray(int[] arr, int numberToSort, int startIndex)
        {
            int left = startIndex, right = arr.Length - 1;

            while (left < right)
            {
                if (arr[left] == arr[right])
                {
                    if (arr[left] == numberToSort)
                        left++;
                    else
                        right--;
                }
                else if (arr[left] > arr[right])
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    left++;
                    right--;
                }
                else
                {
                    left++;
                    right--;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            return arr;
        }

        public void SortedArrayThreeNumbers(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            int startIndex = 0;

            int[] arraySorted = SortedArray(arr: arr, numberToSort: 0, startIndex: 0);

            while (left < arr.Length)
            {
                if (arr[left] != 0)
                    break;

                startIndex = left+1;
                left++;
            }

            arraySorted = SortedArray(arr: arraySorted, numberToSort: 1, startIndex: startIndex);
        }
    }
}

/*Approach : Sort array with two numbers repeating 
// array - Length - n , arr[] - 0,1 , Sort the array 
// Sliding window
// Counting the no of zeroes
// [0,1,1,0]
// [0,0,1,1]
// Two pointer - i =0 , j = n-1 
// 0 ,0 - i++
/* 0 ,1 - i++ j--
 * 1,0 - swap j-- i++
 * 1,1 - j--
 * 
 * Follow-up - Sort a array with 0,1,2 as its elements of length n.
 * 
 * [0,1,2,0,1,2]
 * 
 * left - 0's , right - 1&2
 */
 
