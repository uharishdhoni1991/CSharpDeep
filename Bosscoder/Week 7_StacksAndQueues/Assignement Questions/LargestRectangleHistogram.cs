using System;
using System.Collections;
using System.Collections.Generic;

namespace Bosscoder.Week_7_StacksAndQueues.Assignement_Questions
{
    /*Approach:
      Largest Lefts Array
      Largest Rights Array
      Find Max Area = Heights[i] * (right[i] - left[i] + 1)*/
    public class LargestRectangleHistogram
    {
        public int Solve(int[] heights)
        {
            int n = heights.Length;
            int[] left = new int[n];
            int[] right = new int[n];
            Stack<int> s = new Stack<int>();

            // fill left array
            for (int i = 0; i < n; i++)
            {
                while (s.Count > 0 && heights[s.Peek()] >= heights[i])
                {
                    s.Pop();
                }
                left[i] = s.Count == 0 ? 0 : s.Peek() + 1;
                s.Push(i);
            }

            // clear stack for right array
            s.Clear();

            // fill right array
            for (int i = n - 1; i >= 0; i--)
            {
                while (s.Count > 0 && heights[s.Peek()] >= heights[i])
                {
                    s.Pop();
                }
                right[i] = s.Count == 0 ? n - 1 : s.Peek() - 1;
                s.Push(i);
            }

            // calculate max area
            int maxArea = 0;
            for (int i = 0; i < n; i++)
            {
                maxArea = Math.Max(maxArea, heights[i] * (right[i] - left[i] + 1));
            }

            return maxArea;
        }
    }
}
