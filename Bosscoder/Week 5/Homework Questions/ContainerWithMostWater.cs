using System;

namespace Bosscoder.Week_5.Homework_Questions
{
    /*Revise and Revisit*/
    /*Approach
    * Initially we consider the area constituting the exterior most lines.
    * Now, to maximize the area, we need to consider the area between the lines of larger lengths. 
    * If we try to move the pointer at the longer line inwards, we won't gain any increase in area, 
    * since it is limited by the shorter line. But moving the shorter line's pointer could turn out to be beneficial, 
    * as per the same argument, despite the reduction in the width. This is done since a relatively longer line obtained by 
    * moving the shorter line's pointer might overcome the reduction in area caused by the width reduction.*/
    public class ContainerWithMostWater
    {
        public int Solve(int[] input)
        {
            int maxarea = 0;
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                int width = right - left;
                maxarea = Math.Max(maxarea, Math.Min(input[left], input[right]) * width);
                if (input[left] <= input[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxarea;
        }
    }
}
