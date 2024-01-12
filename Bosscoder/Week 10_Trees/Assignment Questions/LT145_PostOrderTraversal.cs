using Bosscoder.Models;
using System.Collections.Generic;

namespace Bosscoder.Week_10_Trees.Assignment_Questions
{
    public class LT145_PostOrderTraversal
    {
        List<int> res = new List<int>();

        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null)
                return res;


            PostorderTraversal(root.Left);
            PostorderTraversal(root.Right);
            res.Add(root.Val);

            return res;
        }
    }
}
