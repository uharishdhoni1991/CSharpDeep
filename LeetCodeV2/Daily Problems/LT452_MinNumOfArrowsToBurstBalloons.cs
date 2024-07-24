using System;
using System.Linq;

namespace LeetCodeV2.Daily_Problems
{
    public class LT452_MinNumOfArrowsToBurstBalloons
    {
        public int FindMinArrowShots(int[][] points)
        {
            if (points == null || points.Length == 0) return 0;

            // Sort the balloons based on their start points
            Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));

            int arrows = 1;
            int end = points[0][1];

            // Iterate through the balloons and count the arrows needed
            foreach (var balloon in points)
            {
                int start = balloon[0];
                int finish = balloon[1];

                // Check if the current balloon overlaps with the previous one
                if (start > end)
                {
                    arrows++;
                    end = finish; // Update the end point
                }
                else
                {
                    // Adjust the end point to the minimum of the two balloons
                    end = Math.Min(end, finish);
                }
            }

            return arrows;
        }
    }
}
