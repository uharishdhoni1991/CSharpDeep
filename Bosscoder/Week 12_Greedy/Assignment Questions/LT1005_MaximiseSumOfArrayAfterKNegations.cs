using System;

namespace Bosscoder.Week_12_Greedy.Assignment_Questions
{
    public class LT1005_MaximiseSumOfArrayAfterKNegations
    {
		//Copy paste // understand logic pls
        public int LargestSumAfterKNegations(int[] A, int K)
        {
			int sum = 0, min = int.MaxValue;
			Array.Sort(A);
			for (int i = 0; i < A.Length; i++)
			{
				//K is zero, just add all the numbers one by one
				if (K == 0)
				{
					sum = sum + A[i];
				}
				else
				{
					//get the minimal absolute value in the array
					if (A[i] < 0)
					{
						sum = sum - A[i];
						K--;
						if (Math.Abs(A[i]) < min)
						{
							min = Math.Abs(A[i]);
						}
					}
					else
					{
						if (A[i] < min)
						{
							min = A[i];
						}
						sum = sum + A[i];
					}
				}
			}
			if (K % 2 != 0)
			{
				sum = sum - 2 * min;
			}
			return sum;
		}
    }
}
