namespace Bosscoder.Week_4.Homework_Questions
{
    /*
     * The Hamming distance between two integers 
     * is the number of positions at which the corresponding bits are different.
     * 
     * Intuition
     * logic :
     * there are 2 options either follow what ques saying blindly and get higher complexity
     * make all pairs that will take you itself n^2 time and then for each pair going 32 times for bits :( TC : O(n^2)
     * better one is to only run outer loop for each bit and find distance among all numbers at that bit. only in O(n) time thus total O(32*n) time
     * 
     * Approach
     * /for example goin for 1st bit, find out how many ones are there(say k) from n and remaing zeroes will be n-k for 1st bit. now the hamming distance we will get from this 1st bit is ?
     * It is (number of times we get 1s) * (no of zeroes) i.e. = k (n-k) why?
     * coz 1s bit is giving hamming distance from each 0s bit, so k 1s will give distance to ( (n-k) times k ) which is = k(n-k)
     */
    public class HammingDistance
    {
        public int TotalHammingDistance(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < 32; i++)
            {
                var count = 0;
                foreach (var item in nums)
                {
                    if ((item & (1 << i)) > 0) count++;
                }
                res += count * (nums.Length - count);
            }
            return res;
        }
    }
}
