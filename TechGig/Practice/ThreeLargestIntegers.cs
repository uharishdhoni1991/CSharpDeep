using System;

namespace TechGig.Practice
{
    public class ThreeLargestIntegers : IExecute
    {
        public void Execute()
        {
            int[] threeLargestNums = GetThreeLargest(new int[] { 141, -3, 7, -7, 8, -27 });
            int[] threeLargestNums2 = GetThreeLargest(new int[] { 0, 0, 7, 7, 6, 5, 1, -2 });
        }

        [TimeNLogN]
        public int[] GetThreeLargest(int[] input)
        {
            int fLarge = input[0];
            int sSLarge = input[1];
            int tLarge = input[2];

            for (int i = 3; i < input.Length; i++)
            {
                int item = input[i];
                int? temp = null;

                if (item > fLarge)
                {
                    temp = fLarge;
                    fLarge = item;
                }

                int? temp2 = null;
                if (temp.HasValue)
                {
                    if (temp.Value > sSLarge)
                    {
                        temp2 = sSLarge;
                        tLarge = temp.Value;
                        temp = temp2.Value;
                    }
                }
                else if (item > sSLarge)
                {
                    temp = sSLarge;
                    sSLarge = item;
                }

                if (temp.HasValue && temp.Value > tLarge)
                    tLarge = temp.Value;
                else if (item > tLarge)
                    tLarge = item;


                if (sSLarge > fLarge)
                {
                    temp = sSLarge;
                    sSLarge = fLarge;
                    fLarge = temp.Value;
                }

                if (tLarge > sSLarge)
                {
                    temp = sSLarge;
                    sSLarge = tLarge;
                    tLarge = temp.Value;
                }

                if (tLarge > fLarge)
                {
                    temp = fLarge;
                    fLarge = tLarge;
                    tLarge = temp.Value;
                }
            }

            return new int[] { fLarge, sSLarge, tLarge };
        }
    }
}