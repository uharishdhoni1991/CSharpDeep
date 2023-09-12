namespace Bosscoder.Week_2.Warmup_Questions
{
    public class RunningSum
    {
        public int[] GenerateRunningSum(int[] nums)
        {

            int prevSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = prevSum + nums[i];
                prevSum = nums[i];
            }

            return nums;
        }
    }
}
