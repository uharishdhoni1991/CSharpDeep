namespace LeetCodeV2.Daily_Problems
{
    public class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] product = new int[nums.Length];
            int num = 1, i;

            for (i = 0; i < nums.Length; i++)
            {
                product[i] = num;
                num *= nums[i];
            }
            num = 1;

            for (i = nums.Length - 1; i >= 0; i--)
            {
                product[i] *= num;
                num *= nums[i];
            }
            return product;

        }
    }
}
