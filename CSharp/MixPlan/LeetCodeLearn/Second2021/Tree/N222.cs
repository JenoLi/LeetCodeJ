using System;
using System.Collections.Generic;

namespace Second2021.Tree
{
    public class N222
    {
        // public int CountNodes(TreeNode root)
        // {
        //     if (root == null) return 0;
        //     Queue<TreeNode> queue = new Queue<TreeNode>();
        //     queue.Enqueue(root);
        //     int treeCount = 0;
        //     while (queue.Count>0)
        //     {
        //         int size = queue.Count;
        //         for (int i = 0; i < size; i++)
        //         {
        //             treeCount++;
        //             TreeNode temp = queue.Dequeue();
        //             if(temp.left!=null) queue.Enqueue(temp.left);
        //             if(temp.right!=null) queue.Enqueue(temp.right);
        //         }
        //     }
        //     return treeCount;
        // }

        //分别计算每个 子树的节点相加
        //效率在leetcode中和层序遍历差不多，可以通过记录值来避免重复计算
        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;
            TreeNode left = root.left;
            TreeNode right = root.right;
            int leftHeight = 0, rightHeight = 0; 
            while (left!=null) {  
                left = left.left;
                leftHeight++;
            }
            while (right!=null) { 
                right = right.right;
                rightHeight++;
            }
            if (leftHeight == rightHeight) {
                return (2 << leftHeight) - 1; // (2<<1) =2^2
            }
            return CountNodes(root.left) + CountNodes(root.right) + 1;
        }
        
        
        
    }
}