namespace Bosscoder.Week_2.Homework_Questions
{
    public class TransposeMatrix
    {
        public int[][] GetMatrixTranspose(int[][] matrix)
        {
            int row = 0, col = 0, colLength = matrix[row].Length;
            int[][] matrix2 = new int[colLength][];
            int j = 0;

            for (int i = 0; i < matrix2.Length; i++)            
                matrix2[i] = new int[matrix.Length];             
            

            while(row < matrix2.Length)
            {
                matrix2[row][col] = matrix[col][row];

                
                col++;

                if(col == matrix2[row].Length)
                {
                    col = 0;
                    row++;
                }
            }

            return matrix2;
        }
    }
}
