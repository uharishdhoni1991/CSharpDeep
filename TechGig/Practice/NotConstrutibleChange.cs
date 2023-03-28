using System;

namespace TechGig.Practice
{
    public class NotConstrutibleChange : IExecute
    {
        public void Execute()
        {
            int[] array = new int[] {2,5,1,3,1,7,22};
            int nCC = GetNCC(array);
        }

        public int GetNCC(int[] input)
        {
            int expectedChange = 0;

            if (input == null)
                return expectedChange+1;

            Array.Sort(input);

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] > expectedChange +1 )
                    return expectedChange + 1;

                expectedChange+= input[i];
            }

            return expectedChange + 1;
        }
    }
}
