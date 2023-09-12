namespace Bosscoder.Week_2.Homework_Questions
{
    public class ArrangePositiveAndNegativeNumbers
    {
        /**Revise and Revisit*/
        public int[] GetArrangedNumberArray(int[] arr)
        {
            int outofplace = -1;
            int n = arr.Length;

            for (int index = 0; index < n; index++)
            {
                if (outofplace >= 0)
                {
                    // find the item which must be moved
                    // into the out-of-place entry if out-of-
                    // place entry is positive and current
                    // entry is negative OR if out-of-place
                    // entry is negative and current entry
                    // is negative then right rotate
                    // [...-3, -4, -5, 6...] --> [...6, -3, -4,
                    // -5...]
                    //     ^                         ^
                    //     |                         |
                    //     outofplace     -->     outofplace
                    //
                    if (((arr[index] >= 0)
                         && (arr[outofplace] < 0))
                        || ((arr[index] < 0)
                            && (arr[outofplace] >= 0)))
                    {
                        RightRotateArray(arr, outofplace, index);

                        // the new out-of-place entry
                        // is now 2 steps ahead
                        if (index - outofplace > 2)
                            outofplace = outofplace + 2;
                        else
                            outofplace = -1;
                    }
                }

                // if no entry has been flagged out-of-place
                if (outofplace == -1)
                {
                    // check if current entry is out-of-place
                    if (((arr[index] >= 0)
                         && ((index & 0x01) == 0))
                        || ((arr[index] < 0)
                            && (index & 0x01) == 1))
                        outofplace = index;
                }
            }

            return arr;
        }

        public void RightRotateArray(int[] arr, int outOfPlace, int current)
        {
            int temp = arr[current];

            int tmp = arr[current];
            for (int i = current; i > outOfPlace; i--)
                arr[i] = arr[i - 1];

            arr[outOfPlace] = tmp;
        }
    }
}
