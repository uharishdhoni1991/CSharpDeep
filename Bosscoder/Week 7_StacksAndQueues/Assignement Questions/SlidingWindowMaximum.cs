using System;
using System.Collections.Generic;

namespace Bosscoder.Week_7_StacksAndQueues.Assignement_Questions
{
    public class SlidingWindowMaximum
    {
        /*Tried first*/
        // public int[] Solve(int[] input, int k)
        //{   

        //int currMax = int.MinValue;
        //int prevMax = int.MinValue;
        //List<int> maxWindArr = new List<int>();
        //Queue<int> queue = new Queue<int>();

        //for(int i= 0; i <= input.Length; i++)
        //{                
        //    if(queue.Count == k)
        //    {                    
        //        maxWindArr.Add(currMax);

        //        if (queue.Dequeue() == currMax)
        //        {
        //            if (queue.Contains(prevMax))
        //            {
        //                currMax = prevMax;
        //                prevMax = int.MinValue;
        //            }
        //            else
        //            {
        //                currMax = int.MinValue;
        //                prevMax = int.MinValue;
        //            }
        //        }
        //    }

        //    if (i == input.Length)
        //        break;

        //    queue.Enqueue(input[i]);

        //    if(input[i] > currMax)
        //    {
        //        prevMax = currMax;
        //        currMax = input[i];
        //    }
        //    else if(input[i] > prevMax)
        //    {
        //        prevMax = input[i];
        //    }
        //}

        //return maxWindArr.ToArray();
        // }


        /*Actual Sln*/
        //public int[] Solve(int[] input, int k)
        //{
        //    if (nums.Length == 0 || k == 0)
        //    {
        //        return new int[0];
        //    }

        //    int n = nums.Length;
        //    int[] result = new int[n - k + 1];
        //    int ri = 0; // Index for the result array

        //    // Create a Deque (Double-ended queue) to store indices of elements
        //    // The front of the Deque will always have the index of the maximum element in the current window
        //    LinkedList<int> deque = new LinkedList<int>();

        //    for (int i = 0; i < n; i++)
        //    {
        //        // Remove indices of elements that are out of the current window from the front of the Deque
        //        while (deque.Count > 0 && deque.First.Value < i - k + 1)
        //        {
        //            deque.RemoveFirst();
        //        }

        //        // Remove indices of elements that are smaller than the current element from the back of the Deque
        //        while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
        //        {
        //            deque.RemoveLast();
        //        }

        //        // Add the current index to the back of the Deque
        //        deque.AddLast(i);

        //        // If the window has moved to the point where it contains 'k' elements, start storing the maximum for each window
        //        if (i >= k - 1)
        //        {
        //            result[ri++] = nums[deque.First.Value];
        //        }
        //    }

        //    return result;
        //}
    }
}
