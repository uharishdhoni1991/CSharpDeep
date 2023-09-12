namespace Bosscoder.Week_2.Homework_Questions
{
    public class ReshapeMatrix
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (mat.Length * mat[0].Length != r * c)
                return mat;

            int[][] matrix = new int[r][];

            for(int i = 0;  i < matrix.Length; i++)
            {
                matrix[i] = new int[c];
            }

            int rowMat = 0, colMat = 0, rowMatrix = 0, colMatrix =0;

            while(rowMat < mat.Length && rowMatrix < matrix.Length)
            {
                matrix[rowMatrix][colMatrix] = mat[rowMat][colMat];

                colMat++;
                colMatrix++;

                if(colMat == mat[0].Length)
                {
                    colMat = 0;
                    rowMat++;
                }


                if (colMatrix == matrix[0].Length)
                {
                    colMatrix = 0;
                    rowMatrix++;
                }
            }

            return matrix;
        }
    }
}
