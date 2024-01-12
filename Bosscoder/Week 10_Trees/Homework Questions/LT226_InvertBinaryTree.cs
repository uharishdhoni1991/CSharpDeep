using Bosscoder.Models;


namespace Bosscoder.Week_10_Trees.Homework_Questions
{
    public class LT226_InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root != null)
            {
                var temp = root.Left;
                root.Left = InvertTree(root.Right);
                root.Right = InvertTree(temp);
            }

            return root;
        }
    }
}