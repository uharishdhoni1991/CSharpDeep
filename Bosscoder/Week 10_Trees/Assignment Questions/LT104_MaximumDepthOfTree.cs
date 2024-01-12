using Bosscoder.Models;
using System;

namespace Bosscoder.Week_10_Trees.Assignment_Questions
{
    public class LT104_MaximumDepthOfTree
    {
        int maxDepth = int.MinValue;

        public int MaxDepth(TreeNode root)
        {
            maxDepth = RecurseMaxDepth(root, maxDepth, 0);
            return maxDepth;
        }

        private int RecurseMaxDepth(TreeNode root, int maxDepth, int depth)
        {
            if (root == null)
                return 0;

            if(root.Left == null && root.Right == null)
            {
                depth++;
                return maxDepth = Math.Max(depth, maxDepth);
            }

            maxDepth = Math.Max(maxDepth, RecurseMaxDepth(root.Left, maxDepth, depth+1));
            maxDepth = Math.Max(maxDepth, RecurseMaxDepth(root.Right, maxDepth, depth+1));

            return maxDepth;
        }
    }
}
