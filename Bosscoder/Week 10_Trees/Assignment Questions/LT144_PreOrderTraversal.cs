using Bosscoder.Models;
using System.Collections.Generic;

namespace Bosscoder.Week_10_Trees.Assignment_Questions
{
    public class LT144_PreOrderTraversal
    {
        List<int> result = new List<int>();

        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
                return result;

            result.Add(root.Val);
            PreorderTraversal(root.Left);
            PreorderTraversal(root.Right);

            return result;
        }
    }
}
