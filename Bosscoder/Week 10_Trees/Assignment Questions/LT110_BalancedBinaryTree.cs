using Bosscoder.Models;
using System;

namespace Bosscoder.Week_10_Trees.Assignment_Questions
{
    public class LT110_BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode node)
        {
            if (node == null)
                return true;

            if (Height(node) == -1)
                return false;

            return true;
        }

        private int Height(TreeNode node)
        {
            if (node == null)
                return 0;

            int leftHeight = Height(node.Left);
            int rightHeight = Height(node.Right);

            if (leftHeight == -1 || rightHeight == -1)
                return -1;

            if (Math.Abs(leftHeight - rightHeight) > 1)
                return -1;

            return Math.Max(leftHeight, rightHeight) + 1;//Keypoint 
        }
    }
}