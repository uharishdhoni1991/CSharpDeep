using System;
namespace Bosscoder.Week1.Assignment_Questions
{
    public class MaxGapProblem
    {
        public int MaximumGap2(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return 0;

            int min = nums[0];
            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                min = Math.Min(nums[i], min);
                max = Math.Max(nums[i], max);
            }

            Bucket[] buckets = new Bucket[nums.Length + 1];

            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new Bucket();
            }

            int diff = max - min;
            double interval = (double)nums.Length / (diff == 0 ? 1 : diff);

            for (int i = 0; i < nums.Length; i++)
            {
                int index = (int)((nums[i] - min) * interval);

                if (buckets[index].Low == -1)
                {
                    buckets[index].Low = nums[i];
                    buckets[index].High = nums[i];
                }
                else
                {
                    buckets[index].Low = Math.Min(buckets[index].Low, nums[i]);
                    buckets[index].High = Math.Max(buckets[index].High, nums[i]);
                }
            }

            int result = 0;
            int prev = buckets[0].High;
            for (int i = 1; i < buckets.Length; i++)
            {
                if (buckets[i].Low != -1)
                {
                    result = Math.Max(result, buckets[i].Low - prev);
                    prev = buckets[i].High;
                }
            }

            return result;
        }

        private class Bucket
        {
            private int low = -1;
            private int high = -1;

            public int Low { get { return low; } set { low = value; } }
            public int High { get { return high;} set {high = value;} }
        }

        private int Max(int v1, int v2)
        {
            if (v1 > v2)
                return v1;
            else
                return v2;
        }
    }
}
