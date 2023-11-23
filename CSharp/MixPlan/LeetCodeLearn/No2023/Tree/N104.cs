using System;
using System.Collections.Generic;

namespace No2023
{
    public class N104
    {
        //最大深度 递归
        // public int MaxDepth(TreeNode root)
        // {
        //     if (root == null) return 0;
        //     return TreeDepth(root);
        // }
        //
        // private int TreeDepth(TreeNode node)
        // {
        //     if (node == null) return 0;//根节点时返回
        //     int left = TreeDepth(node.left);
        //     int right = TreeDepth(node.right);
        //     int depth = 1 + Math.Max(left, right);
        //     return depth;
        // }

        
        //迭代
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int depth = 0;
            while (queue.Count>0)
            {
                int size = queue.Count;
                depth++;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if(node.left!=null) queue.Enqueue(node.left);
                    if(node.right!=null) queue.Enqueue(node.right);
                }
            }
            return depth;
        }
    }
}