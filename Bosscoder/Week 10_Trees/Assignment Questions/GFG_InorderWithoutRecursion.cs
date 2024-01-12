using Bosscoder.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week_10_Trees.Assignment_Questions
{
    /*Intuition - Go extreme left and then right*/
    public class GFG_InorderWithoutRecursion
    {
        public List<int> Solve(TreeNode tree)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            while(true)
            {
                if(tree != null)//Going extreme left
                {
                    stack.Push(tree);
                    tree = tree.Left;
                }
                else //going right
                {
                    if (!stack.Any())
                        break;

                    tree = stack.Pop();
                    res.Add(tree.Val);

                    tree = tree.Right;
                }
            }

            return res;
        }
    }
}
