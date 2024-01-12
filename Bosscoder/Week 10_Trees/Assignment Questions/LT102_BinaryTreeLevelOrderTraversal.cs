using Bosscoder.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week_10_Trees.Assignment_Questions
{
    public class LT102_BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();

            if (root == null)
                return res;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                int count = queue.Count;
                List<int> level = new List<int>();

                for (int i = 0; i < count; i++)
                {
                    TreeNode temp = queue.Dequeue();
                    level.Add(temp.Val);

                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);

                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);
                }

                res.Add(level);
            }

            return res;
        }
    }
}
