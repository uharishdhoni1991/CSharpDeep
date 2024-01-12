using System;
using System.Collections.Generic;
using System.Text;

namespace Bosscoder.Week_9_RecursionAndBackTracking.Assignement_Questions
{
    public class LT51_NQueens
    {
        //Need to understand deeply and revise
        public IList<IList<string>> SolveNQueens(int n)
        {
            var result = new List<IList<string>>();
            var unsafeCells = new bool[n, n];

            GetSafeQueenPositions(unsafeCells, 0, new List<string>(), result);

            return result;
        }

        public static void GetSafeQueenPositions(bool[,] unsafeCells, int row, IList<string> positions, IList<IList<string>> result)
        {
            // Iterating through columns for incoming `row` to find the safe queen position
            for (var column = 0; column < unsafeCells.GetLength(1); column++)
            {
                if (unsafeCells[row, column]) continue; // continue for unsafe cells

                var pos = new StringBuilder(new string('.', unsafeCells.GetLength(1)));
                pos[column] = 'Q';
                positions.Add(pos.ToString());

                if (row == unsafeCells.GetLength(0) - 1)
                {
                    // Colecting safe positions when reaching the last `row`
                    result.Add(new List<string>(positions));
                    // Removing current position when returning back to the previous recursion level
                    positions.RemoveAt(positions.Count - 1);

                    return;
                }

                // Clone incoming board for every row we process, to clean up the marked cells from the previous run
                var cloned = new bool[unsafeCells.GetLength(0), unsafeCells.GetLength(1)];
                System.Array.Copy(unsafeCells, cloned, cloned.Length);
                MarkUnsafeCells(cloned, row, column); // mark unsafe cells as 'true'

                GetSafeQueenPositions(cloned, row + 1, positions, result);
                // Removing current position when returning back to the previous recursion level
                positions.RemoveAt(positions.Count - 1);
            }
        }

        /// <summary>
        /// Marks unsafe cells (as true), for a given queen position
        /// </summary>
        private static void MarkUnsafeCells(bool[,] board, int row, int col)
        {
            // cells in a given column (col)
            for (var r = 0; r < board.GetLength(0); r++) if (!board[r, col]) board[r, col] = true;
            // cells in a given row (row)
            for (var c = 0; c < board.GetLength(1); c++) if (!board[row, c]) board[row, c] = true;
            // cells in a diagonal from a given cell (row, col) to bottom right
            for (int r = row + 1, c = col + 1; r < board.GetLength(0) && c < board.GetLength(1); r++, c++) if (!board[r, c]) board[r, c] = true;
            // cells in a diagonal from a given cell (row, col) to bottom left
            for (int r = row + 1, c = col - 1; r < board.GetLength(0) && c >= 0; r++, c--) if (!board[r, c]) board[r, c] = true;
            // cells in a diagonal from a given cell (row, col) to top right
            for (int r = row - 1, c = col + 1; r >= 0 && c < board.GetLength(1); r--, c++) if (!board[r, c]) board[r, c] = true;
            // cells in a diagonal from a given cell (row, col) to top left
            for (int r = row - 1, c = col - 1; r >= 0 && c >= 0; r--, c--) if (!board[r, c]) board[r, c] = true;
        }
    }
}