using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder_MAQ.Arrays
{
    public class LT2022_Convert1Dto2D
    {
        public int[][] Construct2DArray(int[] original, int m, int n)
        {
            int[][] result = new int[m][];

            if (m * n != original.Length)
            {
                return new int[0][];
            }

            for (int i = 0; i < m; i++)
            {
                result[i] = new int[n];

                for (int j = 0; j < n; j++)
                {
                    result[i][j] = original[i * n + j];
                }
            }

            return result;
        }
    }
}
