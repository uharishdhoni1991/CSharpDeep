using Bosscoder.Models;
using System;
using System.Collections.Generic;

namespace Bosscoder.Week_10_Trees.Homework_Questions
{
    //Nice sln , need to revise
    public class LT103_ZigZagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            //Need a result , action methods since we are going for iteration method
            if (root == null)
                return Array.Empty<IList<int>>();

            //Add a default space to fill it later 
            IList<IList<int>> result = new List<IList<int>> { new List<int>(1) };
            Queue<Stack<(TreeNode, int)>> queue = new Queue<Stack<(TreeNode, int)>>();

            //Action to Enqueue
            Action<TreeNode, int> enqueue = (node, level) =>
            {
                if (node == null)
                    return;

                if(queue.Count == 0)
                {
                    queue.Enqueue(new Stack<(TreeNode node, int level)>());
                }

                var stack = queue.Peek();
                stack.Push((node, level));
            };

            //Action to Add to Result
            Action<TreeNode, int> addToResult = (node, level) =>
            {
                if (node == null)
                    return;

                if (level >= result.Count)
                    result.Add(new List<int>());

                result[level].Add(node.Val);
            };

            enqueue(root, 0);

            while(queue.Count > 0)
            {
                var stack = queue.Dequeue();

                while(stack.Count > 0)
                {
                    var entry = stack.Pop();

                    addToResult(entry.Item1, entry.Item2);

                    if(entry.Item2 %2 == 0)
                    {
                        enqueue(entry.Item1.Left, entry.Item2 + 1);
                        enqueue(entry.Item1.Right, entry.Item2 + 1);
                    }
                    else
                    {
                        enqueue(entry.Item1.Right, entry.Item2 + 1);
                        enqueue(entry.Item1.Left, entry.Item2 + 1);
                    }
                }
            }

            return result;
        }
    }
}