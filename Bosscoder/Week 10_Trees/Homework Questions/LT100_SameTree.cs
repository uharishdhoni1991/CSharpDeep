using Bosscoder.Models;

namespace Bosscoder.Week_10_Trees.Homework_Questions
{
    public class LT100_SameTree
    {
        public bool Solve(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 != null)
                return false;

            if(root2 == null && root1 != null)
                return false;

            if (root1 == null && root2 == null)
                return true;

            if (root1.Val != root2.Val)
                return false;

            return Solve(root1.Left, root2.Left) && Solve(root1.Right, root2.Right);
        }
    }
}
