namespace Bosscoder.Week_2.Assignment_Questions
{
    public class RangeSumInTwoDimensionalMatrix
    {
        private int[][] _m;

        public RangeSumInTwoDimensionalMatrix(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            _m = new int[m + 1][];
            for (int i = 0; i <= m; i++) _m[i] = new int[n + 1];

            //Console.WriteLine(string.Join(",\t", _m[0]));
            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    _m[r + 1][c + 1] = _m[r][c + 1] + _m[r + 1][c] + matrix[r][c] - _m[r][c];
                }
                //Console.WriteLine(string.Join(",\t", _m[r+1]));
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            return _m[row2 + 1][col2 + 1] + _m[row1][col1] - _m[row1][col2 + 1] - _m[row2 + 1][col1];
        }
    }
}
