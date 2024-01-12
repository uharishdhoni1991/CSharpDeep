using System;

namespace Bosscoder.Models
{
    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode() : this(0)
        {
        }

        public TreeNode(int val) : this(val, null)
        {
        }

        public TreeNode(int val, TreeNode left) : this(val, left, null)
        {
        }

        public TreeNode(int val, TreeNode left, TreeNode right)
        {
            Val = val;
            Left = left;
            Right = right;
        }

        public static bool IsIdentical(TreeNode root1, TreeNode root2)
        {
            bool isIdentical = false;

            // Check if both the trees are empty
            if (root1 == null && root2 == null)
                isIdentical = true;
            // If any one of the tree is non-empty
            // and other is empty, return false
            else if (root1 == null || root2 == null)
                isIdentical = false;
            else
            { // Check if current data of both trees equal
              // and recursively check for left and right subtrees
                isIdentical = root1.Val == root2.Val && IsIdentical(root1.Left, root2.Left)
                    && IsIdentical(root1.Right, root2.Right);                    
            }

            return isIdentical;
        }
    }
}
