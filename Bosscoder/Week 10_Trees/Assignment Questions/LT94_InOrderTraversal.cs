using Bosscoder.Models;
using System.Collections.Generic;

namespace Bosscoder.Week_10_Trees.Assignment_Questions
{
    public class LT94_InOrderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            Traverse(root, result);
            return result;
        }

        private void Traverse(TreeNode root, IList<int> result)
        {
            if (root == null)
                return;

            Traverse(root.Left, result);
            result.Add(root.Val);
            Traverse(root.Right, result);
        }
    }
}
