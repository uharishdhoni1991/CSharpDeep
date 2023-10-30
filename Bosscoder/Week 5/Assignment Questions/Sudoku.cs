using System.Collections.Generic;

namespace Bosscoder.Week_5.Assignment_Questions
{
    /*Subgrid index formula - no idea . revisit and revise*/
    public class Sudoku
    {
        public bool Solve(int[][] board)
        {
            HashSet<int>[] rows = new HashSet<int>[9];
            HashSet<int>[] cols = new HashSet<int>[9];
            HashSet<int>[] blocks = new HashSet<int>[9];

            for (int i = 0; i < 9; i++)
            {
                rows[i] = new HashSet<int>();
                cols[i] = new HashSet<int>();
                blocks[i] = new HashSet<int>();
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == 0) continue;

                    int curr = board[i][j];
                    if (rows[i].Contains(curr) || cols[j].Contains(curr) || blocks[(i / 3) * 3 + j / 3].Contains(curr))
                        return false;

                    rows[i].Add(curr);
                    cols[j].Add(curr);
                    blocks[(i / 3) * 3 + j / 3].Add(curr);
                }
            }

            return true;
        }
    }
}
