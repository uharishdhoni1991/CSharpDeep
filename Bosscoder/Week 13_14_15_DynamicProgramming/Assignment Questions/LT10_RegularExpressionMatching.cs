using System;
using System.Collections.Generic;

namespace Bosscoder.Week_13_14_15_DynamicProgramming.Assignment_Questions
{
    public class LT10_RegularExpressionMatching
    {
        string _input;
        string _pattern;
        Dictionary<(int, int), bool> dp = new Dictionary<(int, int), bool>();

        public bool SolveDFS(string s, string pattern)
        {
            _input = s;
            _pattern = pattern;
            return DFS(0, 0);
        }

        public bool SolveDFS_Memo(string s, string pattern)
        {
            _input = s;
            _pattern = pattern;
            return DFS_Memoi_TopDown(0, 0);
        }

        [Recursion]
        private bool DFS(int i, int j)
        {
            if (i >= _input.Length && j >= _pattern.Length)
                return true;

            if (j >= _pattern.Length)
                return false;

            bool match = i < _input.Length && (_input[i] == _pattern[j] || _pattern[j] == '.');

            if (j + 1 < _pattern.Length && _pattern[j + 1] == '*')
                return DFS(i, j + 2) || match && DFS(i + 1, j);

            if (match)
                return DFS(i + 1, j + 1);

            return false;
        }

        [Memoization]
        private bool DFS_Memoi_TopDown(int i, int j)
        {
            if (dp.ContainsKey((i, j)))
                return dp[(i, j)];

            if (i >= _input.Length && j >= _pattern.Length)
                return true;

            if (j >= _pattern.Length)
                return false;

            bool match = i < _input.Length && (_input[i] == _pattern[j] || _pattern[j] == '.');

            if (j + 1 < _pattern.Length && _pattern[j + 1] == '*')
            {
                dp[(i, j)] = DFS(i, j + 2) || match && DFS(i + 1, j);
                return dp[(i, j)];
            }

            if (match)
            {
                dp[(i, j)] = DFS(i + 1, j + 1);
                return dp[(i, j)];
            }

            dp[(i, j)] = false;
            return dp[(i,j)];
        }

    }
}
