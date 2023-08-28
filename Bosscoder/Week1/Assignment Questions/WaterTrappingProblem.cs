using System;

namespace Bosscoder.Week1.Assignment_Questions
{
    public class WaterTrappingProblem
    {
        public int Trap(int[] height)
        {
            int n = height.Length;
            int left = 0, right = n - 1;
            int l = 0, r = 0, ans = 0;
            while (left <= right)
            {
                if (height[left] <= height[right])
                {                    
                    l = max(l, height[left]);
                    ans += l - height[left];
                    left++;
                }
                else if (height[left] > height[right])
                {
                    r = max(r, height[right]);
                    ans += r - height[right];
                    right--;
                }
            }
            return ans;
        }

        private int max(int l, int p)
        {
            if (l > p)
                return l;
            else
                return p;
        }
    }
}
