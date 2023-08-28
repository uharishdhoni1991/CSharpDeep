using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week1.Assignment_Questions
{
    public class SpiralMatrix
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++) matrix[i] = new int[n];

            int c = -1, r = 0, cMax = n - 1, rMin = 1, cMin = 0, rMax = n - 1, cStep = 1, rStep = 0;
            for (int i = 1; i <= n * n; i++)
            {
                c += cStep;
                r += rStep;
                matrix[r][c] = i;

                if (c == cMax && cStep > 0)
                {
                    cStep = 0;
                    rStep = 1;
                    cMax--;
                }
                if (r == rMax && rStep > 0)
                {
                    cStep = -1;
                    rStep = 0;
                    rMax--;
                }
                if (c == cMin && cStep < 0)
                {
                    rStep = -1;
                    cStep = 0;
                    cMin++;
                }
                if (r == rMin && rStep < 0)
                {
                    rStep = 0;
                    cStep = 1;
                    rMin++;
                }
            }

            return matrix;

        }
    }
}