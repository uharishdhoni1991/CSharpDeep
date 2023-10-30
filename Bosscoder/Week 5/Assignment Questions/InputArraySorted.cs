namespace Bosscoder.Week_5.Assignment_Questions
{
    public class InputArraySorted
    {
        public int[] Solve(int[] input, int target)
        {
            int left = 0;
            int right = input.Length - 1;

            while(left < right)
            {
                int sum = input[left] + input[right];

                if (sum == target)
                    return new int[] { left + 1, right + 1 };

                if (sum > target)
                    right = right - 1;
                else
                    left = left + 1;
            }

            return new int[] { -1, -1 };
        }
    }
}
