using Bosscoder.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bosscoder.Week_10_Trees.Homework_Questions
{
    public class LT105_BuildTree
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder is null || !preorder.Any() || inorder is null || !inorder.Any()) 
                return null;

            int val = preorder[0];
            preorder = preorder.Skip(1).ToArray();

            TreeNode node = new TreeNode(val);
            int idx = Array.IndexOf(inorder, val);
            node.Left = BuildTree(preorder.Take(idx).ToArray(), inorder.Take(idx).ToArray());
            node.Right = BuildTree(preorder.Skip(idx).ToArray(), inorder.Skip(idx + 1).ToArray());
            return node;
        }
    }
}