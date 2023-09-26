namespace Bosscoder.Week_4.Homework_Questions
{
    public class CheckIfArrayCanBeMadeSingleElementAsZero
    {
        /*The approach is rather simple, we just have to find the XOR of the elements of the array
         * and if it’s odd, then dividing or splitting it will be of any use as every time 
         * the value of XOR will always come odd, and if it’s even we have our answer i.e. 0.
         */
        public bool OnlyMergeAndSplit(int[] n)
        {
            int xor = 0;

            for(int i = 0; i < n.Length; i++)
            {
                xor = xor ^ n[i];
            }

            return xor % 2 == 0;
        }
    }
}
