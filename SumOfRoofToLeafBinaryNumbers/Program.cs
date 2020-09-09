using System;
using System.Runtime.CompilerServices;

namespace SumOfRoofToLeafBinaryNumbers
{

    class Program
    {
        //Problem: https://leetcode.com/explore/challenge/card/september-leetcoding-challenge/555/week-2-september-8th-september-14th/3453/
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(0);
            root.right = new TreeNode(1);
            Console.WriteLine(SumRootToLeaf(root));
        }

        public static int SumRootToLeaf(TreeNode root)
        {
            return PreOrder(root, 0);
        }
        public static int PreOrder(TreeNode n, int val)
        {
            if (n == null) return 0;
            val = val << 1;
            val += n.val;
            if (n.left == null && n.right == null)
                return val;
            else return PreOrder(n.left, val) + PreOrder(n.right, val);
        }
    }



    // Definition for a binary tree node.
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    } 
}
