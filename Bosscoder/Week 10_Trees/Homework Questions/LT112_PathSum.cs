using Bosscoder.Models;

namespace Bosscoder.Week_10_Trees.Homework_Questions
{
    public class LT112_PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            if (root.Left == null && root.Right == null)
                return root.Val == targetSum;

            bool hasLeftSum = HasPathSum(root.Left, targetSum - root.Val);
            bool hasRightSum = HasPathSum(root.Right, targetSum - root.Val);

            return hasLeftSum || hasRightSum;
        }       
    }
}