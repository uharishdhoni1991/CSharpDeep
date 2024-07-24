using Bosscoder.Models;
using System;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    public class LT64_MinimumPathSum
    {
        private int[][] _mat;
        private int[][] _dp;

        /*Traverse by row or col
          if row limit reached , return and try col and vice versa
        */

        public int Solve(int[][] mat)
        {
            _mat = mat;
            return Recurse(0, 0, mat.Length, mat[0].Length, 0, int.MaxValue);
        }

        public int SolveMemo(int[][] mat)
        {
            _mat = mat;
            return Memoize();
        }

        [TimeLimitExceeded]
        private int Recurse(int i, int j, int row, int col, int currSum, int minSum)
        {
            if ((i == row - 1  && j == col) || (i == row && j == col - 1))
                return Math.Min(currSum, minSum);

            if (i == row || j == col)
                return minSum;

            currSum += _mat[i][j];

            int minSum1 = Recurse(i + 1, j, row, col, currSum, minSum);
            int minsSum2 = Recurse(i, j + 1, row, col, currSum, minSum);

            return Math.Min(minSum1, minsSum2);
        }

        [NoSpace]
        private int Memoize()
        {
            int row = _mat.Length;
            int col = _mat[0].Length;           

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    if (i == 0)
                    {
                        _mat[i][j] += _mat[i][j - 1];
                        continue;
                    }

                    if (j == 0)
                    {
                        _mat[i][j] += _mat[i - 1][j];
                        continue;
                    }

                    _mat[i][j] += Math.Min(_mat[i - 1][j], _mat[i][j - 1]);
                }
            }

            return _mat[row - 1][col - 1];
        }
    }
}
