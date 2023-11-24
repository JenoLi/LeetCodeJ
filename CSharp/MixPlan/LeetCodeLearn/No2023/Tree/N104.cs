using System;
using System.Collections.Generic;

namespace No2023
{
    public class N104
    {
        //最大深度 递归
        public int MaxDepth(TreeNode root)
        {
            return GetDepth(root);
        }

        public int GetDepth(TreeNode root)
        {
            if (root == null) return 0;
            int left= GetDepth(root.left);
            int right= GetDepth(root.right);
            int depth = 1 + Math.Max(left, right);
            return depth;
        }

        
        //迭代
        // public int MaxDepth(TreeNode root)
        // {
        //     if (root == null) return 0;
        //     Queue<TreeNode> queue = new Queue<TreeNode>();
        //     queue.Enqueue(root);
        //     int depth = 0;
        //     while (queue.Count>0)
        //     {
        //         int size = queue.Count;
        //         depth++;
        //         for (int i = 0; i < size; i++)
        //         {
        //             TreeNode node = queue.Dequeue();
        //             if(node.left!=null) queue.Enqueue(node.left);
        //             if(node.right!=null) queue.Enqueue(node.right);
        //         }
        //     }
        //     return depth;
        // }
        
    }
}