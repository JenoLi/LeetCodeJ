using System;
using System.Collections.Generic;

namespace Second2021.Tree
{
    public class N104
    {
        /// <summary>
        /// 二叉树最大深度
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        // public int MaxDepth(TreeNode root)
        // {
        //     Console.WriteLine($"MaxDepth");
        //     int depth = 0;
        //     Queue<TreeNode> queue = new Queue<TreeNode>();
        //     if (root == null) return depth;
        //     queue.Enqueue(root);
        //     while (queue.Count>0)
        //     {
        //         depth++;
        //         int size = queue.Count;
        //         for (int i = 0; i < size; i++)
        //         {
        //             TreeNode node = queue.Dequeue();
        //             if(node.left!=null) queue.Enqueue(node.left);
        //             if(node.right!=null) queue.Enqueue(node.right);
        //         }
        //     }
        //     return depth;
        // }
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            int depth = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count>0)
            {
                depth++;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode temp = queue.Dequeue();
                    if(temp.left!=null) queue.Enqueue(temp.left);
                    if(temp.right!=null) queue.Enqueue(temp.right);
                }

            }
            return depth;
        }
        
        
        
        
    }
}