using Bosscoder.Models;
using System;

namespace Bosscoder.Week_10_Trees.Homework_Questions
{
    public class LT404_SumOfLeftleaves
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;
            string direction = "D";

            sum = RecurseSum(sum, root, direction);

            return sum;
        }

        private int RecurseSum(int sum, TreeNode root, string direction)
        {
            if (root == null)
                return sum;

            if(root.Left == null && root.Right == null)
            {
                if(direction == "L")
                    sum += root.Val;

                return sum;
            }

            sum = RecurseSum(sum, root.Left, "L");
            sum = RecurseSum(sum, root.Right, "R");

            return sum;
        }
    }
}
