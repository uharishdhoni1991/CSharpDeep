using Bosscoder.Models;
using System;
using System.Collections;
using System.Linq;

namespace Bosscoder.Week_10_Trees.Assignment_Questions
{
    public class LT106_ConstructBTUsingInandPost
    {
        private int[] _inOrder;
        private int[] _postOrder;
        private int _postOrderIndex;
        private Hashtable _hash;

        public TreeNode Solve(int[] inOrder, int[] postOrder)
        {
            if (inOrder == null || postOrder == null || inOrder.Length != postOrder.Length)
                return null;

            _inOrder = inOrder;
            _postOrder = postOrder;

            _postOrderIndex = postOrder.Length - 1;
            _hash = new Hashtable();

            for(int i =0; i < inOrder.Length; i++)
            {
                _hash[inOrder[i]] = i;
            }
            
            return ConstructTree(0, inOrder.Length - 1);
        }

        private TreeNode ConstructTree(int inOrderLeft, int inOrderRight)
        {
            if (inOrderLeft > inOrderRight)
                return null;

            int rootVal = _postOrder[_postOrderIndex];
            TreeNode root = new TreeNode(rootVal);

            int index = (int)_hash[rootVal];

            //recursion
            _postOrderIndex--;

            root.Right = ConstructTree(index + 1, inOrderRight);
            root.Left = ConstructTree(inOrderLeft, index - 1);

            return root;
        }
    }
}
